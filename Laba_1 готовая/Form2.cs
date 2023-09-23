using System.Drawing.Drawing2D;

namespace Laba_1
{
    public partial class Form2 : Form
    {
        public string text;
        public Form2()
        {
            InitializeComponent();
            text = "Планка 1";
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            // Текст
            g.DrawString(text, new Font("Helvetica", 15), Brushes.Black, 0, 0);
            //------------------------------------------------------------------

            // Пунктирная линия
            float[] dashValues = { 16, 4, 6, 4 };
            Pen dashPen = new Pen(Color.Black, 2);
            dashPen.DashPattern = dashValues;
            g.DrawLine(dashPen, 305, 20, 305, 110);
            //---------------------------------------------------------------

            // Сплайн левый
            Pen myPen = new Pen(Color.Black, 1);
            PointF startPt = new PointF(230, 30);
            PointF control1Pt = new PointF(235, 50);
            PointF control2Pt = new PointF(230, 70);
            PointF control3Pt = new PointF(235, 90);
            PointF endPt = new PointF(230, 100);
            PointF[] myBezierPoints =
            {
                startPt, control1Pt, control2Pt,control3Pt,  endPt
            };
            //-----------------------------------------------------

            //Сплайн правый
            Pen myPen1 = new Pen(Color.Black, 1);
            PointF startPtp = new PointF(265, 100);
            PointF control1Ptp = new PointF(270, 80);
            PointF control2Ptp = new PointF(260, 60);
            PointF control3Ptp = new PointF(265, 40);
            PointF endPtp = new PointF(265, 30);
            PointF[] myBezierPointsp =
            {
                startPtp, control1Ptp, control2Ptp,control3Ptp,  endPtp
            };
            //---------------------------------------------------------

            // Кисть для штриховки
            HatchBrush myHatchBrush = new HatchBrush(HatchStyle.BackwardDiagonal, Color.Black, Color.White);
            //----------------------------------------------------------

            //Заполнение штировкой левого и правого прямоугольника
            g.FillRectangle(myHatchBrush, 10, 30, 30, 70);
            g.DrawLine(new Pen(Brushes.Black, 1), 40, 30, 40, 100);
            g.FillRectangle(myHatchBrush, 330, 30, 30, 70);
            //--------------------------------------------------------

            // Создание сплайнов
            GraphicsPath path = new GraphicsPath();
            path.AddLine(230, 30, 265, 30);
            path.AddCurve(myBezierPoints);
            path.AddCurve(myBezierPointsp);
            //-----------------------------------------------------

            // Штриховка возле сплайнов
            g.FillRectangle(myHatchBrush, 220, 30, 60, 70);
            g.DrawPath(new Pen(Brushes.Black, 3), path);
            g.FillPath(Brushes.White, path);
            //-----------------------------------------------------

            // Обводка
            g.DrawRectangle(new Pen(Brushes.Black, 3), 10, 30, 350, 70);
            g.DrawLine(new Pen(Brushes.Black, 3), 220, 30, 220, 100);
            g.DrawLine(new Pen(Brushes.Black, 3), 280, 30, 280, 100);
            g.DrawLine(new Pen(Brushes.Black, 3), 330, 30, 330, 100);
            //-------------------------------------------------------

            // Внешняя обводка
            g.DrawArc(new Pen(Brushes.Black, 3), 265, 130, 95, 95, -90, 180);
            g.DrawLine(new Pen(Brushes.Black, 3), 10, 130, 313, 130);
            g.DrawLine(new Pen(Brushes.Black, 3), 10, 225, 313, 225);
            g.DrawLine(new Pen(Brushes.Black, 3), 10, 130, 10, 225);
            //----------------------------------------------------------------

            // Круг справа
            g.DrawEllipse(new Pen(Brushes.Black, 3), 280, 152, 50, 50);
            //----------------------------------------------------------------


            // Пунктирная линия
            float[] dashValues1 = { 30, 4, 5, 4 };
            Pen dashPen1 = new Pen(Color.Black, 2);
            dashPen1.DashPattern = dashValues1;
            g.DrawLine(dashPen1, 2, 177.5f, 370, 177.5f);
            //----------------------------------------------------------------

            // Вытянутый вырез
            g.DrawArc(new Pen(Brushes.Black, 3), 42, 152, 50, 50, 90, 180);
            g.DrawArc(new Pen(Brushes.Black, 3), 168, 152, 50, 50, -90, 180);
            g.DrawLine(new Pen(Brushes.Black, 3), 67, 152, 194, 152);
            g.DrawLine(new Pen(Brushes.Black, 3), 67, 202, 194, 202);
            //----------------------------------------------------------------

            // Тонкие линии
            g.DrawLine(new Pen(Brushes.Black, 2), 305, 122, 305, 235);
            g.DrawLine(new Pen(Brushes.Black, 2), 67, 122, 67, 235);
            g.DrawLine(new Pen(Brushes.Black, 2), 194, 122, 194, 235);
            //---------------------------------------------------------------

        }
    }
}
