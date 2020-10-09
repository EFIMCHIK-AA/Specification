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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_DGV
            // 
            this.List_DGV.AllowUserToAddRows = false;
            this.List_DGV.AllowUserToDeleteRows = false;
            this.List_DGV.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.List_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1});
            this.List_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_DGV.Location = new System.Drawing.Point(3, 3);
            this.List_DGV.Name = "List_DGV";
            this.List_DGV.ReadOnly = true;
            this.List_DGV.RowHeadersVisible = false;
            this.List_DGV.RowHeadersWidth = 51;
            this.tableLayoutPanel1.SetRowSpan(this.List_DGV, 9);
            this.List_DGV.Size = new System.Drawing.Size(459, 398);
            this.List_DGV.TabIndex = 0;
            this.List_DGV.SelectionChanged += new System.EventHandler(this.List_DGV_SelectionChanged);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Id";
            this.ID.HeaderText = "Идентифкатор";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Name";
            this.Column1.HeaderText = "Наименование";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Add_B
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Add_B, 2);
            this.Add_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_B.Location = new System.Drawing.Point(468, 107);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(252, 26);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "&Добавить";
            this.Add_B.UseVisualStyleBackColor = true;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Update_B
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Update_B, 2);
            this.Update_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_B.Location = new System.Drawing.Point(468, 139);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(252, 26);
            this.Update_B.TabIndex = 3;
            this.Update_B.Text = "&Изменить";
            this.Update_B.UseVisualStyleBackColor = true;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // Delete_B
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.Delete_B, 2);
            this.Delete_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_B.Location = new System.Drawing.Point(468, 171);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(252, 26);
            this.Delete_B.TabIndex = 4;
            this.Delete_B.Text = "&Удалить";
            this.Delete_B.UseVisualStyleBackColor = true;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // Name_TB
            // 
            this.Name_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_TB.Location = new System.Drawing.Point(570, 3);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.ReadOnly = true;
            this.Name_TB.Size = new System.Drawing.Size(150, 20);
            this.Name_TB.TabIndex = 5;
            // 
            // Description_TB
            // 
            this.Description_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_TB.Location = new System.Drawing.Point(570, 29);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.ReadOnly = true;
            this.Description_TB.Size = new System.Drawing.Size(150, 20);
            this.Description_TB.TabIndex = 6;
            // 
            // Id_TB
            // 
            this.Id_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Id_TB.Location = new System.Drawing.Point(570, 55);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(150, 20);
            this.Id_TB.TabIndex = 7;
            // 
            // Date_TB
            // 
            this.Date_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date_TB.Location = new System.Drawing.Point(570, 81);
            this.Date_TB.Name = "Date_TB";
            this.Date_TB.ReadOnly = true;
            this.Date_TB.Size = new System.Drawing.Size(150, 20);
            this.Date_TB.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(470, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименование";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(470, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(470, 57);
            this.label3.Margin = new System.Windows.Forms.Padding(5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Идентификатор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(470, 83);
            this.label4.Margin = new System.Windows.Forms.Padding(5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата изменения";
            // 
            // Exit_B
            // 
            this.Exit_B.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.SetColumnSpan(this.Exit_B, 2);
            this.Exit_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_B.Location = new System.Drawing.Point(468, 377);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(252, 24);
            this.Exit_B.TabIndex = 13;
            this.Exit_B.Text = "&Выход";
            this.Exit_B.UseVisualStyleBackColor = false;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.Description_TB, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Date_TB, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.Name_TB, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Id_TB, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.List_DGV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.Add_B, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Update_B, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.Delete_B, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.Exit_B, 1, 8);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(2, 44);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 9;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(723, 404);
            this.tableLayoutPanel1.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(4, 5);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(7);
            this.label5.Size = new System.Drawing.Size(463, 36);
            this.label5.TabIndex = 15;
            this.label5.Text = "Список элементов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(473, 5);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(7);
            this.label6.Size = new System.Drawing.Size(252, 36);
            this.label6.TabIndex = 16;
            this.label6.Text = "Описание";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MinimumSize = new System.Drawing.Size(730, 450);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список моделей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

