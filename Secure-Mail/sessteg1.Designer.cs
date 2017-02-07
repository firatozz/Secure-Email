namespace Güvenli_E_Mail_Uygulaması
{
    partial class sessteg1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(sessteg1));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.sessecbtn = new System.Windows.Forms.Button();
            this.sesicalbtn = new System.Windows.Forms.Button();
            this.iptalbtn = new System.Windows.Forms.Button();
            this.sonrakibtn = new System.Windows.Forms.Button();
            this.oncekibtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(264, 303);
            this.listBox1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sesicalbtn);
            this.groupBox1.Controls.Add(this.sessecbtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.axWindowsMediaPlayer1);
            this.groupBox1.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(282, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 303);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adım 1";
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(6, 21);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(548, 176);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 264);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 30);
            this.textBox1.TabIndex = 1;
            // 
            // sessecbtn
            // 
            this.sessecbtn.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sessecbtn.Location = new System.Drawing.Point(356, 261);
            this.sessecbtn.Name = "sessecbtn";
            this.sessecbtn.Size = new System.Drawing.Size(192, 34);
            this.sessecbtn.TabIndex = 2;
            this.sessecbtn.Text = "Ses Dosyasını Seçiniz";
            this.sessecbtn.UseVisualStyleBackColor = true;
            // 
            // sesicalbtn
            // 
            this.sesicalbtn.Location = new System.Drawing.Point(8, 203);
            this.sesicalbtn.Name = "sesicalbtn";
            this.sesicalbtn.Size = new System.Drawing.Size(540, 41);
            this.sesicalbtn.TabIndex = 3;
            this.sesicalbtn.Text = "Sesi Çal";
            this.sesicalbtn.UseVisualStyleBackColor = true;
            // 
            // iptalbtn
            // 
            this.iptalbtn.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptalbtn.Location = new System.Drawing.Point(743, 342);
            this.iptalbtn.Name = "iptalbtn";
            this.iptalbtn.Size = new System.Drawing.Size(87, 30);
            this.iptalbtn.TabIndex = 2;
            this.iptalbtn.Text = "İptal";
            this.iptalbtn.UseVisualStyleBackColor = true;
            // 
            // sonrakibtn
            // 
            this.sonrakibtn.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonrakibtn.Location = new System.Drawing.Point(648, 342);
            this.sonrakibtn.Name = "sonrakibtn";
            this.sonrakibtn.Size = new System.Drawing.Size(87, 30);
            this.sonrakibtn.TabIndex = 3;
            this.sonrakibtn.Text = "Sonraki";
            this.sonrakibtn.UseVisualStyleBackColor = true;
            // 
            // oncekibtn
            // 
            this.oncekibtn.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oncekibtn.Location = new System.Drawing.Point(555, 342);
            this.oncekibtn.Name = "oncekibtn";
            this.oncekibtn.Size = new System.Drawing.Size(87, 30);
            this.oncekibtn.TabIndex = 4;
            this.oncekibtn.Text = "Önceki";
            this.oncekibtn.UseVisualStyleBackColor = true;
            // 
            // sessteg1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 382);
            this.Controls.Add(this.oncekibtn);
            this.Controls.Add(this.sonrakibtn);
            this.Controls.Add(this.iptalbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Name = "sessteg1";
            this.Text = "Ses Steganografi 1. Adım";
            this.Load += new System.EventHandler(this.sessteg1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button sessecbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button sesicalbtn;
        private System.Windows.Forms.Button iptalbtn;
        private System.Windows.Forms.Button sonrakibtn;
        private System.Windows.Forms.Button oncekibtn;
    }
}