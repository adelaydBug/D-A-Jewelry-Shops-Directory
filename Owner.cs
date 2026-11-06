using Microsoft.Data.SqlClient;
using System.Configuration;

namespace dsa_GRAPH.JewelryShop
{
    public partial class Owner : Form
    {
        private readonly string connStr = ConfigurationManager
            .ConnectionStrings["JewelryShopDB"]?.ConnectionString
            ?? throw new InvalidOperationException("Connection string 'JewelryShopDB' not found in App.config.");

        public Owner()
        {
            InitializeComponent();
        }

        private void Owner_Load(object sender, EventArgs e)
        {
            LoadRecordsFromDatabase();
        }

        private void label5_Click(object sender, EventArgs e) { }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e) { }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e) { }

        // 🔹 Load all saved entries from dbo.record
        private void LoadRecordsFromDatabase()
        {
            listBox1.Items.Clear();

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand("SELECT product, branch, name FROM record", conn))
                {
                    conn.Open();
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string product = reader["product"]?.ToString()?.Trim() ?? string.Empty;
                            string branch = reader["branch"]?.ToString()?.Trim() ?? string.Empty;
                            string name = reader["name"]?.ToString()?.Trim() ?? string.Empty;

                            listBox1.Items.Add($"{name} - {product} ({branch})");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading records: " + ex.Message);
            }
        }

        // 🔹 Add new entry to dbo.record
        private void addButton_Click(object sender, EventArgs e)
        {
            var product = comboBox1.SelectedItem?.ToString();
            var branch = comboBox2.SelectedItem?.ToString();
            var name = textBox1.Text;

            if (string.IsNullOrWhiteSpace(name))
            {
                MessageBox.Show("Name is required.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (SqlConnection conn = new SqlConnection(connStr))
                using (SqlCommand cmd = new SqlCommand(
                    @"INSERT INTO record (product, branch, name)
              VALUES (@product, @branch, @name)", conn))
                {
                    cmd.Parameters.Add("@product", System.Data.SqlDbType.NChar, 50).Value = (object)product ?? DBNull.Value;
                    cmd.Parameters.Add("@branch", System.Data.SqlDbType.NChar, 50).Value = (object)branch ?? DBNull.Value;
                    cmd.Parameters.Add("@name", System.Data.SqlDbType.NChar, 50).Value = name;

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Record added successfully!");
                LoadRecordsFromDatabase();

                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                textBox1.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting record: " + ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide();
            return;
        }
    }
}
