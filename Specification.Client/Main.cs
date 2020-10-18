using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

        String dataFile = "data.text";
        String confFile = "id.text";

        private void Main_Load(object sender, EventArgs e)
        {
            _context = new Data.ApplicationContext();

            InitializeListOfModels();

            try 
            {
                if (File.Exists(dataFile))
                {
                    using (StreamReader sr = new StreamReader(File.Open(dataFile, FileMode.Open)))
                    {
                        String Id = null;

                        while (true)
                        {
                            Id = sr.ReadLine();

                            if (Id == null)
                            {
                                break;
                            }

                            Model model = new Model();

                            model.Id = Convert.ToInt32(Id);
                            model.Name = sr.ReadLine();
                            model.Description = sr.ReadLine();
                            model.DateCreate = Convert.ToDateTime(sr.ReadLine());

                            Models.Add(model);
                        }
                    }
                }
                else
                {
                    File.Create(dataFile);
                }

                if (File.Exists(confFile))
                {
                    using (StreamReader sr = new StreamReader(File.Open(confFile, FileMode.Open)))
                    {
                        Helper.Id = Convert.ToInt32(sr.ReadLine());
                    }
                }
                else
                {
                    File.Create(confFile);
                }

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
                    //Model model = new Model
                    //{
                    //    Id = ++Helper.Id,
                    //    DateCreate = DateTime.Now,
                    //    Name = modificationModel.Name_TB.Text.Trim(),
                    //    Description = modificationModel.Description_TB.Text.Trim(),
                    //};

                    //Models.Add(model);

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

                Model model = List_DGV.CurrentRow.DataBoundItem as Model;

                if(model == null)
                {
                    throw new Exception("Необходимо выбрать Объект не выбран");
                }

                modificationModel.Name_TB.Text = model.Name;
                modificationModel.Description_TB.Text = model.Description;

                if (modificationModel.ShowDialog() == DialogResult.OK)
                {
                    Model updateModel = new Model
                    {
                        Id = model.Id,
                        DateCreate = DateTime.Now,
                        Name = modificationModel.Name_TB.Text.Trim(),
                        Description = modificationModel.Description_TB.Text.Trim(),
                    };

                    Models.Remove(model);
                    Models.Add(updateModel);
                };
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
                    Model model = List_DGV.CurrentRow.DataBoundItem as Model;

                    Models.Remove(model);

                    if (List_DGV.RowCount == 0)
                    {
                        Name_TB.Clear();
                        Description_TB.Clear();
                        Id_TB.Clear();
                        Date_TB.Clear();
                    }

                    if (List_DGV.RowCount >= 1)
                    {
                        List_DGV.Rows[List_DGV.Rows.Count - 1].Selected = true;
                    }
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
                Model model = List_DGV.CurrentRow.DataBoundItem as Model;

                if (model != null)
                {
                    Id_TB.Text = model.Id.ToString();
                    Name_TB.Text = model.Name;
                    Description_TB.Text = model.Description;
                    Date_TB.Text = model.DateCreate.ToString();
                }

                StateButton(true);
            }
            else
            {
                StateButton(false);
            }
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            File.WriteAllText(dataFile, string.Empty);
            try
            {
                if (MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    using (StreamWriter sw = new StreamWriter(File.Open(dataFile, FileMode.OpenOrCreate)))
                    {
                        for (int i = 0; i < Models.Count; i++)
                        {
                            sw.WriteLine(Models[i].Id);
                            sw.WriteLine(Models[i].Name);
                            sw.WriteLine(Models[i].Description);
                            sw.WriteLine(Models[i].DateCreate);
                        }
                    }

                    using (StreamWriter sw = new StreamWriter(File.Open(confFile, FileMode.OpenOrCreate)))
                    {
                        sw.WriteLine(Helper.Id);
                    }
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

