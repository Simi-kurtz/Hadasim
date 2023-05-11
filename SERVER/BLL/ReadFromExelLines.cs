using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    class ReadFromExelLines
    {
        public ReadFromExelLines(string path)
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
                                        headLine.SOMEPOINTS = int.Parse(values[j + 1]);
                                        heartLine.SOMEPOINTS = int.Parse(values[j]);
                                        break;
                                    }

                                case 2:
                                    {
                                        LifeLine.LOSTOFPOINTS = int.Parse(values[j + 2]);
                                        break;
                                    }
                                case 3:
                                    {
                                        LifeLine.LONG = int.Parse(values[j + 2]);
                                        break;
                                    }
                                case 4:
                                    {
                                        heartLine.SHORT = int.Parse(values[j]);
                                        break;
                                    }
                                case 5:
                                    {
                                        headLine.HIGH = int.Parse(values[j + 1]);
                                        break;
                                    }
                                case 6:
                                    {
                                        headLine.LOW = int.Parse(values[j + 1]);
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
