using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace dsa_GRAPH.JewelryShop
{
    public partial class Customer : Form
    {
        public Customer()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Customer_Load(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            string product = comboBox1.SelectedItem?.ToString() ?? "";
            string location = comboBox2.SelectedItem?.ToString() ?? "";

            Map mapForm = new Map(product, location);
            mapForm.Show();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
