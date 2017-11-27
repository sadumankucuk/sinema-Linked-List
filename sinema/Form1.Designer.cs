namespace sinema
{
    partial class Form1
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
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblKoltukNo = new System.Windows.Forms.Label();
            this.nmKoltukNo = new System.Windows.Forms.NumericUpDown();
            this.btnBiletAl = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnDolu = new System.Windows.Forms.Button();
            this.btnBos = new System.Windows.Forms.Button();
            this.btnOgren = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nmKoltukNo)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(9, 35);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(59, 14);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad Soyad:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(74, 31);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(136, 22);
            this.txtAd.TabIndex = 1;
            // 
            // lblKoltukNo
            // 
            this.lblKoltukNo.AutoSize = true;
            this.lblKoltukNo.Location = new System.Drawing.Point(9, 64);
            this.lblKoltukNo.Name = "lblKoltukNo";
            this.lblKoltukNo.Size = new System.Drawing.Size(100, 14);
            this.lblKoltukNo.TabIndex = 4;
            this.lblKoltukNo.Text = "Koltuk Numarası:";
            // 
            // nmKoltukNo
            // 
            this.nmKoltukNo.Location = new System.Drawing.Point(155, 59);
            this.nmKoltukNo.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nmKoltukNo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nmKoltukNo.Name = "nmKoltukNo";
            this.nmKoltukNo.Size = new System.Drawing.Size(55, 22);
            this.nmKoltukNo.TabIndex = 5;
            this.nmKoltukNo.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnBiletAl
            // 
            this.btnBiletAl.Location = new System.Drawing.Point(225, 60);
            this.btnBiletAl.Name = "btnBiletAl";
            this.btnBiletAl.Size = new System.Drawing.Size(87, 24);
            this.btnBiletAl.TabIndex = 6;
            this.btnBiletAl.Text = "Bilet Al";
            this.btnBiletAl.UseVisualStyleBackColor = true;
            this.btnBiletAl.Click += new System.EventHandler(this.btnBiletAl_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(226, 93);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(87, 24);
            this.btnIptal.TabIndex = 7;
            this.btnIptal.Text = "Bilet İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnDolu
            // 
            this.btnDolu.Location = new System.Drawing.Point(2, 140);
            this.btnDolu.Name = "btnDolu";
            this.btnDolu.Size = new System.Drawing.Size(152, 23);
            this.btnDolu.TabIndex = 8;
            this.btnDolu.Text = "Dolu Koltukları Göster";
            this.btnDolu.UseVisualStyleBackColor = true;
            this.btnDolu.Click += new System.EventHandler(this.btnDolu_Click);
            // 
            // btnBos
            // 
            this.btnBos.Location = new System.Drawing.Point(167, 140);
            this.btnBos.Name = "btnBos";
            this.btnBos.Size = new System.Drawing.Size(152, 23);
            this.btnBos.TabIndex = 9;
            this.btnBos.Text = "Boş Koltukları Göster";
            this.btnBos.UseVisualStyleBackColor = true;
            this.btnBos.Click += new System.EventHandler(this.btnBos_Click);
            // 
            // btnOgren
            // 
            this.btnOgren.Location = new System.Drawing.Point(216, 31);
            this.btnOgren.Name = "btnOgren";
            this.btnOgren.Size = new System.Drawing.Size(110, 23);
            this.btnOgren.TabIndex = 10;
            this.btnOgren.Text = "Koltuk No Öğren";
            this.btnOgren.UseVisualStyleBackColor = true;
            this.btnOgren.Click += new System.EventHandler(this.btnOgren_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(331, 172);
            this.Controls.Add(this.btnOgren);
            this.Controls.Add(this.btnBos);
            this.Controls.Add(this.btnDolu);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.btnBiletAl);
            this.Controls.Add(this.nmKoltukNo);
            this.Controls.Add(this.lblKoltukNo);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Font = new System.Drawing.Font("Garamond", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Form1";
            this.Text = "Bollywood";
            ((System.ComponentModel.ISupportInitialize)(this.nmKoltukNo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblKoltukNo;
        private System.Windows.Forms.NumericUpDown nmKoltukNo;
        private System.Windows.Forms.Button btnBiletAl;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnDolu;
        private System.Windows.Forms.Button btnBos;
        private System.Windows.Forms.Button btnOgren;
    }
}

