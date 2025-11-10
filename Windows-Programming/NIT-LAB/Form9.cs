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
    public partial class Form9 : Form
    {
        Dictionary<string, Dictionary<string, List<string>>> data =
           new Dictionary<string, Dictionary<string, List<string>>>()
           {
                {
                    "Electronics", new Dictionary<string, List<string>>()
                    {
                        { "Mobiles", new List<string> { "iPhone", "Samsung Galaxy" } },
                        { "Laptops", new List<string> { "Dell XPS", "HP Pavilion" } }
                    }
                },
                {
                    "Clothing", new Dictionary<string, List<string>>()
                    {
                        { "Men", new List<string> { "Shirt", "Jeans" } },
                        { "Women", new List<string> { "Dress", "Skirt" } }
                    }
                }
           };
        public Form9()
        {
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Electronics");
            comboBox1.Items.Add("Clothing");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            comboBox3.Items.Clear();

            if (comboBox1.SelectedItem == null) return;

            string cat = comboBox1.SelectedItem.ToString();

            if (data.ContainsKey(cat))
            {
                foreach (var sub in data[cat].Keys)
                {
                    comboBox2.Items.Add(sub);
                }
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox3.Items.Clear();

            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null) return;

            string cat = comboBox1.SelectedItem.ToString();
            string subcat = comboBox2.SelectedItem.ToString();

            if (data[cat].ContainsKey(subcat))
            {
                comboBox3.Items.AddRange(data[cat][subcat].ToArray());
            }
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null &&
         comboBox2.SelectedItem != null &&
         comboBox3.SelectedItem != null)
            {
                string category = comboBox1.SelectedItem.ToString();
                string subcategory = comboBox2.SelectedItem.ToString();
                string product = comboBox3.SelectedItem.ToString();

                // Create Form10_9 object and pass the selected values
                Form10_9 popup = new Form10_9(category, subcategory, product);
                popup.ShowDialog();  // Show as popup
            }
            else
            {
                MessageBox.Show("Please select all ComboBox values before submitting.",
                                "Incomplete Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
