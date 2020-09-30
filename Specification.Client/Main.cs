﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessModel;

namespace Specification.Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private List<Model> Models = new List<Model>(); //List<Model> - список всех моделей

        String dataFile = "data.text";
        String confFile = "id.text";

        public void ViewDataModel(Model model)
        {
            if(model != null)
            {
                List_DGV.RowCount++;
                List_DGV[0, List_DGV.RowCount - 1].Value = model.Id;
                List_DGV[1, List_DGV.RowCount - 1].Value = model.Name;
            }
        }

        public void DeleteViewDataModel(int idRow)
        {
            List_DGV.Rows.RemoveAt(idRow);
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            ModificationModel modificationModel = new ModificationModel(false);

            int lastId = 0;

            if (File.Exists(confFile))
            {
                using (StreamReader sr = new StreamReader(File.Open(confFile, FileMode.Open)))
                {
                    lastId = Convert.ToInt32(sr.ReadLine());
                }

                Helper.Id = lastId++;

                using (StreamWriter sw = new StreamWriter(File.Open("id.text", FileMode.Create)))
                {
                    sw.WriteLine(lastId);
                }
            }

            if (modificationModel.ShowDialog() == DialogResult.OK)
            {
                Model model = new Model
                {                 
                    Id = ++Helper.Id,
                    DateCreate = DateTime.Now,
                    Name = modificationModel.Name_TB.Text.Trim(),
                    Description = modificationModel.Description_TB.Text.Trim(),
                };

                Models.Add(model);
                ViewDataModel(model);
            };           
        }

        private void Update_B_Click(object sender, EventArgs e)
        {
            ModificationModel modificationModel = new ModificationModel(true);

            Model model = GetModel(GetId());

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
                DeleteViewDataModel(List_DGV.CurrentCell.RowIndex);

                Models.Add(updateModel);
                ViewDataModel(updateModel);
            };
        }

        private void Delete_B_Click(object sender, EventArgs e)
        {
            Model model = GetModel(GetId());

            Models.Remove(model);
            DeleteViewDataModel(List_DGV.CurrentCell.RowIndex);
        }

        private void List_DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (List_DGV.CurrentCell != null)
            {
                Model model = GetModel(GetId());

                if (model != null)
                {
                    Id_TB.Text = model.Id.ToString();
                    Name_TB.Text = model.Name;
                    Description_TB.Text = model.Description;
                    Date_TB.Text = model.DateCreate.ToString();
                }
            }
        }

        private Model GetModel(int id)
        {
            Model model = null;

            for (int i = 0; i < Models.Count; i++)
            {
                if (Models[i].Id == id)
                {
                    model = Models[i];
                    break;
                }
            }

            return model;
        }

        private int GetId()
        {
            return Convert.ToInt32(List_DGV[0, List_DGV.CurrentCell.RowIndex].Value);
        }

        private void Exit_B_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите выйти?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                using (StreamWriter sw = new StreamWriter(File.Open("data.text", FileMode.Create)))
                {
                    for (int i = 0; i < Models.Count; i++)
                    {
                        sw.WriteLine(Models[i].Id);
                        sw.WriteLine(Models[i].Name);
                        sw.WriteLine(Models[i].Description);
                        sw.WriteLine(Models[i].DateCreate);
                    }
                }

                int lastId = Helper.Id;

                using (StreamWriter sw = new StreamWriter(File.Open("id.text", FileMode.Create)))
                {
                    sw.WriteLine(lastId);
                }    

                    Application.Exit();
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (File.Exists(dataFile))
            {
                using (StreamReader sr = new StreamReader(File.Open(dataFile, FileMode.Open)))
                {
                    String Id = null;

                    while (true)
                    {
                        Id = sr.ReadLine();

                        if(Id == null)
                        {
                            break;
                        }

                        Model model = new Model();

                        model.Id = Convert.ToInt32(Id);
                        model.Name = sr.ReadLine();
                        model.Description = sr.ReadLine();
                        model.DateCreate = Convert.ToDateTime(sr.ReadLine());

                        Models.Add(model);

                        ViewDataModel(model);
                    }
                }
            }
        }        
    }
}
