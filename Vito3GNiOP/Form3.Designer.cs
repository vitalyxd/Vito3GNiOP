namespace Vito3GNiOP
{
    partial class Form3
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
            this.Ro = new System.Windows.Forms.TextBox();
            this.Duljina = new System.Windows.Forms.TextBox();
            this.PovrsinaPoprecnogPresjeka = new System.Windows.Forms.TextBox();
            this.Izracun = new System.Windows.Forms.Button();
            this.Povratak = new System.Windows.Forms.Button();
            this.Otpor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Ro
            // 
            this.Ro.Location = new System.Drawing.Point(189, 151);
            this.Ro.Name = "Ro";
            this.Ro.Size = new System.Drawing.Size(100, 20);
            this.Ro.TabIndex = 1;
            this.Ro.TextChanged += new System.EventHandler(this.Ro_TextChanged);
            // 
            // Duljina
            // 
            this.Duljina.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Duljina.Location = new System.Drawing.Point(340, 151);
            this.Duljina.Name = "Duljina";
            this.Duljina.Size = new System.Drawing.Size(100, 20);
            this.Duljina.TabIndex = 2;
            // 
            // PovrsinaPoprecnogPresjeka
            // 
            this.PovrsinaPoprecnogPresjeka.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.PovrsinaPoprecnogPresjeka.Location = new System.Drawing.Point(497, 151);
            this.PovrsinaPoprecnogPresjeka.Name = "PovrsinaPoprecnogPresjeka";
            this.PovrsinaPoprecnogPresjeka.Size = new System.Drawing.Size(100, 20);
            this.PovrsinaPoprecnogPresjeka.TabIndex = 3;
            // 
            // Izracun
            // 
            this.Izracun.Location = new System.Drawing.Point(340, 211);
            this.Izracun.Name = "Izracun";
            this.Izracun.Size = new System.Drawing.Size(100, 23);
            this.Izracun.TabIndex = 4;
            this.Izracun.Text = "Izracun";
            this.Izracun.UseVisualStyleBackColor = true;
            this.Izracun.Click += new System.EventHandler(this.Izracun_Click);
            // 
            // Povratak
            // 
            this.Povratak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Povratak.Location = new System.Drawing.Point(340, 375);
            this.Povratak.Name = "Povratak";
            this.Povratak.Size = new System.Drawing.Size(100, 23);
            this.Povratak.TabIndex = 5;
            this.Povratak.Text = "Povratak";
            this.Povratak.UseVisualStyleBackColor = true;
            this.Povratak.Click += new System.EventHandler(this.Povratak_Click);
            // 
            // Otpor
            // 
            this.Otpor.AutoSize = true;
            this.Otpor.Location = new System.Drawing.Point(337, 294);
            this.Otpor.Name = "Otpor";
            this.Otpor.Size = new System.Drawing.Size(0, 13);
            this.Otpor.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(212, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Otpornost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(373, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Duljina";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(476, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "Povrsina poprecnog presjeka";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Otpor);
            this.Controls.Add(this.Povratak);
            this.Controls.Add(this.Izracun);
            this.Controls.Add(this.PovrsinaPoprecnogPresjeka);
            this.Controls.Add(this.Duljina);
            this.Controls.Add(this.Ro);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Ro;
        private System.Windows.Forms.TextBox Duljina;
        private System.Windows.Forms.TextBox PovrsinaPoprecnogPresjeka;
        private System.Windows.Forms.Button Izracun;
        private System.Windows.Forms.Button Povratak;
        private System.Windows.Forms.Label Otpor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}