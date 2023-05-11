using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
//using Emgu.CV;
//using Emgu.CV.Structure;

namespace BLL
{
     class imgProcessing
    {
        //Color black = Color.FromArgb(0, 0, 0);
        public static List<Point> imgToList(Bitmap img)
        {
            int width = img.Width;
            int height = img.Height;
            List<Point> line = new List<Point>();
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    if (img.GetPixel(i, j) == Color.FromArgb(0, 0, 0))
                        line.Add(new Point(i, j));
                }
            }
            return line;
        }

        public static Point Max_width(List<Point> p)
        {
            Point pnewmax = new Point();
            int max = 0, index = 0;
            for (int i = 0; i < p.Count; i++)
            {
                if (max <= p[i].x)
                {
                    max = p[i].x;
                    index = i;
                }
            }

            pnewmax.x = max;
            pnewmax.y = p[index].y;
            return pnewmax;
        }
        // פונקצית מינימום
        //מקבלת את רשימת האינדקסים של האות ומחזירה את נקודת המינימום
        public static Point Max_height(List<Point> p)
        {
            Point pnewmax = new Point();
            int max = 0, index = 0;
            for (int i = 0; i < p.Count; i++)
            {
                if (max <= p[i].y)
                {
                    max = p[i].y;
                    index = i;
                }
            }
            pnewmax.y = max;
            pnewmax.x = p[index].x;

            return pnewmax;
        }
        //פונקצית מקסימום
        //מקבלת את רשימת האינדקסים של האות ומחזירה את נקודת המינימום
        public static Point Min_width(List<Point> p)
        {
            Point pnewmin = new Point();
            int min = p[0].x;
            int index = 0;
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].x < min)
                {
                    min = p[i].x;
                    index = i;
                }
            }
            pnewmin.x = min;
            pnewmin.y = p[index].y;
            return pnewmin;
        }
        //פונקצית מקסימום
        //מקבלת את רשימת האינדקסים של האות ומחזירה את נקודת המינימום
        public static Point Min_height(List<Point> p)
        {
            Point pnewmin = new Point();
            int min = p[0].y;
            int index = 0;
            for (int i = 0; i < p.Count; i++)
            {
                if (p[i].y < min)
                {
                    min = p[i].y;
                    index = i;
                }
            }
            pnewmin.y = min;
            pnewmin.x = p[index].x;
            return pnewmin;
        }

        public static void cleanPoints( List<Point> list)
        {
            Point p = new Point();
            for(int i = 0; i < list.Count; i++)
            {
               p.x =  list[i].x;
               p.y = list[i].y;
                if (!isneighbor(list[i], list))
                    list.RemoveAt(i);
            }
        }

        
        
        public static Boolean isneighbor(Point p , List<Point> list)
        {
            Boolean flag = false;
            for(int i = 0; i < list.Count ; i++)
            {
                if (isnear(list[i], p))
                    flag = true;
            }
            if(flag == true)
                return false;
            return true;
        }

        public static Boolean isnear(Point p, Point p2)
        {
            if (p.y == p2.y + 1 && p.y == p2.y - 1 && p.x == p2.x - 1 && p.x == p2.x + 1)
                return true;
            return false;
        }

        public static Boolean isStraightLine(List<Point> list)
        {
            
            int counter = 0;
            int sum = 0;
            int index = 0;
            int evg = 0;

            sum += list[index + 1].y - list[index].y;
            index++;

            while (list[index + 1] != null && index == 1)
            {
                sum += list[index + 1].y - list[index].y;
                counter++;
                index++;
            }
            evg = 12;
            if (evg > 12)
                return true;
            return false;
        }

    }
}
