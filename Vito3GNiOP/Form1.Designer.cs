namespace Vito3GNiOP
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
            this.SilaTrenja = new System.Windows.Forms.Button();
            this.ElektricnaOtpornost = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SilaTrenja
            // 
            this.SilaTrenja.Location = new System.Drawing.Point(77, 101);
            this.SilaTrenja.Name = "SilaTrenja";
            this.SilaTrenja.Size = new System.Drawing.Size(75, 23);
            this.SilaTrenja.TabIndex = 0;
            this.SilaTrenja.Text = "Sila trenja";
            this.SilaTrenja.UseVisualStyleBackColor = true;
            this.SilaTrenja.Click += new System.EventHandler(this.button1_Click);
            // 
            // ElektricnaOtpornost
            // 
            this.ElektricnaOtpornost.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ElektricnaOtpornost.Location = new System.Drawing.Point(77, 188);
            this.ElektricnaOtpornost.Name = "ElektricnaOtpornost";
            this.ElektricnaOtpornost.Size = new System.Drawing.Size(75, 42);
            this.ElektricnaOtpornost.TabIndex = 1;
            this.ElektricnaOtpornost.Text = "Elektricna otpornost";
            this.ElektricnaOtpornost.UseVisualStyleBackColor = true;
            this.ElektricnaOtpornost.Click += new System.EventHandler(this.ElektricnaOtpornost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 405);
            this.Controls.Add(this.ElektricnaOtpornost);
            this.Controls.Add(this.SilaTrenja);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SilaTrenja;
        private System.Windows.Forms.Button ElektricnaOtpornost;
    }
}

