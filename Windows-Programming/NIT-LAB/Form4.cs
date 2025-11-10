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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void Insert_Click(object sender, EventArgs e)
        {
            listBox1.Items.Insert(Convert.ToInt32(textBox2.Text), textBox1.Text);
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(textBox1.Text);
        }

        private void RemoveAt_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(Convert.ToInt32(textBox2.Text));
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox2.Text = "";
            listBox1.Items.Clear();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
