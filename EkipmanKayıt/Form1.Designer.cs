namespace EkipmanKayıt
{
    partial class İlkfrm
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
            this.btnServisSüreç = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnServisSüreç
            // 
            this.btnServisSüreç.Location = new System.Drawing.Point(312, 302);
            this.btnServisSüreç.Name = "btnServisSüreç";
            this.btnServisSüreç.Size = new System.Drawing.Size(120, 37);
            this.btnServisSüreç.TabIndex = 0;
            this.btnServisSüreç.Text = "Sarf MAlzeme Servis";
            this.btnServisSüreç.UseVisualStyleBackColor = true;
            this.btnServisSüreç.Click += new System.EventHandler(this.btnServisSüreç_Click);
            // 
            // İlkfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 446);
            this.Controls.Add(this.btnServisSüreç);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "İlkfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                      EKİPMAN KAYIT";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnServisSüreç;
    }
}

