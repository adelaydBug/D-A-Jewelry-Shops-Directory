namespace dsa_GRAPH.JewelryShop
{
    partial class Customer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label4 = new Label();
            comboBox2 = new ComboBox();
            label3 = new Label();
            pictureBox1 = new PictureBox();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(437, 74);
            label1.Name = "label1";
            label1.Size = new Size(1008, 134);
            label1.TabIndex = 1;
            label1.Text = "Customer Location";
            label1.Click += label1_Click;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bracelet", "Brooches", "Earrings", "Hairclip", "Necklace", "Piercing", "Ring" });
            comboBox1.Location = new Point(996, 572);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(373, 45);
            comboBox1.TabIndex = 4;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(514, 555);
            label2.Name = "label2";
            label2.Size = new Size(502, 67);
            label2.TabIndex = 3;
            label2.Text = "Select Product     : ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(996, 684);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 42);
            textBox1.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(514, 667);
            label4.Name = "label4";
            label4.Size = new Size(505, 67);
            label4.TabIndex = 8;
            label4.Text = "Enter your name : ";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Bakery", "Bank", "Block 1", "Block 2", "Block 3", "Cafe", "Church", "Del's Jewelry Shop", "Don's Jewelry Shop", "Great House", "Grocery", "Leyd's Jewelry Shop", "Nex's Jewelry Shop", "Ray's Jewelry Shop", "Ver's Jewelry Shop" });
            comboBox2.Location = new Point(996, 792);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(373, 45);
            comboBox2.TabIndex = 11;
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(514, 776);
            label3.Name = "label3";
            label3.Size = new Size(508, 67);
            label3.TabIndex = 10;
            label3.Text = "Select Location    : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Copilot_20251208_122749;
            pictureBox1.Location = new Point(-58, 114);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1999, 589);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 12;
            pictureBox1.TabStop = false;
            // 
            // addButton
            // 
            addButton.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(1059, 895);
            addButton.Name = "addButton";
            addButton.Size = new Size(231, 47);
            addButton.TabIndex = 13;
            addButton.Text = "SHOW MAP";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // Customer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 230, 232);
            ClientSize = new Size(1882, 953);
            Controls.Add(addButton);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Customer";
            Text = "Customer";
            Load += Customer_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private Label label4;
        private ComboBox comboBox2;
        private Label label3;
        private PictureBox pictureBox1;
        private Button addButton;
    }
}