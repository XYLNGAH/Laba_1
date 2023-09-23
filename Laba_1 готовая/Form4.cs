using System.Data;

namespace Laba_1;

public partial class Form4 : Form
{
    private Size _prevSize;
    public Form4()
    {
        InitializeComponent();
        pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (!TryParseData(out var data))
        {
            MessageBox.Show("invalid input");
            return;
        }

        var points = CalculatePoints(data)
            .RemoveBreakPoints(data.step)
            .Select(x => x.Normalize(pictureBox1.Image.Size))
            .ToList();
        if (sender is Size)
        {
            var size = (Size)sender;
            pictureBox1.Size = size;
            pictureBox1.Image = new Bitmap(size.Width, size.Height);
        }

        var bitmap = (Bitmap)pictureBox1.Image;
        Draw(bitmap, points);
        pictureBox1.Image = bitmap;

    }
    private bool TryParseData(out (double a, double xmin, double xmax, double step) result)
    {
        result = default;
        if (!double.TryParse(TextBoxA.Text.Trim(), out var a) ||
            !double.TryParse(TextBoxXmin.Text.Trim(), out var xmin) ||
            !double.TryParse(TextBoxXmax.Text.Trim(), out var xmax) ||
            !double.TryParse(TextBoxH.Text.Trim(), out var step))
        {
            return false;
        }

        result = (a, xmin, xmax, step);
        return true;
    }

    private PointF[] CalculatePoints((double a, double xmin, double xmax, double step) data) =>
        Enumerable.Range(0, (int)Math.Ceiling((data.xmax - data.xmin) / data.step))
                  .Select(i => data.xmin + i * data.step)
                  .Select(x => new PointF((float)x, (float)F6(data.a, x)))
                  .ToArray();

    private static double F(double a, double x) => (Math.Sin(a * x) + a * Math.Pow(Math.Cos(x), 2)) / 45;//TODO: use parser

    private static double F6(double a, double x) => a * (Math.Exp(-4 * x) + Math.Log(x + 50) + Math.Sqrt(Math.Pow(x + 70, 5)));

    private static double F8(double a, double x) => a * (Math.Tan(x) + Math.Log(Math.Sin(x)) + Math.Log(Math.Tan(x)) + Math.Pow(a, 2));

    private void Draw(Bitmap bitmap, List<PointF[]> points)
    {
        Pen pen = new(Color.Black);
        Pen pen1 = new(Color.Green, 3);
        using var graphics = Graphics.FromImage(bitmap);
        graphics.Clear(Color.White);
        DrawAxes(pen, graphics);
        points.ForEach(p => graphics.DrawCurve(pen1, p));
    }

    private void DrawAxes(Pen pen, Graphics graphics)
    {
        var width = pictureBox1.Width;
        var height = pictureBox1.Height;
        var arrowWidth = 10;
        var arrowHeight = 3;
        graphics.DrawLine(pen, new(0, height / 2), new(width, height / 2));
        graphics.DrawLine(pen, new(width / 2, 0), new(width / 2, height));
        graphics.DrawLine(pen, new(width, height / 2), new(width - arrowWidth, height / 2 - arrowHeight));
        graphics.DrawLine(pen, new(width, height / 2), new(width - arrowWidth, height / 2 + arrowHeight));
        graphics.DrawLine(pen, new(width / 2, 0), new(width / 2 - arrowHeight, arrowWidth));
        graphics.DrawLine(pen, new(width / 2, 0), new(width / 2 + arrowHeight, arrowWidth));
    }

    public void Form4_ResizeEnd(object sender, EventArgs e) => button1_Click(pictureBox1.Size, e);
}
