using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace DHAF
{
	/// <summary>
	/// Summary description for frmWizard5.
	/// </summary>
	public class frmWizard5 : System.Windows.Forms.Form
	{
		private System.Windows.Forms.GroupBox groupBox1;
		//private AxMSFlexGridLib.AxMSFlexGrid axMSFlexGrid1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ListBox listBox1;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public frmWizard5()
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(frmWizard5));
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label1 = new System.Windows.Forms.Label();
			//this.axMSFlexGrid1 = new AxMSFlexGridLib.AxMSFlexGrid();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.groupBox1.SuspendLayout();
			//((System.ComponentModel.ISupportInitialize)(this.axMSFlexGrid1)).BeginInit();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label1);
			//this.groupBox1.Controls.Add(this.axMSFlexGrid1);
			this.groupBox1.Location = new System.Drawing.Point(184, 13);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(480, 300);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Step 5 of 7";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 248);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(400, 24);
			this.label1.TabIndex = 25;
			this.label1.Text = "Click Next to start the Embeded Process";
			// 
			// axMSFlexGrid1
			// 
            //this.axMSFlexGrid1.ContainingControl = this;
            //this.axMSFlexGrid1.Location = new System.Drawing.Point(16, 24);
            //this.axMSFlexGrid1.Name = "axMSFlexGrid1";
            //this.axMSFlexGrid1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axMSFlexGrid1.OcxState")));
            //this.axMSFlexGrid1.Size = new System.Drawing.Size(440, 208);
            //this.axMSFlexGrid1.TabIndex = 24;
			// 
			// listBox1
			// 
			this.listBox1.Location = new System.Drawing.Point(8, 16);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(176, 316);
			this.listBox1.TabIndex = 2;
			// 
			// frmWizard5
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(664, 342);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.groupBox1);
			this.Name = "frmWizard5";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Step 5 of 7";
			this.groupBox1.ResumeLayout(false);
			//((System.ComponentModel.ISupportInitialize)(this.axMSFlexGrid1)).EndInit();
			this.ResumeLayout(false);

		}
		#endregion

		private void button4_Click(object sender, System.EventArgs e)
		{
			this.Close();
			frmWizard6 step6 = new frmWizard6();
			step6.Show();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			this.Close();
			frmWizard4 step4 = new frmWizard4();
			step4.Show();
		}

		private void button5_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}
	}
}
