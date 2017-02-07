using System;
using System.IO;

namespace DHAF
{
	/// <summary>Hides/extracts data in/from a wave stream</summary>
	public class WaveUtility
	{
		/// <summary>
		/// The read-only stream.
		/// Clean wave for hiding,
		/// Carrier wave for extracting
		/// </summary>
		private WaveStream sourceStream;
		
		/// <summary>Stream to receive the edited carrier wave</summary>
		private Stream destinationStream;
		
		/// <summary>bits per sample / 8</summary>
		private int bytesPerSample;

		/// <summary>Initializes a new WaveUtility for hiding a message</summary>
		/// <param name="sourceStream">Clean wave</param>
		/// <param name="destinationStream">
		/// Header of the clean wave
		/// This stream will receive the complete carrier wave
		/// </param>
		public WaveUtility(WaveStream sourceStream, Stream destinationStream)
			:this(sourceStream)
		{
			this.destinationStream = destinationStream;
		}

		/// <summary>Initializes a new WaveUtility for extracting a message</summary>
		/// <param name="sourceStream">Carrier wave</param>
		public WaveUtility(WaveStream sourceStream) 
		{
			this.sourceStream = sourceStream;
			this.bytesPerSample = sourceStream.Format.wBitsPerSample / 8;
		}

		/// <summary>
		/// Hide [messageStream] in [sourceStream],
		/// write the result to [destinationStream]
		/// </summary>
		/// <param name="messageStream">The message to hide</param>
		/// <param name="keyStream">
		/// A key stream that specifies how many samples shall be
		/// left clean between two changed samples
		/// </param>
		public void Hide(Stream messageStream, Stream keyStream)
		{
			
			byte[] waveBuffer = new byte[bytesPerSample];
			byte message, bit, waveByte;
			int messageBuffer; //receives the next byte of the message or -1
			int keyByte; //distance of the next carrier sample
			
			while( (messageBuffer=messageStream.ReadByte()) >= 0 )
			{
				//read one byte of the message stream
				message = (byte)messageBuffer;
				
				//for each bit in message
				for(int bitIndex=0; bitIndex<8; bitIndex++)
				{
					
					//read a byte from the key
					keyByte = GetKeyValue(keyStream);
					
					//skip a couple of samples
					for(int n=0; n<keyByte-1; n++)
					{
						//copy one sample from the clean stream to the carrier stream
						sourceStream.Copy(waveBuffer, 0, waveBuffer.Length, destinationStream);
					}

					//read one sample from the wave stream
					sourceStream.Read(waveBuffer, 0, waveBuffer.Length);
					waveByte = waveBuffer[bytesPerSample-1];
					
					//get the next bit from the current message byte...
					bit = (byte)(((message & (byte)(1 << bitIndex)) > 0) ? 1 : 0);
						
					//...place it in the last bit of the sample
					if((bit == 1) && ((waveByte % 2) == 0))
					{
						waveByte += 1;
					}
					else if((bit == 0) && ((waveByte % 2) == 1))
					{
						waveByte -= 1;
					}

					waveBuffer[bytesPerSample-1] = waveByte;

					//write the result to destinationStream
					destinationStream.Write(waveBuffer, 0, bytesPerSample);
				
				}
			}

			//copy the rest of the wave without changes
			waveBuffer = new byte[sourceStream.Length - sourceStream.Position];
			sourceStream.Read(waveBuffer, 0, waveBuffer.Length);
			destinationStream.Write(waveBuffer, 0, waveBuffer.Length);
			Console.WriteLine( "Written");
		}

		/// <summary>Extract a message from [sourceStream] into [messageStream]</summary>
		/// <param name="messageStream">Empty stream to receive the extracted message</param>
		/// <param name="keyStream">
		/// A key stream that specifies how many samples shall be
		/// skipped between two carrier samples
		/// </param>
		public void Extract(Stream messageStream, Stream keyStream)
		{
		
			byte[] waveBuffer = new byte[bytesPerSample];
			byte message, bit, waveByte;
			int messageLength = 0; //expected length of the message
			int keyByte; //distance of the next carrier sample
			
			while( (messageLength==0 || messageStream.Length<messageLength) )
			{
				//clear the message-byte
				message = 0;
				
				//for each bit in message
				for(int bitIndex=0; bitIndex<8; bitIndex++)
				{

					//read a byte from the key
					keyByte = GetKeyValue(keyStream);
					
					//skip a couple of samples
					for(int n=0; n<keyByte; n++)
					{
						//read one sample from the wave stream
						sourceStream.Read(waveBuffer, 0, waveBuffer.Length);
					}
					waveByte = waveBuffer[bytesPerSample-1];
					
					//get the last bit of the sample...
					bit = (byte)(((waveByte % 2) == 0) ? 0 : 1);

					//...write it into the message-byte
					message += (byte)(bit << bitIndex);
				}

				//add the re-constructed byte to the message
				messageStream.WriteByte(message);
				
				if(messageLength==0 && messageStream.Length==4)
				{
					//first 4 bytes contain the message's length
					messageStream.Seek(0, SeekOrigin.Begin);
					messageLength = new BinaryReader(messageStream).ReadInt32();
					messageStream.Seek(0, SeekOrigin.Begin);
					messageStream.SetLength(0);
				}
			}
			Console.WriteLine ("extra");

		}
		
		/// <summary>Counts the samples that will be skipped using the specified key stream</summary>
		/// <param name="keyStream">Key stream</param>
		/// <param name="messageLength">Length of the message</param>
		/// <returns>Minimum length (in samples) of an audio file</returns>
		public static long CheckKeyForMessage(Stream keyStream, long messageLength)
		{

			long requiredLength = 0, messageLengthBits = messageLength*8;
		
			for(int n=0; n<messageLengthBits; n++)
			{
				requiredLength += GetKeyValue(keyStream);
				Console.WriteLine (requiredLength.ToString ());
				//c:\soulful.wav
				
			}
			
			keyStream.Seek(0, SeekOrigin.Begin);
			Console.WriteLine (requiredLength);
			return requiredLength;
			
		}
		
		/// <summary>
		/// Read the next byte of the key stream.
		/// Reset the stream if it is too short.
		/// </summary>
		/// <param name="keyStream">The key stream</param>
		/// <returns>The next key byte</returns>
		private static byte GetKeyValue(Stream keyStream)
		{
			int keyValue;
			if( (keyValue=keyStream.ReadByte()) < 0)
			{
				keyStream.Seek(0, SeekOrigin.Begin);
				keyValue=keyStream.ReadByte();
				if(keyValue == 0){ keyValue=1; }
			}
				
			return (byte)keyValue;
			
		}
	}
}
