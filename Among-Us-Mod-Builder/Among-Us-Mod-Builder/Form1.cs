using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Among_Us_Mod_Builder
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Builders\\fast.cmd");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Builders\\normal.cmd");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Bossgamerteam/among-us-mod-builder");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files/Epic Games/AmongUs");
            MessageBox.Show("Trying to open path.", "Path");
        }

    private void button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("Builders\\");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("C:/Program Files (x86)/Steam/steamapps/common/Among Us");
            MessageBox.Show("Trying to open path.", "Path");
        }

        private void label3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Bossgamerteam");
        }

        private void label4_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/modded-official");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            AboutBox1 box = new AboutBox1();

            box.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://docs.reactor.gg");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/NuclearPowered");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tabPage5_Click(object sender, EventArgs e)
        {
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            FormTwo Two = new FormTwo();

            Two.ShowDialog();
        }
    }
}