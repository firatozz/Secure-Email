using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.IO;

namespace DHAF
{
	/// <summary>
	/// Summary description for frmWizard.
	/// </summary>
	public class frmExtract: System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.Button button7;
		private AxWMPLib.AxWindowsMediaPlayer WMP;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox txtInputAudioFile;
		private System.Windows.Forms.TextBox txtVerify;
		private System.Windows.Forms.TextBox txtKeyFile;
		private System.Windows.Forms.TextBox txtOutputTextFile;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox txtExtractedMessage;
		private System.Windows.Forms.Label label2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmExtract()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.SuspendLayout();
            // 
            // frmExtract
            // 
            this.ClientSize = new System.Drawing.Size(282, 253);
            this.Name = "frmExtract";
            this.Load += new System.EventHandler(this.frmExtract_Load);
            this.ResumeLayout(false);

		}
		#endregion
		clsExtract obj1;
		private void frmWizard1_Load(object sender, System.EventArgs e)
		{
			listBox1.Items.Add("1.Select encrypted audio file.");
			listBox1.Items.Add("2.Enter New Text File.");
			listBox1.Items.Add("3.Enter Key File.");
			listBox1.Items.Add("4.Verify options.");
			listBox1.Items.Add("5.Extracting data from the audio.");
			listBox1.Items.Add("6.View output text file.");
			listBox1.SelectedIndex=0;

			obj1=new clsExtract();
			
			//	a.

		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if(button4.Text =="Finish") 
			{
				this.Close ();
				return;
			}
			if (obj1.PropEmbedStep ==0 &&  txtInputAudioFile.Text=="")
			{
				MessageBox.Show("Please Select Audio FileName");
				return ;
			}
			else if(obj1.PropEmbedStep ==1 &&  txtOutputTextFile.Text=="")
			{
				MessageBox.Show("Please Select Output Text File");
				return;
			}
			else if(obj1.PropEmbedStep ==2 &&  txtKeyFile.Text=="")
			{
				MessageBox.Show("Please Select Key Text File");
				return;
			}
			else
				showNextStep();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

		private void button2_Click(object sender, System.EventArgs e)
		{
			if(openFileDialog1.ShowDialog() ==DialogResult.OK)
			{
				obj1.PropAudioFileName=openFileDialog1.FileName;			
				txtInputAudioFile.Text=obj1.PropAudioFileName;
			}
		}

		private void showNextStep()
		{
			
			obj1.PropEmbedStep+=1;
			
			if (listBox1.SelectedIndex<6)
			{
				listBox1.SelectedIndex+=1;
			}
			WMP.URL="";
			groupBox1.Visible=false;
			groupBox2.Visible=false;
			groupBox3.Visible=false;
			groupBox4.Visible=false;
			groupBox5.Visible=false;
			groupBox6.Visible=false;
		
			switch(obj1.PropEmbedStep)
			{
				case 1:
					groupBox2.Visible=true;
					button3.Enabled=true;
					break;
				case 2:
					groupBox3.Visible=true;
					
					break;
				case 3:
					groupBox4.Visible=true;
					System.Text.StringBuilder s=new System.Text.StringBuilder ("");
					s.Append ("Audio File:" + txtInputAudioFile.Text  +"\r\n");
					s.Append ("New Text File:" + txtOutputTextFile.Text   +"\r\n");
					obj1.PropKeyFileName =txtKeyFile.Text ;
					s.Append ("Key File :" + obj1.PropKeyFileName  + "\r\n");
					txtVerify.Text =s.ToString ();
					break;
				case 4:
					groupBox5.Visible=true;
					ExtractData();
					break;
				case 5:
					groupBox6.Visible=true;
					button4.Text="Finish";
					break;
			}
		}

		private void showPrevStep()
		{
			obj1.PropEmbedStep-=1;
			if (listBox1.SelectedIndex>0)
			{
				listBox1.SelectedIndex-=1;
			}
			groupBox1.Visible=false;
			groupBox2.Visible=false;
			groupBox3.Visible=false;
			groupBox4.Visible=false;
			groupBox5.Visible=false;
			groupBox6.Visible=false;
			
			switch(obj1.PropEmbedStep)
			{
				case 0:
					groupBox1.Visible=true;
					button3.Enabled=false;
					break;
				case 1:
					groupBox2.Visible=true;
					break;
				case 2:
					groupBox3.Visible=true;
					break;
				case 3:
					groupBox4.Visible=true;
					break;
				case 4:
					groupBox5.Visible=true;
					break;
				case 5:
					groupBox6.Visible=true;
					button4.Enabled=true;
					break;
			}
		

		}

		private void button3_Click(object sender, System.EventArgs e)
		{
			showPrevStep();
		}

		private void button9_Click(object sender, System.EventArgs e)
		{
			saveFileDialog1.Title ="New Text File";
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtOutputTextFile.Text =saveFileDialog1.FileName;
				obj1.PropOutputTextFile=txtOutputTextFile.Text ;
			}
		}

		private void txtEmbedMessage_TextChanged(object sender, System.EventArgs e)
		{
		
		}

