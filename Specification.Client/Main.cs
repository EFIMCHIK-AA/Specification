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


        public void set_model_DGV()
        {           
            //dataGridView1.RowCount++;
            //dataGridView1[2, dataGridView1.RowCount - 1].Value = Convert.ToString(a);
            //dataGridView1[3, dataGridView1.RowCount - 1].Value = Convert.ToString(b);
        }

        public void get_model_DGV()
        {
            //int rowindex = dataGridView1.CurrentCell.RowIndex;
            //dataGridView1.Rows[rowindex].Cells[2].Value = Convert.ToString(c);
            //dataGridView1.Rows[rowindex].Cells[3].Value = Convert.ToString(d);
        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            String error = String.Empty;

            ModificationModel modificationModel = new ModificationModel(false);

            modificationModel.ShowDialog();
            
            //f2.ShowDialog();
            //a = f2.get_Name();
            //b = f2.get_Description();
            //set_model_DGV();
        }

        private void Update_B_Click(object sender, EventArgs e)
        {
            get_model_DGV();
            ModificationModel f2 = new ModificationModel(true);
            f2.ShowDialog();
            f2.Owner = this;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {

        }
    }
}
