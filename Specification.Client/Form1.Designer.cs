namespace Specification.Client
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Description_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Description_L = new System.Windows.Forms.Label();
            this.Name_L = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.ID,
            this.Imya,
            this.Description});
            this.dataGridView1.Location = new System.Drawing.Point(16, 38);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(707, 343);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 120;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Imya
            // 
            this.Imya.HeaderText = "Name";
            this.Imya.MinimumWidth = 6;
            this.Imya.Name = "Imya";
            this.Imya.Width = 130;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 150;
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(36, 417);
            this.Add_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(183, 55);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "Add";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Update_B
            // 
            this.Update_B.Location = new System.Drawing.Point(275, 417);
            this.Update_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(183, 55);
            this.Update_B.TabIndex = 3;
            this.Update_B.Text = "Update";
            this.Update_B.UseVisualStyleBackColor = true;
            // 
            // Delete_B
            // 
            this.Delete_B.Location = new System.Drawing.Point(511, 417);
            this.Delete_B.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(183, 55);
            this.Delete_B.TabIndex = 4;
            this.Delete_B.Text = "Delete";
            this.Delete_B.UseVisualStyleBackColor = true;
            // 
            // Description_TB
            // 
            this.Description_TB.Location = new System.Drawing.Point(844, 233);
            this.Description_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.Size = new System.Drawing.Size(205, 22);
            this.Description_TB.TabIndex = 6;
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(844, 193);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(205, 22);
            this.Name_TB.TabIndex = 8;
            // 
            // Description_L
            // 
            this.Description_L.AutoSize = true;
            this.Description_L.Location = new System.Drawing.Point(753, 236);
            this.Description_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Description_L.Name = "Description_L";
            this.Description_L.Size = new System.Drawing.Size(79, 17);
            this.Description_L.TabIndex = 10;
            this.Description_L.Text = "Description";
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(753, 197);
            this.Name_L.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(45, 17);
            this.Name_L.TabIndex = 12;
            this.Name_L.Text = "Name";
            // 
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1089, 494);
            this.Controls.Add(this.Name_L);
            this.Controls.Add(this.Description_L);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Description_TB);
            this.Controls.Add(this.Delete_B);
            this.Controls.Add(this.Update_B);
            this.Controls.Add(this.Add_B);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Update_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.TextBox Description_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label Description_L;
        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

