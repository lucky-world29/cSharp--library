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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string course = textBox2.Text;
            string branch = textBox3.Text;
            string gender = "";

            if (radioMale.Checked)
            {
                gender = "Male";
            }
            else if (radioFemale.Checked)
            {
                gender = "Female";
            }
            else
            {
                gender = "Not Selected";
            }   
            // Prepare output string
            string result = "ID: " + name + "\n" +
                            "Name: " + course + "\n" +
                            "Salary: " + branch + "\n" +
                            "Gender: " + gender;

            // Display in the label
            labelResult.Text = result;
        }
    }
}
