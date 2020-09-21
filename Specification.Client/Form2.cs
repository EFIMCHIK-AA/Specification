using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessModel;

namespace Specification.Client
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public string get_Name()
        {
            return Name_TB.Text;
        }
        public string get_Description()
        {
            return Description_TB.Text;
        }

        private void OK_B_Click(object sender, EventArgs e)
        {         
            Close();
        }
    }
}
