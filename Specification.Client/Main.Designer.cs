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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.List_DGV = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add_B = new System.Windows.Forms.Button();
            this.Update_B = new System.Windows.Forms.Button();
            this.Description_TB = new System.Windows.Forms.TextBox();
            this.Id_TB = new System.Windows.Forms.TextBox();
            this.Date_TB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Name_TB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Delete_B = new System.Windows.Forms.Button();
            this.Exit_B = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
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
            this.List_DGV.Size = new System.Drawing.Size(980, 579);
            this.List_DGV.TabIndex = 0;
            this.List_DGV.SelectionChanged += new System.EventHandler(this.List_DGV_SelectionChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ID.DataPropertyName = "Id";
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
            this.Column1.HeaderText = "Наименование";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Add_B
            // 
            this.Add_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Add_B, 2);
            this.Add_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_B.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Add_B.Location = new System.Drawing.Point(0, 112);
            this.Add_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Add_B.Name = "Add_B";
            this.Add_B.Size = new System.Drawing.Size(420, 34);
            this.Add_B.TabIndex = 2;
            this.Add_B.Text = "&Добавить";
            this.Add_B.UseVisualStyleBackColor = false;
            this.Add_B.Click += new System.EventHandler(this.Add_B_Click);
            // 
            // Update_B
            // 
            this.Update_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Update_B, 2);
            this.Update_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Update_B.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Update_B.Location = new System.Drawing.Point(0, 151);
            this.Update_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Update_B.Name = "Update_B";
            this.Update_B.Size = new System.Drawing.Size(420, 34);
            this.Update_B.TabIndex = 3;
            this.Update_B.Text = "&Изменить";
            this.Update_B.UseVisualStyleBackColor = false;
            this.Update_B.Click += new System.EventHandler(this.Update_B_Click);
            // 
            // Description_TB
            // 
            this.Description_TB.BackColor = System.Drawing.Color.Azure;
            this.Description_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Description_TB.Location = new System.Drawing.Point(126, 28);
            this.Description_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Description_TB.Name = "Description_TB";
            this.Description_TB.ReadOnly = true;
            this.Description_TB.Size = new System.Drawing.Size(294, 23);
            this.Description_TB.TabIndex = 6;
            // 
            // Id_TB
            // 
            this.Id_TB.BackColor = System.Drawing.Color.Azure;
            this.Id_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Id_TB.Location = new System.Drawing.Point(126, 56);
            this.Id_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Id_TB.Name = "Id_TB";
            this.Id_TB.ReadOnly = true;
            this.Id_TB.Size = new System.Drawing.Size(294, 23);
            this.Id_TB.TabIndex = 7;
            // 
            // Date_TB
            // 
            this.Date_TB.BackColor = System.Drawing.Color.Azure;
            this.Date_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Date_TB.Location = new System.Drawing.Point(126, 84);
            this.Date_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Date_TB.Name = "Date_TB";
            this.Date_TB.ReadOnly = true;
            this.Date_TB.Size = new System.Drawing.Size(294, 23);
            this.Date_TB.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(0, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Описание";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(0, 56);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Идентификатор";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(0, 84);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 23);
            this.label4.TabIndex = 12;
            this.label4.Text = "Дата изменения";
            // 
            // Name_TB
            // 
            this.Name_TB.BackColor = System.Drawing.Color.Azure;
            this.Name_TB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Name_TB.Location = new System.Drawing.Point(126, 0);
            this.Name_TB.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Name_TB.Name = "Name_TB";
            this.Name_TB.ReadOnly = true;
            this.Name_TB.Size = new System.Drawing.Size(294, 23);
            this.Name_TB.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Наименование";
            // 
            // Delete_B
            // 
            this.Delete_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Delete_B, 2);
            this.Delete_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delete_B.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Delete_B.Location = new System.Drawing.Point(0, 190);
            this.Delete_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Delete_B.Name = "Delete_B";
            this.Delete_B.Size = new System.Drawing.Size(420, 34);
            this.Delete_B.TabIndex = 4;
            this.Delete_B.Text = "&Удалить";
            this.Delete_B.UseVisualStyleBackColor = false;
            this.Delete_B.Click += new System.EventHandler(this.Delete_B_Click);
            // 
            // Exit_B
            // 
            this.Exit_B.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tableLayoutPanel5.SetColumnSpan(this.Exit_B, 2);
            this.Exit_B.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Exit_B.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Exit_B.Location = new System.Drawing.Point(0, 537);
            this.Exit_B.Margin = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.Exit_B.Name = "Exit_B";
            this.Exit_B.Size = new System.Drawing.Size(420, 42);
            this.Exit_B.TabIndex = 13;
            this.Exit_B.Text = "&Выход";
            this.Exit_B.UseVisualStyleBackColor = false;
            this.Exit_B.Click += new System.EventHandler(this.Exit_B_Click);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(5, 5);
            this.label5.Margin = new System.Windows.Forms.Padding(5);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(980, 45);
            this.label5.TabIndex = 15;
            this.label5.Text = "Список элементов";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(990, 5);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 5, 5, 5);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(3);
            this.label6.Size = new System.Drawing.Size(420, 45);
            this.label6.TabIndex = 16;
            this.label6.Text = "Описание";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.List_DGV, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label6, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 2;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1415, 639);
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
            this.tableLayoutPanel5.Controls.Add(this.label4, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.Name_TB, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.Id_TB, 1, 2);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(990, 55);
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
            this.tableLayoutPanel5.Size = new System.Drawing.Size(425, 584);
            this.tableLayoutPanel5.TabIndex = 18;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCyan;
            this.ClientSize = new System.Drawing.Size(1415, 639);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.TextBox Name_TB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_B;
        private System.Windows.Forms.Button Exit_B;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
    }
}

