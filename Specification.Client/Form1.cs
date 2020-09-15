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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            OpenFileDialog afd = new OpenFileDialog();

            if(afd.ShowDialog() == DialogResult.OK)
            {
                if(!String.IsNullOrWhiteSpace(afd.FileName))
                {
                    String temp = afd.FileName;
                    String temp1 = afd.FileName;
                }
            }
        }
    }
}
