
namespace WinFormsApp1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.droW = new System.Windows.Forms.Button();
            this.stertu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pb1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            this.SuspendLayout();
            // 
            // droW
            // 
            this.droW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.droW.Location = new System.Drawing.Point(12, 569);
            this.droW.Name = "droW";
            this.droW.Size = new System.Drawing.Size(142, 36);
            this.droW.TabIndex = 0;
            this.droW.Text = "Промалювати";
            this.droW.UseVisualStyleBackColor = true;
            this.droW.Click += new System.EventHandler(this.droW_Click);
            // 
            // stertu
            // 
            this.stertu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.stertu.Location = new System.Drawing.Point(160, 569);
            this.stertu.Name = "stertu";
            this.stertu.Size = new System.Drawing.Size(142, 36);
            this.stertu.TabIndex = 1;
            this.stertu.Text = "Стерти";
            this.stertu.UseVisualStyleBackColor = true;
            this.stertu.Click += new System.EventHandler(this.stertu_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(811, 578);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Савченко Д.П";
            // 
            // pb1
            // 
            this.pb1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pb1.Location = new System.Drawing.Point(12, 12);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(936, 551);
            this.pb1.TabIndex = 3;
            this.pb1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(960, 608);
            this.Controls.Add(this.pb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.stertu);
            this.Controls.Add(this.droW);
            this.Font = new System.Drawing.Font("Arial", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MaximumSize = new System.Drawing.Size(976, 647);
            this.MinimumSize = new System.Drawing.Size(976, 647);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Лабораторна робота №8. Завдання №2.";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button droW;
        private System.Windows.Forms.Button stertu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb1;
    }
}

