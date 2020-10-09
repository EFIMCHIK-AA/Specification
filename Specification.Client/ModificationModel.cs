using BusinessModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Specification.Client
{
    public partial class ModificationModel : Form
    {
        public ModificationModel(bool isUpdate)
        {
            InitializeComponent();
            IsUpdate = isUpdate;
        }

        private bool IsUpdate;

        private void ModificationModel_Load(object sender, EventArgs e)
        {                     
            if (IsUpdate)
            {
                this.Text = "Изменение данных";
                label5.Text = "Изменение данных";
            }
            else
            {
                this.Text = "Добавление данных";
                label5.Text = "Добавление данных";
            }
        }
        
        private void ModificationModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult == DialogResult.OK)
            {
                try
                {
                    String Name = Name_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(Name))
                    {
                        throw new Exception("Наименование должно содержать значение");
                    }

                    String Description = Description_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(Description))
                    {
                        throw new Exception("Описание должно содержать значение");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }       
            }         
        }
    }
}
