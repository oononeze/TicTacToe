using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Controls
{
    public class X : XandOBase
    {
        Path ex = new Path();
        PathFigure pf = new PathFigure();
        PathGeometry pg = new PathGeometry();

        public X()
        {
            Draw();
            Content = ex;
            ex.Height = 50;
            ex.Width = 50;
            Identifier = "X";

        }
        public override void Draw()
        {
            //21.05
            Point point1 = new Point(0,0);
            Point point2 = new Point(25,25);
            Point point3 = new Point(50,0);
            Point point4 = new Point(25,25);
            Point point5 = new Point(50,50);
            Point point6 = new Point(25,25);
            Point point7 = new Point(0,50);

            LineSegment line1 = new LineSegment(point2, true);
            LineSegment line2 = new LineSegment(point3, true);
            LineSegment line3 = new LineSegment(point4, true);
            LineSegment line4 = new LineSegment(point5, true);
            LineSegment line5 = new LineSegment(point6, true);
            LineSegment line6 = new LineSegment(point7, true);

            pf.StartPoint = point1;
            pf.Segments.Add(line1);
            pf.Segments.Add(line2);
            pf.Segments.Add(line3);
            pf.Segments.Add(line4);
            pf.Segments.Add(line5);
            pf.Segments.Add(line6);

            pg.Figures.Add(pf);
            ex.Data = pg;
            ex.StrokeThickness = 1;
            ex.Stroke = Brushes.White;

        }
    }
}
