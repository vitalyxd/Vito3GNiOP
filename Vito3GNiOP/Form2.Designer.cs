namespace Vito3GNiOP
{
    partial class Form2
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
            this.FaktorTrenja = new System.Windows.Forms.TextBox();
            this.NormalnaSilaFN = new System.Windows.Forms.TextBox();
            this.Izracun = new System.Windows.Forms.Button();
            this.Povratak = new System.Windows.Forms.Button();
            this.SilaTrenjaFT = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // FaktorTrenja
            // 
            this.FaktorTrenja.Location = new System.Drawing.Point(144, 132);
            this.FaktorTrenja.Name = "FaktorTrenja";
            this.FaktorTrenja.Size = new System.Drawing.Size(100, 20);
            this.FaktorTrenja.TabIndex = 1;
            // 
            // NormalnaSilaFN
            // 
            this.NormalnaSilaFN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NormalnaSilaFN.Location = new System.Drawing.Point(352, 132);
            this.NormalnaSilaFN.Name = "NormalnaSilaFN";
            this.NormalnaSilaFN.Size = new System.Drawing.Size(100, 20);
            this.NormalnaSilaFN.TabIndex = 2;
            // 
            // Izracun
            // 
            this.Izracun.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Izracun.Location = new System.Drawing.Point(250, 196);
            this.Izracun.Name = "Izracun";
            this.Izracun.Size = new System.Drawing.Size(100, 23);
            this.Izracun.TabIndex = 3;
            this.Izracun.Text = "Izracun";
            this.Izracun.UseVisualStyleBackColor = true;
            this.Izracun.Click += new System.EventHandler(this.Izracun_Click);
            // 
            // Povratak
            // 
            this.Povratak.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Povratak.Location = new System.Drawing.Point(262, 356);
            this.Povratak.Name = "Povratak";
            this.Povratak.Size = new System.Drawing.Size(75, 23);
            this.Povratak.TabIndex = 4;
            this.Povratak.Text = "Povratak";
            this.Povratak.UseVisualStyleBackColor = true;
            this.Povratak.Click += new System.EventHandler(this.Povratak_Click);
            // 
            // SilaTrenjaFT
            // 
            this.SilaTrenjaFT.AutoSize = true;
            this.SilaTrenjaFT.Location = new System.Drawing.Point(244, 290);
            this.SilaTrenjaFT.Name = "SilaTrenjaFT";
            this.SilaTrenjaFT.Size = new System.Drawing.Size(0, 13);
            this.SilaTrenjaFT.TabIndex = 5;
            this.SilaTrenjaFT.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Faktor trenja";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(392, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sila";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 417);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SilaTrenjaFT);
            this.Controls.Add(this.Povratak);
            this.Controls.Add(this.Izracun);
            this.Controls.Add(this.NormalnaSilaFN);
            this.Controls.Add(this.FaktorTrenja);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox FaktorTrenja;
        private System.Windows.Forms.TextBox NormalnaSilaFN;
        private System.Windows.Forms.Button Izracun;
        private System.Windows.Forms.Button Povratak;
        private System.Windows.Forms.Label SilaTrenjaFT;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}