namespace dsa_GRAPH.JewelryShop
{
    public partial class Main : Form
    {
        private Owner ownerForm;
        private int loginAttempts = 0;
        private const string ownerPassword = "admin123";


        public Main()
        {
            InitializeComponent();
            ownerForm = new Owner();

        }

        private void title_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer customerForm = new Customer();
            customerForm.Show();
            this.Hide();
            return;
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void owner_Click(object sender, EventArgs e)
        {

            while (loginAttempts < 3)
            {
                string input = Microsoft.VisualBasic.Interaction.InputBox(
                    "Enter owner password:", "Owner Login", "", -1, -1);

                if (input == ownerPassword)
                {
                    MessageBox.Show("Access granted!");
                    Owner ownerForm = new Owner();
                    ownerForm.Show();
                    this.Hide();
                    return;
                }
                else
                {
                    loginAttempts++;
                    MessageBox.Show($"Incorrect password. Attempt {loginAttempts} of 3.");
                }

            }
        }

    }
}