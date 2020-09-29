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
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Description_TB = new System.Windows.Forms.TextBox();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Date_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Exit_B = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // List_DGV
            // 
            this.List_DGV.AllowUserToAddRows = false;
            this.List_DGV.AllowUserToDeleteRows = false;
            this.List_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1});
            this.List_DGV.Location = new System.Drawing.Point(12, 12);
            this.List_DGV.Name = "List_DGV";
            this.List_DGV.ReadOnly = true;
            this.List_DGV.RowHeadersVisible = false;
            this.List_DGV.RowHeadersWidth = 51;
            this.List_DGV.Size = new System.Drawing.Size(274, 279);
            this.List_DGV.TabIndex = 0;
            this.List_DGV.SelectionChanged += new System.EventHandler(this.List_DGV_SelectionChanged);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Name";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Add_B
            // 
            this.Add_B.Location = new System.Drawing.Point(295, 114);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(260, 26);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "Добавить";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Update_B
            // 
            this.Update_B.Location = new System.Drawing.Point(295, 146);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(260, 26);
            this.Update_B.TabIndex = 3;
            this.Update_B.Text = "Изменить";
            this.Update_B.UseVisualStyleBackColor = true;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // Delete_B
            // 
            this.Delete_B.Location = new System.Drawing.Point(295, 178);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(260, 26);
            this.Delete_B.TabIndex = 4;
            this.Delete_B.Text = "Удалить";
            this.Delete_B.UseVisualStyleBackColor = true;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // Name_TB
            // 
            this.Name_TB.Location = new System.Drawing.Point(390, 10);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.ReadOnly = true;
            this.Name_TB.Size = new System.Drawing.Size(165, 20);
            this.Name_TB.TabIndex = 5;
            // 
            // Description_TB
            // 
            this.Description_TB.Location = new System.Drawing.Point(390, 36);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.ReadOnly = true;
            this.Description_TB.Size = new System.Drawing.Size(165, 20);
            this.Description_TB.TabIndex = 6;
            // 
            // Id_TB
            // 
            this.Id_TB.Location = new System.Drawing.Point(390, 62);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(165, 20);
            this.Id_TB.TabIndex = 7;
            // 
            // Date_TB
            // 
            this.Date_TB.Location = new System.Drawing.Point(390, 88);
            this.Date_TB.Name = "Date_TB";
            this.Date_TB.ReadOnly = true;
            this.Date_TB.Size = new System.Drawing.Size(165, 20);
            this.Date_TB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(292, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Идентификатор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(292, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата изменения";
            // 
            // Exit_B
            // 
            this.Exit_B.Location = new System.Drawing.Point(295, 263);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(260, 26);
            this.Exit_B.TabIndex = 13;
            this.Exit_B.Text = "Выход";
            this.Exit_B.UseVisualStyleBackColor = true;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(564, 297);
            this.Controls.Add(this.Exit_B);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Date_TB);
            this.Controls.Add(this.Id_TB);
            this.Controls.Add(this.Description_TB);
            this.Controls.Add(this.Name_TB);
            this.Controls.Add(this.Delete_B);
            this.Controls.Add(this.Update_B);
            this.Controls.Add(this.Add_B);
            this.Controls.Add(this.List_DGV);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список моделей";
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView List_DGV;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Update_B;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.TextBox Description_TB;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.TextBox Date_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

