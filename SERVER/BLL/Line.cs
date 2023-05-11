
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class Line
    {
        public Line(List<Point> list, Point firstheight1, Point lastheight1, Point firstwidth1, Point lastwidth1)
        {
        }

        public Line()
        { }
        public List<Point> list { get; set; }
        public Point firstheight { get; set; }
        public Point lastheight { get; set; }
        public Point firstwidth { get; set; }
        public Point lastwidth { get; set; }
    }
}