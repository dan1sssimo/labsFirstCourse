
namespace zadani2
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
            this.button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb1 = new System.Windows.Forms.TextBox();
            this.tb2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rezz = new System.Windows.Forms.Label();
            this.rb1 = new System.Windows.Forms.RadioButton();
            this.rb2 = new System.Windows.Forms.RadioButton();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button
            // 
            this.button.BackColor = System.Drawing.Color.Orange;
            this.button.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.button.Location = new System.Drawing.Point(330, 266);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(159, 50);
            this.button.TabIndex = 0;
            this.button.Text = "Розрахувати";
            this.button.UseVisualStyleBackColor = false;
            this.button.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(25, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ширина( см ):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(25, 138);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Висота( см ):";
            // 
            // tb1
            // 
            this.tb1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb1.Location = new System.Drawing.Point(155, 90);
            this.tb1.Name = "tb1";
            this.tb1.Size = new System.Drawing.Size(100, 31);
            this.tb1.TabIndex = 3;
            // 
            // tb2
            // 
            this.tb2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tb2.Location = new System.Drawing.Point(155, 132);
            this.tb2.Name = "tb2";
            this.tb2.Size = new System.Drawing.Size(100, 31);
            this.tb2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Матеріал:";
            // 
            // cb1
            // 
            this.cb1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cb1.FormattingEnabled = true;
            this.cb1.Items.AddRange(new object[] {
            "Дерево",
            "Метал",
            "Металопластик"});
            this.cb1.Location = new System.Drawing.Point(155, 194);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(121, 31);
            this.cb1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(28, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Вартість: ";
            // 
            // rezz
            // 
            this.rezz.AutoSize = true;
            this.rezz.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rezz.ForeColor = System.Drawing.Color.Red;
            this.rezz.Location = new System.Drawing.Point(155, 280);
            this.rezz.Name = "rezz";
            this.rezz.Size = new System.Drawing.Size(0, 25);
            this.rezz.TabIndex = 8;
            // 
            // rb1
            // 
            this.rb1.AutoSize = true;
            this.rb1.Checked = true;
            this.rb1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb1.Location = new System.Drawing.Point(333, 90);
            this.rb1.Name = "rb1";
            this.rb1.Size = new System.Drawing.Size(156, 29);
            this.rb1.TabIndex = 9;
            this.rb1.TabStop = true;
            this.rb1.Text = "Однокамерний";
            this.rb1.UseVisualStyleBackColor = true;
            // 
            // rb2
            // 
            this.rb2.AutoSize = true;
            this.rb2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rb2.Location = new System.Drawing.Point(333, 125);
            this.rb2.Name = "rb2";
            this.rb2.Size = new System.Drawing.Size(144, 29);
            this.rb2.TabIndex = 10;
            this.rb2.Text = "Двокамерний";
            this.rb2.UseVisualStyleBackColor = true;
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.check1.Location = new System.Drawing.Point(352, 180);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(121, 29);
            this.check1.TabIndex = 11;
            this.check1.Text = "Підвіконня";
            this.check1.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Yellow;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(55, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(457, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Розробив студент групи ІПЗ-20-4(2) Савченко Данило";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(524, 451);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.rb2);
            this.Controls.Add(this.rb1);
            this.Controls.Add(this.rezz);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cb1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb2);
            this.Controls.Add(this.tb1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button);
            this.MaximumSize = new System.Drawing.Size(540, 490);
            this.MinimumSize = new System.Drawing.Size(540, 490);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Склопакет";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb1;
        private System.Windows.Forms.TextBox tb2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label rezz;
        private System.Windows.Forms.RadioButton rb1;
        private System.Windows.Forms.RadioButton rb2;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.Label label5;
    }
}

