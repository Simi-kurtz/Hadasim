using BLL;
using System;
using System.Collections.Generic;
using System.Drawing;

namespace BLL
{
    class headLine : Line
    {
        public static int SOMEPOINTS;
        public static int HIGH;
        public static int LOW;
        public Point firstheight;
        public Point lastheight;
        public Point firstwidth;
        public Point lastwidth;

        public headLine(List<Point> list, Point firstheight, Point lastheight, Point firstwidth, Point lastwidth) : base(list, firstheight, lastheight, firstwidth, lastwidth)
        {
            this.firstheight = firstheight;
            this.lastheight = lastheight;
            this.firstwidth = firstwidth;
            this.lastwidth = lastheight;
        }

        public headLine() { }

        //איזה קו ראש יש לי??????
        public string morphlogy(List<Point> head)
        {
            string morphlogy = " ";
            Boolean flag = false;

            int diff_h = firstheight.y - lastheight.y;
            int diff_w = firstheight.x - lastheight.x;

            if (head.Count < SOMEPOINTS) //בקו יש קצת נקודות
            {
                morphlogy = shortHeadLine();  //קו ראש קצר
                flag = true;
            }
            else if (imgProcessing.isStraightLine(head) == true)
            {
                morphlogy = wideHeadLine();  //קו ראש רחב
                flag = true;
            }
            else if (firstheight.y > HIGH && lastheight.y > HIGH) // ההתחלה של הקו נמצא בגובה וגם הסוף
            {
                morphlogy = highHeadLine();  //קו ראש גבוה 
                flag = true;
            }
            else if (firstheight.y < LOW && lastheight.y < LOW) //ההתחלה של הקו נמצא נמוך וגם סוף הקו
            {
                morphlogy = ArcHeadLine(); //קו ראש נמוך
                flag = true;
            }
            else if (imgProcessing.isStraightLine(head) == true) //קו הראש ישר
            {
                if (lastheight.y < LOW)
                {
                    morphlogy = straightHeadLineWithLargeSlope(); //קו ראש ארוך עם שיפוע גדול
                    flag = true;
                }
                else
                {
                    morphlogy = straightHeadLineWithSmallSlope(); //קו ראש ארוך שנגמר קטן
                    flag = true;
                }

            }
            else if (firstheight.y > HIGH)
            {
                morphlogy = arcHeadLineInclinedUpwards(); //קו ראש נוטה כלפי מעלה
                flag = true;
            }
            if (flag != true)
                morphlogy = " ";
            return morphlogy;
        }

        public string wideHeadLine() //קו ראש רחב
        {
            return ReadFromExelMorpho.wideHeadLine;
            //return "צורך בהשקעת מאמץ יתר בתהליך שכלי " +
            //    ". כלומר, תהליכי הקליטה, העיבוד ויישום האינפורמציה הופכים לאיטיים משהו.";
        }

        public string shortHeadLine()  //קו ראש קצר
        {
            return ReadFromExelMorpho.shortHeadLine;
        }

        public string closeToTheLifeLineHeadLine()//קו ראש שצמוד לקו החיים
        {
            return ReadFromExelMorpho.closeToTheLifeLineHeadLine;
        }
        public string lowHeadLine()//קו ראש נמוך
        {
            return ReadFromExelMorpho.lowHeadLine;
        }

        public string highHeadLine()//קו ראש גבוה
        {
            return ReadFromExelMorpho.highHeadLine;
        }

        public string straightHeadLineWithSmallSlope()//קו ראש עם שיפוע קטן
        {
            return ReadFromExelMorpho.straightHeadLineWithSmallSlope;
        }

        public string straightHeadLineWithLargeSlope()//קו ראש עם שיפוע גדול
        {
            return ReadFromExelMorpho.straightHeadLineWithLargeSlope;
        }

        public string arcHeadLineInclinedUpwards()//קו ראש קשתי נוטה כלפי מעלה
        {
            return ReadFromExelMorpho.arcHeadLineInclinedUpwards;
        }


        public string longArcHeadLine() //קו ראש קשתי ארוך
        {
            return ReadFromExelMorpho.longArcHeadLine;
        }
        public string ArcHeadLine() //קו ראש קשתי נמוך
        {
            return ReadFromExelMorpho.ArcHeadLine;
        }
    }
}
