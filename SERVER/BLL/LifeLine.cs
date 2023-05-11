using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace BLL
{
    class LifeLine : Line
    {

        public static int LONG;
        public static int LOSTOFPOINTS;
        public Point firstheight;
        public Point lastheight;
        public Point firstwidth;
        public Point lastwidth;

        public LifeLine(List<Point> list, Point firstheight, Point lastheight, Point firstwidth, Point lastwidth) : base(list, firstheight, lastheight, firstwidth, lastwidth)
        {
            this.firstheight = firstheight;
            this.lastheight = lastheight;
            this.firstwidth = firstwidth;
            this.lastwidth = lastheight;
        }

        public LifeLine() : base() { }

        //איזה קו חיים יש לי??????
        public string morphlogy(List<Point> life)
        {

            string morphlogy = " ";
            Boolean flag = false;

            int diff_h = firstheight.y - lastheight.y;
            int diff_w = firstheight.x - lastheight.x;

            if (life.Count < LOSTOFPOINTS) //בקו יש הרבה נקודות
            {
                if (diff_w < LONG)  // וגם הרוחב גדול
                {
                    morphlogy = bigLifeLine();  //קו חיים גדול
                    flag = true;
                }
                else
                {
                    morphlogy = wideLifeLine();  // קו חיים  רחב
                    flag = true;
                }
            }

            else
            {
                morphlogy = smallLifeLine();  //קו חיים פרוץ
                flag = true;
            }
            if (flag != true)
                morphlogy = " ";
            return morphlogy;
        }

        public string wideLifeLine()
        {
            return ReadFromExelMorpho.wideLifeLine;
        }

        public string bigLifeLine()
        {
            return ReadFromExelMorpho.bigLifeLine;
        }

        public string smallLifeLine()
        {
            return ReadFromExelMorpho.smallLifeLine;
        }
    }
}
