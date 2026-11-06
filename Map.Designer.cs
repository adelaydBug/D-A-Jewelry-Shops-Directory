using System.Drawing;
using System.Windows.Forms;

namespace dsa_GRAPH.JewelryShop
{
    partial class Map
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        // Controls
        private PictureBox pictureBox1;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Donex_Jewelry_Shop;
            pictureBox1.Location = new Point(14, 16);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(869, 667);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Impact", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(17, 651);
            label1.Name = "label1";
            label1.Size = new Size(206, 29);
            label1.TabIndex = 1;
            label1.Text = "AVAILABLE SHOPS : ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label3.Location = new Point(20, 682);
            label3.Name = "label3";
            label3.Size = new Size(71, 28);
            label3.TabIndex = 2;
            label3.Text = "Label3";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label4.Location = new Point(20, 712);
            label4.Name = "label4";
            label4.Size = new Size(72, 28);
            label4.TabIndex = 3;
            label4.Text = "Label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label5.Location = new Point(20, 742);
            label5.Name = "label5";
            label5.Size = new Size(71, 28);
            label5.TabIndex = 4;
            label5.Text = "Label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.2000008F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.LimeGreen;
            label6.Location = new Point(24, 785);
            label6.Name = "label6";
            label6.Size = new Size(86, 31);
            label6.TabIndex = 5;
            label6.Text = "Label6";
            // 
            // Map
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(896, 855);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Map";
            Text = "Map";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}
