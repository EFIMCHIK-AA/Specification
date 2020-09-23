namespace Specification.Client
{
    partial class Main
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
            this.List_DGV = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Imya = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // List_DGV
            // 
            this.List_DGV.AllowUserToAddRows = false;
            this.List_DGV.AllowUserToDeleteRows = false;
            this.List_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.ID,
            this.Imya,
            this.Description});
            this.List_DGV.Location = new System.Drawing.Point(12, 31);
            this.List_DGV.Name = "List_DGV";
            this.List_DGV.RowHeadersVisible = false;
            this.List_DGV.RowHeadersWidth = 51;
            this.List_DGV.Size = new System.Drawing.Size(530, 279);
            this.List_DGV.TabIndex = 0;
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
            this.Add_B.Location = new System.Drawing.Point(27, 339);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(137, 45);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "Add";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Update_B
            // 
            this.Update_B.Location = new System.Drawing.Point(206, 339);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(137, 45);
            this.Update_B.TabIndex = 3;
            this.Update_B.Text = "Update";
            this.Update_B.UseVisualStyleBackColor = true;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // Delete_B
            // 
            this.Delete_B.Location = new System.Drawing.Point(383, 339);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(137, 45);
            this.Delete_B.TabIndex = 4;
            this.Delete_B.Text = "Delete";
            this.Delete_B.UseVisualStyleBackColor = true;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(561, 401);
            this.Controls.Add(this.Delete_B);
            this.Controls.Add(this.Update_B);
            this.Controls.Add(this.Add_B);
            this.Controls.Add(this.List_DGV);
            this.Name = "Main";
            this.Text = "Список моделей";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView List_DGV;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Update_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Imya;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
    }
}

