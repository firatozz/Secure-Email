namespace Güvenli_E_Mail_Uygulaması
{
    partial class sessteg2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.seskayitbtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.oncekibtn = new System.Windows.Forms.Button();
            this.sonrakibtn = new System.Windows.Forms.Button();
            this.iptalbtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.seskayitbtn);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(217, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(554, 303);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adım 2";
            // 
            // seskayitbtn
            // 
            this.seskayitbtn.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seskayitbtn.Location = new System.Drawing.Point(356, 261);
            this.seskayitbtn.Name = "seskayitbtn";
            this.seskayitbtn.Size = new System.Drawing.Size(192, 34);
            this.seskayitbtn.TabIndex = 2;
            this.seskayitbtn.Text = "Çıkış Kayıt Yeri Seçiniz";
            this.seskayitbtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(8, 264);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(342, 30);
            this.textBox1.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 23;
            this.listBox1.Location = new System.Drawing.Point(12, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(199, 303);
            this.listBox1.TabIndex = 5;
            // 
            // oncekibtn
            // 
            this.oncekibtn.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oncekibtn.Location = new System.Drawing.Point(490, 342);
            this.oncekibtn.Name = "oncekibtn";
            this.oncekibtn.Size = new System.Drawing.Size(87, 30);
            this.oncekibtn.TabIndex = 9;
            this.oncekibtn.Text = "Önceki";
            this.oncekibtn.UseVisualStyleBackColor = true;
            // 
            // sonrakibtn
            // 
            this.sonrakibtn.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sonrakibtn.Location = new System.Drawing.Point(583, 342);
            this.sonrakibtn.Name = "sonrakibtn";
            this.sonrakibtn.Size = new System.Drawing.Size(87, 30);
            this.sonrakibtn.TabIndex = 8;
            this.sonrakibtn.Text = "Sonraki";
            this.sonrakibtn.UseVisualStyleBackColor = true;
            // 
            // iptalbtn
            // 
            this.iptalbtn.Font = new System.Drawing.Font("Minion Pro", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iptalbtn.Location = new System.Drawing.Point(678, 342);
            this.iptalbtn.Name = "iptalbtn";
            this.iptalbtn.Size = new System.Drawing.Size(87, 30);
            this.iptalbtn.TabIndex = 7;
            this.iptalbtn.Text = "İptal";
            this.iptalbtn.UseVisualStyleBackColor = true;
            // 
            // sessteg2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 384);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.oncekibtn);
            this.Controls.Add(this.sonrakibtn);
            this.Controls.Add(this.iptalbtn);
            this.Name = "sessteg2";
            this.Text = "Ses Steganografi 2. Adım";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button seskayitbtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button oncekibtn;
        private System.Windows.Forms.Button sonrakibtn;
        private System.Windows.Forms.Button iptalbtn;
    }
}