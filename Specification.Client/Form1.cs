using System;
using System.Windows.Forms;

namespace Specification.Client
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        public string a;
        public string b;

        public void set_model_DGV()
        {           
            dataGridView1.RowCount++;
            dataGridView1[2, dataGridView1.RowCount - 1].Value = Convert.ToString(a);
            dataGridView1[3, dataGridView1.RowCount - 1].Value = Convert.ToString(b);
        }
       
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Add_B_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
            a = f.get_Name();
            b = f.get_Description();
            set_model_DGV();
        }

        private void Update_B_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
