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
            this.Header_L = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_L.Location = new System.Drawing.Point(4, 45);
            this.Name_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(86, 20);
            this.Name_L.TabIndex = 1;
            this.Name_L.Text = "Наименование";
            // 
            // Description_L
            // 
            this.Description_L.AutoSize = true;
            this.Description_L.Location = new System.Drawing.Point(4, 69);
            this.Description_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 4);
            this.Description_L.Name = "Description_L";
            this.Description_L.Size = new System.Drawing.Size(57, 13);
            this.Description_L.TabIndex = 3;
            this.Description_L.Text = "Описание";
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Name_TB, 2);
            this.Name_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_TB.Location = new System.Drawing.Point(94, 45);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(246, 20);
            this.Name_TB.TabIndex = 2;
            this.Name_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Description_TB
            // 
            this.Description_TB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel1.SetColumnSpan(this.Description_TB, 2);
            this.Description_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_TB.Location = new System.Drawing.Point(94, 69);
            this.Description_TB.Margin = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.Size = new System.Drawing.Size(246, 20);
            this.Description_TB.TabIndex = 4;
            this.Description_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OK_B
            // 
            this.OK_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.OK_B.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OK_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OK_B.Location = new System.Drawing.Point(4, 119);
            this.OK_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.OK_B.Name = "OK_B";
            this.OK_B.Size = new System.Drawing.Size(86, 28);
            this.OK_B.TabIndex = 5;
            this.OK_B.Text = "&Сохранить";
            this.OK_B.UseVisualStyleBackColor = false;
            // 
            // Cancel_B
            // 
            this.Cancel_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Cancel_B.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cancel_B.Location = new System.Drawing.Point(254, 119);
            this.Cancel_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Cancel_B.Name = "Cancel_B";
            this.Cancel_B.Size = new System.Drawing.Size(86, 28);
            this.Cancel_B.TabIndex = 6;
            this.Cancel_B.Text = "&Отмена";
            this.Cancel_B.UseVisualStyleBackColor = false;
            // 
            // Header_L
            // 
            this.Header_L.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Header_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel1.SetColumnSpan(this.Header_L, 3);
            this.Header_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Header_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Header_L.Location = new System.Drawing.Point(4, 4);
            this.Header_L.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Header_L.Name = "Header_L";
            this.Header_L.Size = new System.Drawing.Size(336, 37);
            this.Header_L.TabIndex = 0;
            this.Header_L.Text = "Список элементов";
            this.Header_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 94F));
            this.tableLayoutPanel1.Controls.Add(this.Header_L, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Name_L, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Description_L, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.OK_B, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Cancel_B, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.Name_TB, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Description_TB, 1, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(344, 151);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // ModificationModel
            // 
            this.AcceptButton = this.OK_B;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.CancelButton = this.Cancel_B;
            this.ClientSize = new System.Drawing.Size(344, 151);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(360, 190);
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
        private System.Windows.Forms.Label Header_L;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}