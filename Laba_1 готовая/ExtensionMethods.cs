using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_1
{
    public static class ExtensionMethods
    {
        public static List<PointF[]> RemoveBreakPoints(this PointF[] points, double step)
        {
            List<PointF[]> result = new();
            List<PointF> temp = new();
            var newPoints = ((PointF[])points.Clone()).Where(p => p.Y is not float.NaN && p.Y > float.MinValue && p.Y < float.MaxValue).ToList();
            for (int i = 0; i < newPoints.Count - 1; i++)
            {
                if (Math.Abs(newPoints[i].X - newPoints[i + 1].X) <= 2 * step)
                {
                    temp.Add(newPoints[i]);
                    continue;
                }

                result.Add(temp.ToArray());
                temp = new();
            }

            result.Add(temp.ToArray());
            return result.Where(x => x.Length > 1).ToList();
        }

        public static PointF[] Normalize(this PointF[] points, Size size)
        {
            var xScale = size.Width / points.Max(p => Math.Abs(p.X)) / 2;
            var yScale = size.Height / points.Max(p => Math.Abs(p.Y)) / 2;
            return points.Select(p => new PointF(p.X * xScale + size.Width / 2, size.Height / 2 - (p.Y * yScale))).ToArray();
        }
    }
}
