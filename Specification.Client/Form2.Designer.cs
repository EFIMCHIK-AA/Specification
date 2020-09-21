namespace Specification.Client
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
            this.Name_L = new System.Windows.Forms.Label();
            this.Description_L = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Description_TB = new System.Windows.Forms.TextBox();
            this.OK_B = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(48, 77);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(35, 13);
            this.Name_L.TabIndex = 16;
            this.Name_L.Text = "Name";
            // 
            // Description_L
            // 
            this.Description_L.AutoSize = true;
            this.Description_L.Location = new System.Drawing.Point(48, 109);
            this.Description_L.Name = "Description_L";
            this.Description_L.Size = new System.Drawing.Size(60, 13);
            this.Description_L.TabIndex = 15;
            this.Description_L.Text = "Description";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(116, 74);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(155, 20);
            this.Name_TB.TabIndex = 14;
            // 
            // Description_TB
            // 
            this.Description_TB.Location = new System.Drawing.Point(116, 106);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.Size = new System.Drawing.Size(155, 20);
            this.Description_TB.TabIndex = 13;
            // 
            // OK_B
            // 
            this.OK_B.Location = new System.Drawing.Point(149, 153);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(75, 23);
            this.OK_B.TabIndex = 17;
            this.OK_B.Text = "Применить";
            this.OK_B.UseVisualStyleBackColor = true;
            this.OK_B.Click += new System.EventHandler(this.OK_B_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 202);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.Name_L);
            this.Controls.Add(this.Description_L);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Description_TB);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.Label Description_L;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox Description_TB;
        private System.Windows.Forms.Button OK_B;
    }
}