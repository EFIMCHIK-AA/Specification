namespace Specification.Client
{
    partial class Form
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
            this.Add_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Data_TB = new System.Windows.Forms.TextBox();
            this.Description_TB = new System.Windows.Forms.TextBox();
            this.ID_TB = new System.Windows.Forms.TextBox();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Date_L = new System.Windows.Forms.Label();
            this.Description_L = new System.Windows.Forms.Label();
            this.ID_L = new System.Windows.Forms.Label();
            this.Name_L = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imya = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.Description,
            this.ID,
            this.Imya});
            this.dataGridView1.Location = new System.Drawing.Point(12, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(530, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(27, 339);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(137, 45);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "Add";
            this.Add_B.UseVisualStyleBackColor = true;
            // 
            // Update_B
            // 
            this.Update_B.Location = new System.Drawing.Point(206, 339);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(137, 45);
            this.Update_B.TabIndex = 3;
            this.Update_B.Text = "Update";
            this.Update_B.UseVisualStyleBackColor = true;
            // 
            // Delete_B
            // 
            this.Delete_B.Location = new System.Drawing.Point(383, 339);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(137, 45);
            this.Delete_B.TabIndex = 4;
            this.Delete_B.Text = "Delete";
            this.Delete_B.UseVisualStyleBackColor = true;
            // 
            // Data_TB
            // 
            this.Data_TB.Location = new System.Drawing.Point(640, 96);
            this.Data_TB.Name = "Data_TB";
            this.Data_TB.Size = new System.Drawing.Size(155, 20);
            this.Data_TB.TabIndex = 5;
            // 
            // Description_TB
            // 
            this.Description_TB.Location = new System.Drawing.Point(640, 132);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.Size = new System.Drawing.Size(155, 20);
            this.Description_TB.TabIndex = 6;
            // 
            // ID_TB
            // 
            this.ID_TB.Location = new System.Drawing.Point(640, 168);
            this.ID_TB.Name = "ID_TB";
            this.ID_TB.Size = new System.Drawing.Size(155, 20);
            this.ID_TB.TabIndex = 7;
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(640, 204);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.Size = new System.Drawing.Size(155, 20);
            this.Name_TB.TabIndex = 8;
            // 
            // Date_L
            // 
            this.Date_L.AutoSize = true;
            this.Date_L.Location = new System.Drawing.Point(572, 99);
            this.Date_L.Name = "Date_L";
            this.Date_L.Size = new System.Drawing.Size(30, 13);
            this.Date_L.TabIndex = 9;
            this.Date_L.Text = "Date";
            // 
            // Description_L
            // 
            this.Description_L.AutoSize = true;
            this.Description_L.Location = new System.Drawing.Point(572, 135);
            this.Description_L.Name = "Description_L";
            this.Description_L.Size = new System.Drawing.Size(60, 13);
            this.Description_L.TabIndex = 10;
            this.Description_L.Text = "Description";
            // 
            // ID_L
            // 
            this.ID_L.AutoSize = true;
            this.ID_L.Location = new System.Drawing.Point(572, 171);
            this.ID_L.Name = "ID_L";
            this.ID_L.Size = new System.Drawing.Size(18, 13);
            this.ID_L.TabIndex = 11;
            this.ID_L.Text = "ID";
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Location = new System.Drawing.Point(572, 207);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(35, 13);
            this.Name_L.TabIndex = 12;
            this.Name_L.Text = "Name";
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 120;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 6;
            this.Description.Name = "Description";
            this.Description.Width = 150;
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
            // Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(817, 401);
            this.Controls.Add(this.Name_L);
            this.Controls.Add(this.ID_L);
            this.Controls.Add(this.Description_L);
            this.Controls.Add(this.Date_L);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.ID_TB);
            this.Controls.Add(this.Description_TB);
            this.Controls.Add(this.Data_TB);
            this.Controls.Add(this.Delete_B);
            this.Controls.Add(this.Update_B);
            this.Controls.Add(this.Add_B);
            this.Controls.Add(this.dataGridView1);
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
        private System.Windows.Forms.TextBox Data_TB;
        private System.Windows.Forms.TextBox Description_TB;
        private System.Windows.Forms.TextBox ID_TB;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label Date_L;
        private System.Windows.Forms.Label Description_L;
        private System.Windows.Forms.Label ID_L;
        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imya;
    }
}

