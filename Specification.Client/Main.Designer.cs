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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.List_DGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.Description_TB = new System.Windows.Forms.TextBox();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Date_TB = new System.Windows.Forms.TextBox();
            this.Description_L = new System.Windows.Forms.Label();
            this.ID_L = new System.Windows.Forms.Label();
            this.Date_L = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.Name_L = new System.Windows.Forms.Label();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.Spisok_L = new System.Windows.Forms.Label();
            this.Description_LHeader = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // List_DGV
            // 
            this.List_DGV.AllowUserToAddRows = false;
            this.List_DGV.AllowUserToDeleteRows = false;
            this.List_DGV.AllowUserToResizeColumns = false;
            this.List_DGV.AllowUserToResizeRows = false;
            this.List_DGV.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.List_DGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.List_DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.List_DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column1});
            this.List_DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.List_DGV.Location = new System.Drawing.Point(5, 55);
            this.List_DGV.Margin = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.List_DGV.MultiSelect = false;
            this.List_DGV.Name = "List_DGV";
            this.List_DGV.ReadOnly = true;
            this.List_DGV.RowHeadersVisible = false;
            this.List_DGV.RowHeadersWidth = 51;
            this.List_DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.List_DGV.Size = new System.Drawing.Size(656, 478);
            this.List_DGV.TabIndex = 2;
            this.List_DGV.SelectionChanged += new System.EventHandler(this.List_DGV_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "Id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ID.DefaultCellStyle = dataGridViewCellStyle2;
            this.ID.HeaderText = "Идентифкатор";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "Name";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "Наименование";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Add_B
            // 
            this.Add_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Add_B, 2);
            this.Add_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_B.Location = new System.Drawing.Point(0, 166);
            this.Add_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(281, 34);
            this.Add_B.TabIndex = 11;
            this.Add_B.Text = "&Добавить";
            this.Add_B.UseVisualStyleBackColor = false;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Update_B
            // 
            this.Update_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Update_B, 2);
            this.Update_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_B.Location = new System.Drawing.Point(0, 205);
            this.Update_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(281, 34);
            this.Update_B.TabIndex = 12;
            this.Update_B.Text = "&Изменить";
            this.Update_B.UseVisualStyleBackColor = false;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // Description_TB
            // 
            this.Description_TB.BackColor = System.Drawing.Color.Azure;
            this.Description_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_TB.Location = new System.Drawing.Point(126, 45);
            this.Description_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.ReadOnly = true;
            this.Description_TB.Size = new System.Drawing.Size(155, 26);
            this.Description_TB.TabIndex = 6;
            this.Description_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Id_TB
            // 
            this.Id_TB.BackColor = System.Drawing.Color.Azure;
            this.Id_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Id_TB.Location = new System.Drawing.Point(126, 76);
            this.Id_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(155, 26);
            this.Id_TB.TabIndex = 8;
            this.Id_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Date_TB
            // 
            this.Date_TB.BackColor = System.Drawing.Color.Azure;
            this.Date_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date_TB.Location = new System.Drawing.Point(126, 121);
            this.Date_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Date_TB.Name = "Date_TB";
            this.Date_TB.ReadOnly = true;
            this.Date_TB.Size = new System.Drawing.Size(155, 26);
            this.Date_TB.TabIndex = 10;
            this.Date_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Description_L
            // 
            this.Description_L.AutoSize = true;
            this.Description_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_L.Location = new System.Drawing.Point(0, 45);
            this.Description_L.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Description_L.Name = "Description_L";
            this.Description_L.Size = new System.Drawing.Size(121, 26);
            this.Description_L.TabIndex = 5;
            this.Description_L.Text = "Описание";
            // 
            // ID_L
            // 
            this.ID_L.AutoSize = true;
            this.ID_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ID_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ID_L.Location = new System.Drawing.Point(0, 76);
            this.ID_L.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.ID_L.Name = "ID_L";
            this.ID_L.Size = new System.Drawing.Size(121, 40);
            this.ID_L.TabIndex = 7;
            this.ID_L.Text = "Идентификатор";
            // 
            // Date_L
            // 
            this.Date_L.AutoSize = true;
            this.Date_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Date_L.Location = new System.Drawing.Point(0, 121);
            this.Date_L.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Date_L.Name = "Date_L";
            this.Date_L.Size = new System.Drawing.Size(121, 40);
            this.Date_L.TabIndex = 9;
            this.Date_L.Text = "Дата изменения";
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.Color.Azure;
            this.Name_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_TB.Location = new System.Drawing.Point(126, 0);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.ReadOnly = true;
            this.Name_TB.Size = new System.Drawing.Size(155, 26);
            this.Name_TB.TabIndex = 4;
            this.Name_TB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Name_L
            // 
            this.Name_L.AutoSize = true;
            this.Name_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Name_L.Location = new System.Drawing.Point(0, 0);
            this.Name_L.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name_L.Name = "Name_L";
            this.Name_L.Size = new System.Drawing.Size(121, 40);
            this.Name_L.TabIndex = 3;
            this.Name_L.Text = "Наименование";
            // 
            // Delete_B
            // 
            this.Delete_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Delete_B, 2);
            this.Delete_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_B.Location = new System.Drawing.Point(0, 244);
            this.Delete_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(281, 34);
            this.Delete_B.TabIndex = 13;
            this.Delete_B.Text = "&Удалить";
            this.Delete_B.UseVisualStyleBackColor = false;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Exit_B, 2);
            this.Exit_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_B.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_B.Location = new System.Drawing.Point(0, 436);
            this.Exit_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(281, 42);
            this.Exit_B.TabIndex = 14;
            this.Exit_B.Text = "&Выход";
            this.Exit_B.UseVisualStyleBackColor = false;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // Spisok_L
            // 
            this.Spisok_L.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Spisok_L.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Spisok_L.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Spisok_L.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Spisok_L.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Spisok_L.Location = new System.Drawing.Point(5, 5);
            this.Spisok_L.Margin = new System.Windows.Forms.Padding(5);
            this.Spisok_L.Name = "Spisok_L";
            this.Spisok_L.Padding = new System.Windows.Forms.Padding(3);
            this.Spisok_L.Size = new System.Drawing.Size(656, 45);
            this.Spisok_L.TabIndex = 0;
            this.Spisok_L.Text = "Список элементов";
            this.Spisok_L.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Description_LHeader
            // 
            this.Description_LHeader.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Description_LHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Description_LHeader.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_LHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Description_LHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Description_LHeader.Location = new System.Drawing.Point(666, 5);
            this.Description_LHeader.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.Description_LHeader.Name = "Description_LHeader";
            this.Description_LHeader.Padding = new System.Windows.Forms.Padding(3);
            this.Description_LHeader.Size = new System.Drawing.Size(281, 45);
            this.Description_LHeader.TabIndex = 1;
            this.Description_LHeader.Text = "Описание";
            this.Description_LHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.List_DGV, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.Spisok_L, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.Description_LHeader, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(952, 538);
            this.tableLayoutPanel4.TabIndex = 17;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 126F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.Exit_B, 0, 8);
            this.tableLayoutPanel5.Controls.Add(this.Delete_B, 0, 6);
            this.tableLayoutPanel5.Controls.Add(this.Date_TB, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.Update_B, 0, 5);
            this.tableLayoutPanel5.Controls.Add(this.Add_B, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.Description_TB, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.Date_L, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.Name_L, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.ID_L, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.Name_TB, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.Description_L, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Id_TB, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(666, 55);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 9;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel5.Size = new System.Drawing.Size(286, 483);
            this.tableLayoutPanel5.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(952, 538);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(968, 577);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список моделей";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.List_DGV)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView List_DGV;
        private System.Windows.Forms.Button Add_B;
        private System.Windows.Forms.Button Update_B;
        private System.Windows.Forms.TextBox Description_TB;
        private System.Windows.Forms.TextBox Id_TB;
        private System.Windows.Forms.TextBox Date_TB;
        private System.Windows.Forms.Label Description_L;
        private System.Windows.Forms.Label ID_L;
        private System.Windows.Forms.Label Date_L;
        private System.Windows.Forms.Label Spisok_L;
        private System.Windows.Forms.Label Description_LHeader;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label Name_L;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
    }
}

