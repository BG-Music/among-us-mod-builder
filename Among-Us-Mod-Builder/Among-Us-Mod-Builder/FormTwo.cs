using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Among_Us_Mod_Builder
{
    public partial class FormTwo : Form
    {
        public FormTwo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error: \nThis feature is not complete yet.", "ERROR");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Error: \nThis feature is not complete yet.", "ERROR");
        }
    }
}
