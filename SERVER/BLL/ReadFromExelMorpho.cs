using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class ReadFromExelMorpho
    {
        public static string wideHeadLine;
        public static string shortHeadLine;
        public static string closeToTheLifeLineHeadLine;
        public static string lowHeadLine;
        public static string highHeadLine;
        public static string straightHeadLineWithSmallSlope;
        public static string straightHeadLineWithLargeSlope;
        public static string arcHeadLineInclinedUpwards;
        public static string longArcHeadLine;
        public static string ArcHeadLine;
        public static string inclinedUpwardsHeartLine;
        public static string bigHeartLine;
        public static string smallHeartLine;
        public static string wideLifeLine;
        public static string bigLifeLine;
        public static string smallLifeLine;

        public ReadFromExelMorpho(string path)
        {

            bool possiblePath = path.IndexOfAny(Path.GetInvalidPathChars()) == -1;
            if (possiblePath != false)
            {
                using (var reader = new StreamReader(path, Encoding.UTF8))
                {
                    for (int i = 0; !reader.EndOfStream; i++)
                    {
                        var line = Convert.ToString(reader.ReadLine());
                        var values = line.Split(',');
                        if (i == 0)
                        {

                        }
                        else
                        {
                            int j = 1;
                            switch (i)
                            {
                                case 1:
                                    {
                                        bigHeartLine = values[j];
                                        Console.WriteLine(bigHeartLine.ToString());
                                        bigLifeLine = values[j + 2];
                                        Console.WriteLine(bigLifeLine.ToString());
                                        break;
                                    }

                                case 2:
                                    {
                                        smallHeartLine = values[j];
                                        Console.WriteLine(smallHeartLine.ToString());
                                        smallLifeLine = values[j + 2];
                                        Console.WriteLine(smallLifeLine.ToString());
                                        break;
                                    }
                                case 3:
                                    {

                                        break;
                                    }
                                case 4:
                                    {
                                        shortHeadLine = values[j + 1];
                                        Console.WriteLine(shortHeadLine.ToString());
                                        break;
                                    }
                                case 5:
                                    {
                                        wideHeadLine = values[j + 1];
                                        Console.WriteLine(wideHeadLine.ToString());
                                        wideLifeLine = values[j + 2];
                                        Console.WriteLine(wideLifeLine.ToString());
                                        break;
                                    }
                                case 6:
                                    {
                                        arcHeadLineInclinedUpwards = values[j];
                                        Console.WriteLine(arcHeadLineInclinedUpwards.ToString());
                                        inclinedUpwardsHeartLine = values[j];
                                        Console.WriteLine(inclinedUpwardsHeartLine.ToString());
                                        break;
                                    }
                                case 7:
                                    {
                                        lowHeadLine = values[j + 1];
                                        Console.WriteLine(lowHeadLine.ToString());
                                        break;
                                    }
                                case 8:
                                    {
                                        highHeadLine = values[j + 1];
                                        Console.WriteLine(highHeadLine);
                                        break;
                                    }
                                case 9:
                                    {
                                        straightHeadLineWithSmallSlope = values[j + 1];
                                        Console.WriteLine(straightHeadLineWithSmallSlope.ToString());
                                        break;
                                    }
                                case 10:
                                    {
                                        straightHeadLineWithLargeSlope = values[j + 1];
                                        Console.WriteLine(straightHeadLineWithLargeSlope.ToString());
                                        break;
                                    }
                                case 11:
                                    {
                                        closeToTheLifeLineHeadLine = values[j + 1];
                                        Console.WriteLine(closeToTheLifeLineHeadLine.ToString());
                                        break;
                                    }
                                case 12:
                                    {
                                        longArcHeadLine = values[j + 1];
                                        Console.WriteLine(longArcHeadLine.ToString());
                                        break;
                                    }
                                case 13:
                                    {
                                        ArcHeadLine = values[j + 1];
                                        Console.WriteLine(ArcHeadLine.ToString());
                                        break;
                                    }
                            }

                        }
                    }
                }
            }
        }
    }
}
