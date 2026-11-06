namespace dsa_GRAPH.JewelryShop
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            title = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            owner = new Button();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // title
            // 
            title.AutoSize = true;
            title.Font = new Font("Edwardian Script ITC", 72F, FontStyle.Bold, GraphicsUnit.Point, 0);
            title.ForeColor = SystemColors.ControlDarkDark;
            title.Location = new Point(158, 68);
            title.Name = "title";
            title.Size = new Size(1665, 141);
            title.TabIndex = 0;
            title.Text = "Welcome to D8A Jewelry Shops Directory";
            title.Click += title_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 30F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDarkDark;
            label1.Location = new Point(143, 395);
            label1.Name = "label1";
            label1.Size = new Size(532, 60);
            label1.TabIndex = 1;
            label1.Text = "Select your option : ";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.ring_removebg_preview;
            pictureBox1.Location = new Point(59, 83);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(140, 112);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // owner
            // 
            owner.Font = new Font("Georgia", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            owner.ForeColor = SystemColors.ControlDarkDark;
            owner.Location = new Point(295, 521);
            owner.Name = "owner";
            owner.Size = new Size(341, 71);
            owner.TabIndex = 3;
            owner.Text = "I'M AN OWNER";
            owner.UseVisualStyleBackColor = true;
            owner.Click += owner_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.owner;
            pictureBox2.Location = new Point(144, 521);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(147, 71);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Georgia", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.ControlDarkDark;
            button1.Location = new Point(295, 660);
            button1.Name = "button1";
            button1.Size = new Size(341, 71);
            button1.TabIndex = 5;
            button1.Text = "I'M A CUSTOMER";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.customer;
            pictureBox3.Location = new Point(137, 655);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(156, 79);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Donex_Jewelry_Shop;
            pictureBox4.Location = new Point(564, 350);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(1396, 581);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 7;
            pictureBox4.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RosyBrown;
            label2.Location = new Point(873, 279);
            label2.Name = "label2";
            label2.Size = new Size(777, 68);
            label2.TabIndex = 8;
            label2.Text = "BARANGAY PARADA MAP";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 230, 232);
            ClientSize = new Size(1882, 953);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(owner);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Controls.Add(title);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox4);
            Name = "Main";
            Text = "Main";
            Load += Main_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label title;
        private Label label1;
        private PictureBox pictureBox1;
        private Button owner;
        private PictureBox pictureBox2;
        private Button button1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private Label label2;
    }
}
