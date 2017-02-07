using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DHAF
{
	/// <summary>
	/// Summary description for frmWizard3.
	/// </summary>
	public class frmWizard3 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.ListBox listBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWizard3()
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
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.textBox1);
			this.groupBox1.Controls.Add(this.radioButton2);
			this.groupBox1.Controls.Add(this.radioButton1);
			this.groupBox1.Location = new System.Drawing.Point(184, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(472, 320);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Step 3 of 7";
			// 
			// textBox1
			// 
			this.textBox1.AutoSize = false;
			this.textBox1.Location = new System.Drawing.Point(24, 72);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(432, 192);
			this.textBox1.TabIndex = 3;
			this.textBox1.Text = "textBox1";
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(248, 32);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.TabIndex = 2;
			this.radioButton2.Text = "Enter Text";
			// 
			// radioButton1
			// 
			this.radioButton1.Location = new System.Drawing.Point(112, 32);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.TabIndex = 1;
			this.radioButton1.Text = "Select File";
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(8, 16);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(176, 316);
			this.listBox1.TabIndex = 2;
			// 
			// frmWizard3
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(664, 342);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmWizard3";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Step 3 of 7";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.Close();
			frmWizard4 step4 = new frmWizard4();
			step4.Show();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
			frmWizard2 step2 = new frmWizard2();
			step2.Show();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