//		private void button6_Click(object sender, System.EventArgs e)
//		{
//			openFileDialog1.Filter ="Text Files (*.wav) | *.wav";
//			if(openFileDialog2.ShowDialog() ==DialogResult.OK)
//			{
//				obj1.PropEmbedTextFileName=openFileDialog2.FileName;			
//				txtEmbedTextFile.Text=obj1.PropEmbedTextFileName;
//			}
//		}

		

		private void button7_Click(object sender, System.EventArgs e)
		{
openFileDialog1.Title ="Open Text File";
			openFileDialog1.Filter ="Text Files (*.txt) | *.txt";
			if(openFileDialog1.ShowDialog() ==DialogResult.OK)
			{
				
				obj1.PropKeyFileName=openFileDialog1.FileName;			
				txtKeyFile.Text=obj1.PropKeyFileName;
			}
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			//WMP.newMedia (txtInputAudioFile.Text );
			//WMP.launchURL (txtInputAudioFile.Text );
			WMP.URL =txtInputAudioFile.Text;
			
			//WMP.openPlayer (txtInputAudioFile.Text);
			//
			//WMP.openPlayer (txtInputAudioFile.Text );
			//System.Diagnostics.Process.Start (txtInputAudioFile.Text );
		}

//		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
//		{
//			if(radioButton1.Checked==true)
//			{
//				button6.Enabled =true;
//				txtEmbedMessage.Enabled =false;
//				obj1.PropEmbedDataType ="File";
//				
//			}
//		}

//		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
//		{
//			if(radioButton2.Checked==true)
//			{
//				txtEmbedMessage.Enabled =true;
//				button6.Enabled =false;
//				obj1.PropEmbedDataType ="Text";
//			}
//
//		}
		/// <summary>
		/// Extracting Data
		/// </summary>
		public void ExtractData()
		{
		
			this.Cursor = Cursors.WaitCursor;
			
			FileStream sourceStream = null;
			WaveStream audioStream = null;
			//create an empty stream to receive the extracted message
			MemoryStream messageStream = new MemoryStream();
			//open the key file
			Stream keyStream = new FileStream(txtKeyFile.Text, FileMode.Open);
			textBox6.Text ="Key File Opened...\r\n";
			try 
			{
				//open the carrier file
				sourceStream = new FileStream(txtInputAudioFile.Text, FileMode.Open);
				textBox6.Text +="Audio File Opened...\r\n";
				audioStream = new WaveStream(sourceStream);
				WaveUtility utility = new WaveUtility(audioStream);
			
				//exctract the message from the carrier wave
				textBox6.Text +="Start Extracting ...\r\n";
				utility.Extract(messageStream, keyStream);
				textBox6.Text +="Finished Extracting ...\r\n";
				messageStream.Seek(0, SeekOrigin.Begin);
				 //save result to a file
					FileStream fs = new FileStream(txtOutputTextFile.Text, FileMode.Create);
						
					byte[] buffer = new byte[messageStream.Length];
					messageStream.Read(buffer, 0, buffer.Length);
messageStream.Seek (0, System.IO.SeekOrigin.Begin );
					txtExtractedMessage.Text = new StreamReader(messageStream).ReadToEnd();					
					fs.Write(buffer, 0, buffer.Length);
					fs.Close();
				//}
				//else
				//{ //display result
					//txtExtractedMessage.Text = new StreamReader(messageStream).ReadToEnd();					
				//}
			}
			catch(Exception ex) 
			{
				this.Cursor = Cursors.Default;
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if(keyStream != null){ keyStream.Close(); }
				if(messageStream != null){ messageStream.Close(); }
				if(audioStream != null){ audioStream.Close(); }
				if(sourceStream != null){ sourceStream.Close(); }
				this.Cursor = Cursors.Default;
			}
		}
//
//		/// <summary>Write length an content of the message file/text into a stream</summary>
//		/// <returns></returns>
//		private  Stream GetMessageStream()
//		{
//			BinaryWriter messageWriter = new BinaryWriter(new MemoryStream());
//			if( obj1.PropEmbedDataType =="File")
//			{
//				FileStream fs = new FileStream(obj1.PropEmbedTextFileName, FileMode.Open);
//				int fileLength = (int)fs.Length;
//				messageWriter.Write(fileLength);
//				Console.WriteLine (fileLength);
//				byte[] buffer = new byte[fs.Length];
//				fs.Read(buffer, 0, fileLength);
//				messageWriter.Write(buffer);
//				fs.Close();
//				
//			}
//			else
//			{
//				messageWriter.Write(txtEmbedMessage.Text.Length);
//				Console.WriteLine (txtEmbedMessage.Text.Length);
//				messageWriter.Write(Encoding.ASCII.GetBytes(txtEmbedMessage.Text));
//			}
//			
//			messageWriter.Seek(0, SeekOrigin.Begin);
//			return messageWriter.BaseStream;			
//		}

		private void button6_Click_1(object sender, System.EventArgs e)
		{
			System.Diagnostics.Process.Start (txtOutputTextFile.Text );
		}

		private void label2_Click(object sender, System.EventArgs e)
		{
		
		}

		private void txtExtractedMessage_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

        private void frmExtract_Load(object sender, EventArgs e)
        {

        }
	}
}
