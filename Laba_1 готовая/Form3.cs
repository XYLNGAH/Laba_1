namespace Laba_1
{
    public partial class Form3 : Form
    {
        private readonly int LENGTH = 100;
        private readonly double ANGLE_STEP = 10;
        private readonly int OFFSET_STEP = 5;
        private double _angle = 0.0;
        private Point _offset = new Point(0, 0);
        private bool _enabled = false;
        public Form3()
        {
            InitializeComponent();
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            timer1.Interval = 25;
            timer1.Start();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            if (!_enabled)
            {
                return;
            }

            var bitmap = (Bitmap)pictureBox1.Image;
            Draw(bitmap);
            pictureBox1.Image = bitmap;
        }

        private void Draw(Bitmap bitmap)
        {
            var start = new PointF(pictureBox1.Width / 2 + _offset.X, pictureBox1.Height / 2 + _offset.Y);
            var from = new PointF((float)(start.X + LENGTH * Math.Sin(_angle)), (float)(start.Y + LENGTH * Math.Cos(_angle)));
            var to = new PointF((float)(start.X - LENGTH * Math.Sin(_angle)), (float)(start.Y - LENGTH * Math.Cos(_angle)));
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
                graphics.DrawLine(new Pen(Color.Blue, 3), from, to);
            }
        }

        private void Form3_KeyDown(object sender, KeyEventArgs e)
        {
            var keys = new string[] { "I", "J", "K", "L", "A" };
            var key = e.KeyCode.ToString();
            if (!e.Alt || !keys.Contains(key))
            {
                return;
            }

            switch (key)
            {
                case "I":
                    _offset.Y -= OFFSET_STEP;
                    break;
                case "J":
                    _offset.X -= OFFSET_STEP;
                    break;
                case "K":
                    _offset.Y += OFFSET_STEP;
                    break;
                case "L":
                    _offset.X += OFFSET_STEP;
                    break;
                case "A":
                    Clear();
                    return;
            }

            Form3_Load(sender, e);
        }
        private void Clear()
        {
            var bitmap = (Bitmap)pictureBox1.Image;
            using (var graphics = Graphics.FromImage(bitmap))
            {
                graphics.Clear(Color.White);
            }

            pictureBox1.Image = bitmap;
            _enabled = false;
        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _enabled = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            _angle -= ANGLE_STEP;
            Form3_Load(sender, e);
        }

        private void Form3_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
