using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Controls
{
   public class O : XandOBase
    {
        Ellipse circle = new Ellipse();

        public O()
        {
            Draw();
            Content = circle;
            Height = 50;
            Width = 50;
            Identifier = "O";
        }

        public override void Draw()
        {
            circle.Height = 50;
            circle.Width = 50;
            circle.StrokeThickness = 1;
            circle.Stroke = Brushes.White;
        }
    }
}
