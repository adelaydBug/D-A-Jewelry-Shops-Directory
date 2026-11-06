using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;

namespace dsa_GRAPH.JewelryShop
{
    public partial class Map : Form
    {
        private readonly string selectedProduct;
        private readonly string selectedLocation;

        private class Shop
        {
            public string Name { get; set; } = string.Empty;
            public Point Coordinates { get; set; }
            public List<string> Products { get; set; } = new List<string>();
        }

        private List<Shop> shops = new List<Shop>();
        private Dictionary<string, Point> locationCoordinates = new Dictionary<string, Point>();
        private List<Shop> top3ForDrawing = new List<Shop>();

        private Point userLocationImg;

        private const double PixelToMeters = 0.10;

        public Map(string product, string location)
        {
            selectedProduct = product;
            selectedLocation = location;
            InitializeComponent();
            Load += Map_Load;
            pictureBox1.Paint += PictureBox1_Paint;
            InitializeData();
        }

        private void InitializeData()
        {
            shops = new List<Shop>
            {
                new Shop { Name = "Don's Jewelry Shop", Coordinates = new Point(130, 110), Products = new List<string>{ "Ring", "Brooch", "Necklace" } },
                new Shop { Name = "Del's Jewelry Shop", Coordinates = new Point(1120, 140), Products = new List<string>{ "Necklace", "Brooch" } },
                new Shop { Name = "Nex's Jewelry Shop", Coordinates = new Point(350, 430), Products = new List<string>{ "Ring", "Bracelet" } },
                new Shop { Name = "Leyd's Jewelry Shop", Coordinates = new Point(900, 530), Products = new List<string>{ "Piercing", "Hairclip" } },
                new Shop { Name = "Ray's Jewelry Shop", Coordinates = new Point(170, 720), Products = new List<string>{ "Earrings", "Ring" } },
                new Shop { Name = "Ver's Jewelry Shop", Coordinates = new Point(1030, 740), Products = new List<string>{ "Hairclip", "Piercing" } }
            };

            locationCoordinates = new Dictionary<string, Point>
            {
                { "Church", new Point(700, 180) },
                { "Bank", new Point(160, 350) },
                { "Cafe", new Point(400, 720) },
                { "Bakery", new Point(270, 100) },
                { "Grocery", new Point(600, 740) },
                { "Great House", new Point(1120, 760) },
                { "Town Hall", new Point(570, 420) },
                { "Clinic", new Point(130, 460) },
                { "Market", new Point(470, 100) },
                { "Plaza", new Point(300, 70) },
                { "School", new Point(520, 90) },
                { "Park", new Point(550, 500) },
                { "Block 1", new Point(630, 480) },
                { "Block 2", new Point(710, 480) },
                { "Block 3", new Point(790, 480) }
            };
        }

        private void Map_Load(object? sender, EventArgs e)
        {
            ComputeResults();
            UpdateLabels();
            pictureBox1.Invalidate();
        }

        private void ComputeResults()
        {
            top3ForDrawing.Clear();

            if (!locationCoordinates.ContainsKey(selectedLocation))
                return;

            userLocationImg = locationCoordinates[selectedLocation];

            var candidates = string.IsNullOrWhiteSpace(selectedProduct)
                ? shops
                : shops.Where(s => s.Products.Contains(selectedProduct)).ToList();

            if (candidates.Count < 3)
            {
                candidates.AddRange(
                    shops.Except(candidates)
                    .OrderBy(s => EuclideanDistance(userLocationImg, s.Coordinates))
                    .Take(3 - candidates.Count));
            }

            top3ForDrawing = candidates
                .OrderBy(s => EuclideanDistance(userLocationImg, s.Coordinates))
                .Take(3)
                .ToList();
        }

        private void UpdateLabels()
        {
            if (top3ForDrawing.Count >= 3)
            {
                double dist0 = EuclideanDistance(userLocationImg, top3ForDrawing[0].Coordinates) * PixelToMeters;
                double dist1 = EuclideanDistance(userLocationImg, top3ForDrawing[1].Coordinates) * PixelToMeters;
                double dist2 = EuclideanDistance(userLocationImg, top3ForDrawing[2].Coordinates) * PixelToMeters;

                label3.Text = $"{top3ForDrawing[0].Name} ({dist0:F1} m)";
                label4.Text = $"{top3ForDrawing[1].Name} ({dist1:F1} m)";
                label5.Text = $"{top3ForDrawing[2].Name} ({dist2:F1} m)";
                label6.Text = $"Nearest: {top3ForDrawing[0].Name} ({dist0:F1} m)";
                label6.ForeColor = Color.Green;
            }
            else
            {
                label3.Text = "N/A";
                label4.Text = "N/A";
                label5.Text = "N/A";
                label6.Text = "Nearest: N/A";
            }
        }


        private void PictureBox1_Paint(object? sender, PaintEventArgs e)
        {
            if (pictureBox1.Image == null) return;

            Rectangle dest = GetImageDisplayRectangle(pictureBox1);

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

            using Pen nearestPen = new Pen(Color.Red, 4) { DashStyle = DashStyle.Solid };
            using Pen otherPen = new Pen(Color.Green, 3) { DashStyle = DashStyle.Solid };

            if (top3ForDrawing.Count == 0) return;

            PointF userPx = MapToPictureBox(userLocationImg, pictureBox1.Image.Size, dest);

            Shop nearest = top3ForDrawing.First();

            foreach (var shop in top3ForDrawing)
            {
                PointF shopPx = MapToPictureBox(shop.Coordinates, pictureBox1.Image.Size, dest);

                Pen pen = (shop == nearest) ? nearestPen : otherPen;

                e.Graphics.DrawLine(pen, userPx, shopPx);
                e.Graphics.FillEllipse(Brushes.Blue, shopPx.X - 6, shopPx.Y - 6, 12, 12);
            }

            e.Graphics.FillEllipse(Brushes.OrangeRed, userPx.X - 8, userPx.Y - 8, 16, 16);
        }

        private static PointF MapToPictureBox(Point raw, Size imageSize, Rectangle rect)
        {
            float sx = (float)rect.Width / imageSize.Width;
            float sy = (float)rect.Height / imageSize.Height;

            float x = rect.X + raw.X * sx;
            float y = rect.Y + raw.Y * sy;

            return new PointF(x, y);
        }

        private static Rectangle GetImageDisplayRectangle(PictureBox pb)
        {
            Size img = pb.Image.Size;
            Size box = pb.ClientSize;

            float rImg = (float)img.Width / img.Height;
            float rBox = (float)box.Width / box.Height;

            int w, h;

            if (rImg > rBox)
            {
                w = box.Width;
                h = (int)(box.Width / rImg);
            }
            else
            {
                h = box.Height;
                w = (int)(box.Height * rImg);
            }

            int x = (box.Width - w) / 2;
            int y = (box.Height - h) / 2;

            return new Rectangle(x, y, w, h);
        }

        private static double EuclideanDistance(Point a, Point b)
        {
            double dx = b.X - a.X;
            double dy = b.Y - a.Y;
            return Math.Sqrt(dx * dx + dy * dy);
        }

        private void label3_Click(object sender, EventArgs e) { }
        private void pictureBox1_Click(object sender, EventArgs e) { }
    }
}
