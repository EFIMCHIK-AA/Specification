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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(5, 67);
            this.Name_L.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Name_L.Name = "Name_L";
            this.Name_L.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Name_L.Size = new System.Drawing.Size(93, 18);
            this.Name_L.TabIndex = 1;
            this.Name_L.Text = "Наименование";
            // 
            // Description_L
            // 
            this.Description_L.AutoSize = true;
            this.Description_L.Location = new System.Drawing.Point(5, 97);
            this.Description_L.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Description_L.Name = "Description_L";
            this.Description_L.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Description_L.Size = new System.Drawing.Size(67, 18);
            this.Description_L.TabIndex = 3;
            this.Description_L.Text = "Описание";
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Name_TB.Location = new System.Drawing.Point(240, 67);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(227, 20);
            this.Name_TB.TabIndex = 2;
            this.Name_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Description_TB
            // 
            this.Description_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Description_TB.Location = new System.Drawing.Point(240, 97);
            this.Description_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.Size = new System.Drawing.Size(227, 20);
            this.Description_TB.TabIndex = 4;
            this.Description_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OK_B
            // 
            this.OK_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Location = new System.Drawing.Point(5, 124);
            this.OK_B.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.OK_B.Name = "OK_B";
            this.OK_B.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.OK_B.Size = new System.Drawing.Size(199, 33);
            this.OK_B.TabIndex = 3;
            this.OK_B.Text = "&Сохранить";
            this.OK_B.UseVisualStyleBackColor = false;
            // 
            // Cancel_B
            // 
            this.Cancel_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Location = new System.Drawing.Point(240, 124);
            this.Cancel_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Cancel_B.Size = new System.Drawing.Size(204, 33);
            this.Cancel_B.TabIndex = 4;
            this.Cancel_B.Text = "&Отмена";
            this.Cancel_B.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.label5, 2);
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(454, 35);
            this.label5.TabIndex = 0;
            this.label5.Text = "Список элементов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Description_TB, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Name_TB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.OK_B, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Name_L, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cancel_B, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Description_L, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 68.42105F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.57895F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(480, 162);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ModificationModel
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(516, 200);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ModificationModel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавлене";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ModificationModel_FormClosing);
            this.Load += new System.EventHandler(this.ModificationModel_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.Label Description_L;
        private System.Windows.Forms.Button OK_B;
        public System.Windows.Forms.TextBox Name_TB;
        public System.Windows.Forms.TextBox Description_TB;
        private System.Windows.Forms.Button Cancel_B;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}