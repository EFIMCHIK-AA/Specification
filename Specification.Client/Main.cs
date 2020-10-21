using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Specification.Client.Data;
using Specification.Client.Models;

namespace Specification.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private Data.ApplicationContext _context;
        private SortableBindingList<Model> Models;

        private void InitializeListOfModels()
        {
            Models = new SortableBindingList<Model>(_context.Models.ToList());

            List_DGV.DataSource = Models;

            List_DGV.Columns["Description"].Visible = false;
            List_DGV.Columns["DateCreate"].Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {                      
             try 
            {
                _context = new Data.ApplicationContext();

                InitializeListOfModels();

                if (List_DGV.Rows.Count > 0)
                {
                    StateButton(true);
                }
                else
                {
                    StateButton(false);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
            }      
        }   

        private void Add_B_Click(object sender, EventArgs e)
        {
            try
            {
                ModificationModel modificationModel = new ModificationModel(false);

                if (modificationModel.ShowDialog() == DialogResult.OK)
                {
                    Model modelDB = new Model
                    {
                        DateCreate = DateTime.Now,
                        Name = modificationModel.Name_TB.Text.Trim(),
                        Description = modificationModel.Description_TB.Text.Trim(),
                    };

                    _context.Models.Add(modelDB);
                    _context.SaveChanges();

                    Models.Add(modelDB);
                };
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void Update_B_Click(object sender, EventArgs e)
        {
            try
            {
                ModificationModel modificationModel = new ModificationModel(true);

                Model modelDB = List_DGV.CurrentRow.DataBoundItem as Model;

                if(modelDB == null)
                {
                    throw new Exception("Необходимо выбрать объект");
                }

                modificationModel.Name_TB.Text = modelDB.Name;
                modificationModel.Description_TB.Text = modelDB.Description;

                if (modificationModel.ShowDialog() == DialogResult.OK)
                {
                    Model modelContext = _context.Models.FirstOrDefault(m => m.Id == modelDB.Id);
                    modelContext.Name = modificationModel.Name_TB.Text.Trim();
                    modelContext.DateCreate = DateTime.Now;
                    modelContext.Description = modificationModel.Description_TB.Text.Trim();

                    _context.SaveChanges();

                    Models.Remove(modelDB);                 
                    Models.Add(modelContext);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }   
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите удалить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    Model modelDB = List_DGV.CurrentRow.DataBoundItem as Model;

                    _context.Models.Remove(modelDB);
                    _context.SaveChanges();

                    Models.Remove(modelDB);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }  
        }

        private void List_DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (List_DGV.CurrentCell != null)
            {
                Model modelDB = List_DGV.CurrentRow.DataBoundItem as Model;

                if (modelDB != null)
                {
                    Id_TB.Text = modelDB.Id.ToString();
                    Name_TB.Text = modelDB.Name;
                    Description_TB.Text = modelDB.Description;
                    Date_TB.Text = modelDB.DateCreate.ToString();
                }

                StateButton(true);
            }
            else
            {
                StateButton(false);

                Name_TB.Clear();
                Description_TB.Clear();
                Id_TB.Clear();
                Date_TB.Clear();
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    _context.SaveChanges();
                }
                else
                {
                    e.Cancel = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }           
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StateButton(bool state)
        {
            Update_B.Enabled = state;
            Delete_B.Enabled = state;
        }
    }
}
