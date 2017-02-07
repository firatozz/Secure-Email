using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Text;
using System.Threading;
using System.IO;
using WMPLib;
namespace DHAF
{
	/// <summary>
	/// Summary description for frmWizard.
	/// </summary>
	public class frmWizard1 : System.Windows.Forms.Form
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
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.GroupBox groupBox3;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.GroupBox groupBox4;
		private System.Windows.Forms.GroupBox groupBox5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBox6;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.GroupBox groupBox7;
		private System.Windows.Forms.RadioButton radioButton3;
		private System.Windows.Forms.RadioButton radioButton4;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.OpenFileDialog openFileDialog2;
		private System.Windows.Forms.Button button7;
		private AxWMPLib.AxWindowsMediaPlayer WMP;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
		private System.Windows.Forms.TextBox txtInputAudioFile;
		private System.Windows.Forms.TextBox txtVerify;
		private System.Windows.Forms.TextBox txtKeyFile;
		private System.Windows.Forms.TextBox txtEmbedMessage;
		private System.Windows.Forms.TextBox txtEmbedTextFile;
		private System.Windows.Forms.TextBox txtOutputAudioFile;
		private AxWMPLib.AxWindowsMediaPlayer WMP2;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWizard1()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmWizard1));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.WMP = new AxWMPLib.AxWindowsMediaPlayer();
			this.button2 = new System.Windows.Forms.Button();
			this.txtInputAudioFile = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.button9 = new System.Windows.Forms.Button();
			this.txtOutputAudioFile = new System.Windows.Forms.TextBox();
			this.button10 = new System.Windows.Forms.Button();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.groupBox3 = new System.Windows.Forms.GroupBox();
			this.button6 = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.txtEmbedTextFile = new System.Windows.Forms.TextBox();
			this.txtEmbedMessage = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.button7 = new System.Windows.Forms.Button();
			this.txtKeyFile = new System.Windows.Forms.TextBox();
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.txtVerify = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBox6 = new System.Windows.Forms.GroupBox();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.groupBox7 = new System.Windows.Forms.GroupBox();
			this.WMP2 = new AxWMPLib.AxWindowsMediaPlayer();
			this.radioButton3 = new System.Windows.Forms.RadioButton();
			this.radioButton4 = new System.Windows.Forms.RadioButton();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WMP)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.groupBox3.SuspendLayout();
			this.groupBox4.SuspendLayout();
			this.groupBox5.SuspendLayout();
			this.groupBox6.SuspendLayout();
			this.groupBox7.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.WMP2)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.WMP);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.txtInputAudioFile);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(200, 20);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 283);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Step 1 of 7";
			this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
			// 
			// WMP
			// 
			this.WMP.ContainingControl = this;
			this.WMP.Enabled = true;
			this.WMP.Location = new System.Drawing.Point(16, 56);
			this.WMP.Name = "WMP";
			this.WMP.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP.OcxState")));
			this.WMP.Size = new System.Drawing.Size(440, 160);
			this.WMP.TabIndex = 6;
			this.WMP.Enter += new System.EventHandler(this.WMP_Enter);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(328, 248);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(136, 24);
			this.button2.TabIndex = 5;
			this.button2.Text = "Select Audio File";
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// txtInputAudioFile
			// 
			this.txtInputAudioFile.Location = new System.Drawing.Point(16, 248);
			this.txtInputAudioFile.Name = "txtInputAudioFile";
			this.txtInputAudioFile.ReadOnly = true;
			this.txtInputAudioFile.Size = new System.Drawing.Size(304, 20);
			this.txtInputAudioFile.TabIndex = 4;
			this.txtInputAudioFile.Text = "";
			this.txtInputAudioFile.TextChanged += new System.EventHandler(this.txtInputAudioFile_TextChanged);
			// 
			// button1
			// 
			this.button1.Enabled = false;
			this.button1.Location = new System.Drawing.Point(16, 224);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(440, 23);
			this.button1.TabIndex = 3;
			this.button1.Text = "Play Audio";
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((System.Byte)(255)), ((System.Byte)(255)), ((System.Byte)(192)));
			this.pictureBox1.Location = new System.Drawing.Point(16, 48);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(440, 160);
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(440, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Audio Preview";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button5
			// 
			this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button5.Location = new System.Drawing.Point(616, 328);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(64, 24);
			this.button5.TabIndex = 8;
			this.button5.Text = "Cancel";
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button4
			// 
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button4.Location = new System.Drawing.Point(544, 328);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(64, 24);
			this.button4.TabIndex = 7;
			this.button4.Text = "Next";
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.button3.Location = new System.Drawing.Point(472, 328);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(64, 24);
			this.button3.TabIndex = 6;
			this.button3.Text = "Back";
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// listBox1
			// 
			this.listBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.listBox1.Location = new System.Drawing.Point(8, 16);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(176, 303);
			this.listBox1.TabIndex = 1;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.button9);
			this.groupBox2.Controls.Add(this.txtOutputAudioFile);
			this.groupBox2.Controls.Add(this.button10);
			this.groupBox2.Controls.Add(this.pictureBox2);
			this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox2.Location = new System.Drawing.Point(200, 20);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(480, 300);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Step 2 of 7";
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(328, 244);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(128, 20);
			this.button9.TabIndex = 11;
			this.button9.Text = "Select Output File";
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// txtOutputAudioFile
			// 
			this.txtOutputAudioFile.AutoSize = false;
			this.txtOutputAudioFile.Location = new System.Drawing.Point(16, 244);
			this.txtOutputAudioFile.Name = "txtOutputAudioFile";
			this.txtOutputAudioFile.ReadOnly = true;
			this.txtOutputAudioFile.Size = new System.Drawing.Size(304, 20);
			this.txtOutputAudioFile.TabIndex = 10;
			this.txtOutputAudioFile.Text = "";
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(480, 176);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(75, 24);
			this.button10.TabIndex = 8;
			this.button10.Text = "button3";
			// 
			// pictureBox2
			// 
			this.pictureBox2.BackColor = System.Drawing.Color.White;
			this.pictureBox2.Location = new System.Drawing.Point(16, 24);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(440, 208);
			this.pictureBox2.TabIndex = 9;
			this.pictureBox2.TabStop = false;
			// 
			// groupBox3
			// 
			this.groupBox3.Controls.Add(this.button6);
			this.groupBox3.Controls.Add(this.label6);
			this.groupBox3.Controls.Add(this.txtEmbedTextFile);
			this.groupBox3.Controls.Add(this.txtEmbedMessage);
			this.groupBox3.Controls.Add(this.radioButton2);
			this.groupBox3.Controls.Add(this.radioButton1);
			this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox3.Location = new System.Drawing.Point(200, 20);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new System.Drawing.Size(480, 300);
			this.groupBox3.TabIndex = 10;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Step 3 of 7";
			// 
			// button6
			// 
			this.button6.Enabled = false;
			this.button6.Location = new System.Drawing.Point(352, 264);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(112, 23);
			this.button6.TabIndex = 6;
			this.button6.Text = "Select Text File";
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(32, 240);
			this.label6.Name = "label6";
			this.label6.TabIndex = 5;
			this.label6.Text = "FileName";
			// 
			// txtEmbedTextFile
			// 
			this.txtEmbedTextFile.AutoSize = false;
			this.txtEmbedTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEmbedTextFile.Location = new System.Drawing.Point(24, 264);
			this.txtEmbedTextFile.Multiline = true;
			this.txtEmbedTextFile.Name = "txtEmbedTextFile";
			this.txtEmbedTextFile.ReadOnly = true;
			this.txtEmbedTextFile.Size = new System.Drawing.Size(312, 22);
			this.txtEmbedTextFile.TabIndex = 4;
			this.txtEmbedTextFile.Text = "";
			// 
			// txtEmbedMessage
			// 
			this.txtEmbedMessage.AutoSize = false;
			this.txtEmbedMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.txtEmbedMessage.Location = new System.Drawing.Point(24, 72);
			this.txtEmbedMessage.Multiline = true;
			this.txtEmbedMessage.Name = "txtEmbedMessage";
			this.txtEmbedMessage.Size = new System.Drawing.Size(432, 136);
			this.txtEmbedMessage.TabIndex = 3;
			this.txtEmbedMessage.Text = "";
			this.txtEmbedMessage.TextChanged += new System.EventHandler(this.txtEmbedMessage_TextChanged);
			// 
			// radioButton2
			// 
			this.radioButton2.Checked = true;
			this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton2.Location = new System.Drawing.Point(248, 32);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 2;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Enter Text";
			this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
			// 
			// radioButton1
			// 
			this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton1.Location = new System.Drawing.Point(112, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 1;
			this.radioButton1.Text = "Select File";
			this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
			// 
			// groupBox4
			// 
			this.groupBox4.BackColor = System.Drawing.Color.White;
			this.groupBox4.Controls.Add(this.button7);
			this.groupBox4.Controls.Add(this.txtKeyFile);
			this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox4.Location = new System.Drawing.Point(200, 20);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(480, 300);
			this.groupBox4.TabIndex = 11;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "Step 4 of 7";
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(320, 32);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(136, 24);
			this.button7.TabIndex = 9;
			this.button7.Text = "Select Key File";
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// txtKeyFile
			// 
			this.txtKeyFile.Location = new System.Drawing.Point(16, 32);
			this.txtKeyFile.Name = "txtKeyFile";
			this.txtKeyFile.ReadOnly = true;
			this.txtKeyFile.Size = new System.Drawing.Size(304, 20);
			this.txtKeyFile.TabIndex = 8;
			this.txtKeyFile.Text = "";
			// 
			// groupBox5
			// 
			this.groupBox5.BackColor = System.Drawing.Color.White;
			this.groupBox5.Controls.Add(this.txtVerify);
			this.groupBox5.Controls.Add(this.label4);
			this.groupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox5.Location = new System.Drawing.Point(200, 20);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(480, 300);
			this.groupBox5.TabIndex = 12;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Step 5 of 7";
			// 
			// txtVerify
			// 
			this.txtVerify.Location = new System.Drawing.Point(24, 24);
			this.txtVerify.Multiline = true;
			this.txtVerify.Name = "txtVerify";
			this.txtVerify.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txtVerify.Size = new System.Drawing.Size(440, 208);
			this.txtVerify.TabIndex = 26;
			this.txtVerify.Text = "";
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label4.Location = new System.Drawing.Point(16, 248);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(400, 24);
			this.label4.TabIndex = 25;
			this.label4.Text = "Click Next to start the Embeded Process";
			// 
			// groupBox6
			// 
			this.groupBox6.Controls.Add(this.textBox6);
			this.groupBox6.Controls.Add(this.label5);
			this.groupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox6.Location = new System.Drawing.Point(200, 20);
			this.groupBox6.Name = "groupBox6";
			this.groupBox6.Size = new System.Drawing.Size(480, 300);
			this.groupBox6.TabIndex = 13;
			this.groupBox6.TabStop = false;
			this.groupBox6.Text = "Step 6 of 7";
			// 
			// textBox6
			// 
			this.textBox6.AutoSize = false;
			this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.textBox6.Location = new System.Drawing.Point(24, 72);
			this.textBox6.Multiline = true;
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(432, 192);
			this.textBox6.TabIndex = 1;
			this.textBox6.Text = "";
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.label5.Location = new System.Drawing.Point(24, 24);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(416, 40);
			this.label5.TabIndex = 0;
			this.label5.Text = "Actions:";
			// 
			// groupBox7
			// 
			this.groupBox7.Controls.Add(this.WMP2);
			this.groupBox7.Controls.Add(this.radioButton3);
			this.groupBox7.Controls.Add(this.radioButton4);
			this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.groupBox7.Location = new System.Drawing.Point(200, 20);
			this.groupBox7.Name = "groupBox7";
			this.groupBox7.Size = new System.Drawing.Size(480, 300);
			this.groupBox7.TabIndex = 14;
			this.groupBox7.TabStop = false;
			this.groupBox7.Text = "Step 7 of 7";
			// 
			// WMP2
			// 
			this.WMP2.ContainingControl = this;
			this.WMP2.Enabled = true;
			this.WMP2.Location = new System.Drawing.Point(24, 48);
			this.WMP2.Name = "WMP2";
			this.WMP2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("WMP2.OcxState")));
			this.WMP2.Size = new System.Drawing.Size(440, 160);
			this.WMP2.TabIndex = 7;
			// 
			// radioButton3
			// 
			this.radioButton3.Checked = true;
			this.radioButton3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton3.Location = new System.Drawing.Point(264, 224);
			this.radioButton3.Name = "radioButton3";
			this.radioButton3.Size = new System.Drawing.Size(112, 24);
			this.radioButton3.TabIndex = 2;
			this.radioButton3.TabStop = true;
			this.radioButton3.Text = "Play Input Audio";
			this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
			// 
			// radioButton4
			// 
			this.radioButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((System.Byte)(0)));
			this.radioButton4.Location = new System.Drawing.Point(112, 224);
			this.radioButton4.Name = "radioButton4";
			this.radioButton4.Size = new System.Drawing.Size(128, 24);
			this.radioButton4.TabIndex = 1;
			this.radioButton4.Text = "Play Output Audio";
			this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.Filter = "Wave Files (*.wav) | *.wav";
			this.openFileDialog1.InitialDirectory = "c:\\";
			this.openFileDialog1.ShowHelp = true;
			this.openFileDialog1.ShowReadOnly = true;
			this.openFileDialog1.Title = "Open Audio File";
			// 
			// openFileDialog2
			// 
			this.openFileDialog2.Filter = "Text Files (*.txt) | *.txt";
			this.openFileDialog2.InitialDirectory = "c:\\";
			this.openFileDialog2.ShowHelp = true;
			this.openFileDialog2.ShowReadOnly = true;
			this.openFileDialog2.Title = "Open Text File";
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.Filter = "Audio Files (*.wav) | *.wav";
			this.saveFileDialog1.Title = "Output Audio File";
			// 
			// frmWizard1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(692, 362);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.groupBox5);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.groupBox3);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox7);
			this.Controls.Add(this.groupBox6);
			this.Name = "frmWizard1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Step";
			this.Load += new System.EventHandler(this.frmWizard1_Load);
			this.groupBox1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WMP)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox3.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox5.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox7.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.WMP2)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion
	clsEmbed obj1;
		private void frmWizard1_Load(object sender, System.EventArgs e)
		{
			listBox1.Items.Add("1.Select an input audio file.");
			listBox1.Items.Add("2.Select an output audio file.");
			listBox1.Items.Add("3.Select data to embed.");
			listBox1.Items.Add("4.Enter Key File.");
            listBox1.Items.Add("5.Verify options.");
			listBox1.Items.Add("6.Embededding data in to the audio.");
			listBox1.Items.Add("7.View output file.");
			listBox1.SelectedIndex=0;
			button1.Enabled=false;

		obj1=new clsEmbed();
			
		//	a.

		}

		private void button4_Click(object sender, System.EventArgs e)
		{
			if(button4.Text =="Finish") 
			{
				this.Close ();
				return;
			}
			else if (obj1.PropEmbedStep==0 &&  txtInputAudioFile.Text=="")
			{
				MessageBox.Show("Please Select Audio FileName");
				return ;
			}
			else if(obj1.PropEmbedStep ==1 &&  txtOutputAudioFile.Text=="")
			{
				MessageBox.Show("Please Select Output Audio File");
				return;
			}
			if(obj1.PropEmbedStep ==2 && radioButton2.Checked==true && txtEmbedMessage.Text=="")
			{MessageBox.Show("Please Enter Text Message");
				return;
			}
			else if(obj1.PropEmbedStep ==2 && radioButton1.Checked==true && txtEmbedTextFile.Text=="")
			{
				button6.Enabled=true;
			MessageBox.Show("Please Select TextFileName");
				return;
			}
			else if(obj1.PropEmbedStep ==3  && txtKeyFile.Text=="")
			{
				MessageBox.Show("Please Select Key Text FileName");
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
			openFileDialog1.Title ="Open Audio File";
			if(openFileDialog1.ShowDialog() ==DialogResult.OK)
			{
			obj1.PropAudioFileName=openFileDialog1.FileName;			
				txtInputAudioFile.Text=obj1.PropAudioFileName;
				button1.Enabled=true;

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
			groupBox7.Visible=false;
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
				//	string opt;
				
					break;
				case 4:
					groupBox5.Visible=true;
					System.Text.StringBuilder s=new System.Text.StringBuilder ("");
					s.Append ("Audio File:" + txtInputAudioFile.Text  +"\r\n");
					s.Append ("O/P Audio File:" + txtOutputAudioFile.Text   +"\r\n");
					if(obj1.PropEmbedDataType =="File")
					{

						s.Append ("Embed File Name:" + obj1.PropKeyFileName   +"\r\n");
					}
					else
					{
						obj1.PropEmbedTextMessage =txtEmbedMessage.Text ;
						s.Append ("Embed Text Message :" + obj1.PropEmbedTextMessage  +"\r\n");
					}
					obj1.PropKeyFileName =txtKeyFile.Text ;
					s.Append ("Key File :" + obj1.PropKeyFileName  + "\r\n");
					txtVerify.Text =s.ToString ();
					break;
				case 5:
					groupBox6.Visible=true;
EmbedData();

					break;
				case 6:
					groupBox7.Visible=true;
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
				groupBox7.Visible=false;
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
			if(saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				txtOutputAudioFile.Text =saveFileDialog1.FileName;
				obj1.PropOutputAudioFile=txtOutputAudioFile.Text ;
			}
		}

		private void txtEmbedMessage_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		private void button6_Click(object sender, System.EventArgs e)
		{	openFileDialog1.Title ="Open Text File";
			openFileDialog1.Filter ="Text Files (*.txt) | *.txt";
			if(openFileDialog2.ShowDialog() ==DialogResult.OK)
			{
				obj1.PropEmbedTextFileName=openFileDialog2.FileName;			
				txtEmbedTextFile.Text=obj1.PropEmbedTextFileName;
			}
		}

		

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

		private void radioButton1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(radioButton1.Checked==true)
			{
				button6.Enabled =true;
				txtEmbedMessage.Enabled =false;
				obj1.PropEmbedDataType ="File";
				
			}
		}

		private void radioButton2_CheckedChanged(object sender, System.EventArgs e)
		{
				if(radioButton2.Checked==true)
				{
					 txtEmbedMessage.Enabled =true;
					button6.Enabled =false;
					obj1.PropEmbedDataType ="Text";
				}

		}
		public void EmbedData()
		{

			Stream sourceStream = null;
			FileStream destinationStream = null;
			WaveStream audioStream = null;
			
			//create a stream that contains the message, preceeded by its length
			Stream messageStream = GetMessageStream();
			//open the key file
			Stream keyStream = new FileStream(obj1.PropKeyFileName, FileMode.Open);

			textBox6.Text ="Key File Data gathered...";
			try 
			{
				
				//how man samples do we need?
				long countSamplesRequired = WaveUtility.CheckKeyForMessage(keyStream, messageStream.Length);
				textBox6.Text +="\r\n" +  countSamplesRequired.ToString () + " Samples Required..." ;
		//	Console.WriteLine (countSamplesRequired.ToString ());
				if(countSamplesRequired > Int32.MaxValue)
				{
					throw new Exception("Message too long, or bad key! This message/key combination requires "+countSamplesRequired+" samples, only "+Int32.MaxValue+" samples are allowed.");
				}

				
				//use a .wav file as the carrier
					sourceStream = new FileStream(obj1.PropAudioFileName , FileMode.Open);
				//this.Cursor = Cursors.WaitCursor;
				
				//create an empty file for the carrier wave
				destinationStream = new FileStream(obj1.PropOutputAudioFile , FileMode.Create);
				textBox6.Text +="\r\n" + "Output Audio File Created...";
				//copy the carrier file's header
				audioStream = new WaveStream(sourceStream, destinationStream);
				if (audioStream.Length <= 0)
				{
					throw new Exception("Invalid WAV file");
				}
				
				//are there enough samples in the carrier wave?
				if(countSamplesRequired > audioStream.CountSamples)
				{
					String errorReport = "The carrier file is too small for this message and key!\r\n"
						+ "Samples available: " + audioStream.CountSamples + "\r\n"			
						+ "Samples needed: " + countSamplesRequired;
					throw new Exception(errorReport);
				}

				//hide the message
				WaveUtility utility = new WaveUtility(audioStream, destinationStream);
				textBox6.Text +="\r\n" + "Start Hiding...";
				MessageBox.Show ("Starting...");
				utility.Hide(messageStream, keyStream);
				textBox6.Text +="\r\n" + "Finished Hiding...";
				
			}
			catch(Exception ex) 
			{
			//	this.Cursor = Cursors.Default;
				MessageBox.Show(ex.Message);
			}
			finally
			{
				if(keyStream != null){ keyStream.Close(); }
				if(messageStream != null){ messageStream.Close(); }
				if(audioStream != null){ audioStream.Close(); }
				if(sourceStream != null){ sourceStream.Close(); }
				if(destinationStream != null){ destinationStream.Close(); }
				this.Cursor = Cursors.Default;
			}


		}
		/// <summary>
		/// Extracting Data
		/// </summary>
		public void ExtractData()
		{
			/*
			this.Cursor = Cursors.WaitCursor;
			
			FileStream sourceStream = null;
			WaveStream audioStream = null;
			//create an empty stream to receive the extracted message
			MemoryStream messageStream = new MemoryStream();
			//open the key file
			Stream keyStream = new FileStream(txtKeyFile.Text, FileMode.Open);
			
			try 
			{
				//open the carrier file
				sourceStream = new FileStream(txtSrcFile.Text, FileMode.Open);
				audioStream = new WaveStream(sourceStream);
				WaveUtility utility = new WaveUtility(audioStream);
			
				//exctract the message from the carrier wave
				utility.Extract(messageStream, keyStream);
				
				messageStream.Seek(0, SeekOrigin.Begin);
				if(rdoMessageDstFile.Checked)
				{ //save result to a file
					FileStream fs = new FileStream(txtMessageDstFile.Text, FileMode.Create);
						
					byte[] buffer = new byte[messageStream.Length];
					messageStream.Read(buffer, 0, buffer.Length);
					fs.Write(buffer, 0, buffer.Length);
					fs.Close();
				}
				else
				{ //display result
					txtExtractedMessage.Text = new StreamReader(messageStream).ReadToEnd();					
				}
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
			}*/
		}

		
		/// <summary>Write length an content of the message file/text into a stream</summary>
		/// <returns></returns>
		private  Stream GetMessageStream()
		{
			BinaryWriter messageWriter = new BinaryWriter(new MemoryStream());
			if( obj1.PropEmbedDataType =="File")
			{
				FileStream fs = new FileStream(obj1.PropEmbedTextFileName, FileMode.Open);
				int fileLength = (int)fs.Length;
				messageWriter.Write(fileLength);
				Console.WriteLine (fileLength);
				byte[] buffer = new byte[fs.Length];
				fs.Read(buffer, 0, fileLength);
				messageWriter.Write(buffer);
				fs.Close();
				
				}
				else
			{
				messageWriter.Write(txtEmbedMessage.Text.Length);
Console.WriteLine (txtEmbedMessage.Text.Length);
				messageWriter.Write(Encoding.ASCII.GetBytes(txtEmbedMessage.Text));
			}
			
			messageWriter.Seek(0, SeekOrigin.Begin);
			return messageWriter.BaseStream;			
		}

		private void radioButton4_CheckedChanged(object sender, System.EventArgs e)
		{
			if (radioButton4.Checked ==true)
			WMP2.URL=txtOutputAudioFile.Text;		
		}

		private void radioButton3_CheckedChanged(object sender, System.EventArgs e)
		{
		if (radioButton3.Checked ==true)
			WMP2.URL =txtInputAudioFile.Text;	
		}

		private void WMP_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void listBox1_SelectedIndexChanged(object sender, System.EventArgs e)
		{
		
		}

		private void groupBox1_Enter(object sender, System.EventArgs e)
		{
		
		}

		private void txtInputAudioFile_TextChanged(object sender, System.EventArgs e)
		{
		
		}

		
	
	}
}
