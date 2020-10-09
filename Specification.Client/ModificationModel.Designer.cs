namespace Specification.Client
{
    partial class ModificationModel
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
            this.Cancel_B = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(113, 78);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(83, 13);
            this.Name_L.TabIndex = 16;
            this.Name_L.Text = "Наименование";
            // 
            // Description_L
            // 
            this.Description_L.AutoSize = true;
            this.Description_L.Location = new System.Drawing.Point(113, 101);
            this.Description_L.Name = "Description_L";
            this.Description_L.Size = new System.Drawing.Size(57, 13);
            this.Description_L.TabIndex = 15;
            this.Description_L.Text = "Описание";
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(202, 75);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(240, 20);
            this.Name_TB.TabIndex = 1;
            // 
            // Description_TB
            // 
            this.Description_TB.Location = new System.Drawing.Point(202, 101);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.Size = new System.Drawing.Size(240, 20);
            this.Description_TB.TabIndex = 2;
            // 
            // OK_B
            // 
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Location = new System.Drawing.Point(116, 145);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(160, 23);
            this.OK_B.TabIndex = 3;
            this.OK_B.Text = "&Сохранить";
            this.OK_B.UseVisualStyleBackColor = true;
            // 
            // Cancel_B
            // 
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(282, 145);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(160, 23);
            this.Cancel_B.TabIndex = 4;
            this.Cancel_B.Text = "&Отмена";
            this.Cancel_B.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(7);
            this.label5.Size = new System.Drawing.Size(543, 36);
            this.label5.TabIndex = 17;
            this.label5.Text = "Список элементов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ModificationModel
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(603, 306);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Cancel_B);
            this.Controls.Add(this.OK_B);
            this.Controls.Add(this.Name_L);
            this.Controls.Add(this.Description_L);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Description_TB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificationModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавлене";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificationModel_FormClosing);
            this.Load += new System.EventHandler(this.ModificationModel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.Label Description_L;
        private System.Windows.Forms.Button OK_B;
        public System.Windows.Forms.TextBox Name_TB;
        public System.Windows.Forms.TextBox Description_TB;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Label label5;
    }
}