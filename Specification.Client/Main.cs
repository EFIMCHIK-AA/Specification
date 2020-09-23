using System;
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
       
        public void Set_model_DGV()
        {
            Model model = ModificationModel.model;
            List_DGV.RowCount++;
            List_DGV[0, List_DGV.RowCount - 1].Value = Convert.ToString(model.DateCreate);
            List_DGV[1, List_DGV.RowCount - 1].Value = Convert.ToString(model.Id);
            List_DGV[2, List_DGV.RowCount - 1].Value = Convert.ToString(model.Name); 
            List_DGV[3, List_DGV.RowCount - 1].Value = Convert.ToString(model.Description);
        }

        public void Get_model_DGV()
        {
            //int rowindex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows[rowindex].Cells[2].Value = Convert.ToString(c);
            //dataGridView1.Rows[rowindex].Cells[3].Value = Convert.ToString(d);
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            //String error = String.Empty;
            ModificationModel modificationModel = new ModificationModel(false);
            modificationModel.ShowDialog();
            Set_model_DGV();
        }

        private void Update_B_Click(object sender, EventArgs e)
        {
            Get_model_DGV();
            ModificationModel modificationModel = new ModificationModel(true);
            
        }

        

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
