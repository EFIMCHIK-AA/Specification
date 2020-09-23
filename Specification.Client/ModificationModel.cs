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
            //Main f1 = this.Owner as Main;

            
            if (IsUpdate)
            {
                this.Text = "Изменение данных";
                //Name_TB.Text = f1.c;
                //Description_TB.Text = f1.d;
            }
            else
            {
                this.Text = "Добавление данных";
            }
        }

        private void ModificationModel_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(DialogResult == DialogResult.OK)
            {
                try
                {
                    Model model = new Model();

                    model.Id = ++Helper.Id;
                    model.DateCreate = DateTime.Now;

                    String Name = Name_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(Name))
                    {
                        throw new Exception("Наименование должно содержать значение");
                    }

                    model.Name = Name;

                    String Description = Description_TB.Text.Trim();

                    if (String.IsNullOrWhiteSpace(Description))
                    {
                        throw new Exception("Описание должно содержать значение");
                    }

                    model.Description = Description;
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
