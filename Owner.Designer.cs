namespace dsa_GRAPH.JewelryShop
{
    partial class Owner
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
            label2 = new Label();
            comboBox1 = new ComboBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            comboBox2 = new ComboBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            listBox1 = new ListBox();
            addButton = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 72F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(175, 88);
            label1.Name = "label1";
            label1.Size = new Size(1533, 134);
            label1.TabIndex = 0;
            label1.Text = "Owner's Product Information";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(812, 306);
            label2.Name = "label2";
            label2.Size = new Size(504, 67);
            label2.TabIndex = 1;
            label2.Text = "Select Category   : ";
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Bracelet", "Brooches", "Earrings", "Hairclip", "Necklace", "Piercing", "Ring" });
            comboBox1.Location = new Point(1294, 315);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(373, 45);
            comboBox1.TabIndex = 2;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Copilot_20251208_124959;
            pictureBox1.Location = new Point(71, 194);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(733, 591);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(812, 392);
            label3.Name = "label3";
            label3.Size = new Size(504, 67);
            label3.TabIndex = 4;
            label3.Text = "Select Branch      : ";
            // 
            // comboBox2
            // 
            comboBox2.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "Del's Jewelry Shop", "Don's Jewelry Shop", "Leyd's Jewelry Shop", "Nex's Jewelry Shop", "Ray's Jewelry Shop", "Ver's Jewelry Shop" });
            comboBox2.Location = new Point(1294, 400);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(373, 45);
            comboBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(812, 478);
            label4.Name = "label4";
            label4.Size = new Size(505, 67);
            label4.TabIndex = 6;
            label4.Text = "Enter your name : ";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(1294, 488);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(373, 42);
            textBox1.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 35F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(812, 564);
            label5.Name = "label5";
            label5.Size = new Size(393, 67);
            label5.TabIndex = 8;
            label5.Text = "Product List : ";
            label5.Click += label5_Click;
            // 
            // listBox1
            // 
            listBox1.Font = new Font("Times New Roman", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(1205, 573);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(477, 252);
            listBox1.TabIndex = 9;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // addButton
            // 
            addButton.BackColor = Color.Thistle;
            addButton.Font = new Font("Times New Roman", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addButton.Location = new Point(1368, 865);
            addButton.Name = "addButton";
            addButton.Size = new Size(151, 47);
            addButton.TabIndex = 10;
            addButton.Text = "ADD";
            addButton.UseVisualStyleBackColor = false;
            addButton.Click += addButton_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.home_removebg_preview;
            pictureBox2.Location = new Point(-8, 20);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(136, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Owner
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 230, 232);
            ClientSize = new Size(1882, 953);
            Controls.Add(label2);
            Controls.Add(pictureBox2);
            Controls.Add(addButton);
            Controls.Add(listBox1);
            Controls.Add(label5);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(comboBox2);
            Controls.Add(label3);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Owner";
            Text = "Owner";
            Load += Owner_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox comboBox1;
        private PictureBox pictureBox1;
        private Label label3;
        private ComboBox comboBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label5;
        private ListBox listBox1;
        private Button addButton;
        private PictureBox pictureBox2;
    }
}