using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oef2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("De combox is leeg.");
            }
            else {
            MessageBox.Show(comboBox1.SelectedItem.ToString());
            comboBox1.Items.RemoveAt(comboBox1.SelectedIndex);
            }
        }
       

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Ksfsqffqs");
            comboBox1.Items.Add("Bxxwx");
            comboBox1.Items.Add("Kxxw");
            comboBox1.Items.Add("uipglkhjk");
            comboBox1.Items.Add("kvkjvh");
          

        }
    }
}
