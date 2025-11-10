using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NIT_LAB
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string course = textBox2.Text;
            string branch = textBox3.Text;

            string output = "Name: " + name + "\nCourse: " + course + "\nBranch: " + branch;
            MessageBox.Show(output, "Submitted Data");
        }
    }
}
