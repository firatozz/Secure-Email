using System;

namespace DHAF
{
	/// <summary>
	/// Summary description for clsEmbed.
	/// </summary>
	public class clsEmbed
	{
		private int CurEmbedStep=0;
		private string AudioFileName="";
		private string KeyFileName="";
		private string OutputAudioFile="";
		private string EmdedDataType ="";  // File,Text
		private string EmbedTextFileName=""; //This will be assigned when embedDataType='File'
private string EmbedTextMessage="";
	
	public int PropEmbedStep
	{
		get
		{
			return CurEmbedStep;
		}
		set
		{
			CurEmbedStep = value;
		}
	}

		public string PropAudioFileName
		{
			get
			{
				// Returns the value stored in the local variable
				return AudioFileName;
			}
			set
			{
				// Sets the value of the local variable
				AudioFileName = value;
			}
		}
		public string PropKeyFileName
		{
			get
			{
				return KeyFileName;
			}
			set
			{
				KeyFileName=value;
			}
		}
		public string PropOutputAudioFile
		{
			get
			{
				return OutputAudioFile;
			}
			set
			{
			OutputAudioFile=value;
			}
			
		
		}

		public string PropEmbedDataType
		{
			get
			{
				return EmdedDataType;
			}
			set
			{
				EmdedDataType=value;
			}
		}
		public string PropEmbedTextMessage
		{
			get
			{
				return EmbedTextMessage;
			}
			set
			{
				EmbedTextMessage=value;
			}
		}
		public string PropEmbedTextFileName
		{
			get
			{
				return EmbedTextFileName;
			}
			set
			{
				EmbedTextFileName=value;
			}
		}
	
		public clsEmbed()
		{
			//
			// TODO: Add constructor logic here
			//
		}
	}
}
