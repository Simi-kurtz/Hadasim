using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class heartLine : Line
    {
        public static int SOMEPOINTS;
        public static int SHORT;
        public static string morph;
        public Point firstheight;
        public Point lastheight;
        public Point firstwidth;
        public Point lastwidth;

        public heartLine(List<Point> list, Point firstheight, Point lastheight, Point firstwidth, Point lastwidth) : base(list, firstheight, lastheight, firstwidth, lastwidth)
        {
            this.firstheight = firstheight;
            this.lastheight = lastheight;
            this.firstwidth = firstwidth;
            this.lastwidth = lastheight;
        }

        public heartLine() { }



        //איזה קו לב יש לי??????
        public string morphlogy(List<Point> heart)
        {

            string morphlogy = " ";
            Boolean flag = false;

            int diff_h = firstheight.y - lastheight.y;
            int diff_w = firstheight.x - lastheight.x;

            if (heart.Count < SOMEPOINTS) //בקו יש קצת נקודות
            {
                morphlogy = smallHeartLine();  //קו לב קצר
                flag = true;
            }
            else if (diff_h < SHORT) // הרבה נקודות וגובה קטן
            {
                morphlogy = bigHeartLine();  //קו לב ארוך
                flag = true;
            }
            else
            {
                morphlogy = inclinedUpwardsHeartLine(); //קו לב נוטה כלפי מעלה
                flag = true;
            }
            if (flag != true)
                morphlogy = "not found heart line! ";
            return morphlogy;
        }

        public string inclinedUpwardsHeartLine()
        {
            return ReadFromExelMorpho.inclinedUpwardsHeartLine;
        }

        public string bigHeartLine()
        {
            return ReadFromExelMorpho.bigHeartLine;
        }

        public string smallHeartLine()
        {
            return ReadFromExelMorpho.smallHeartLine;
        }

    }
}
