using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class returnString
    {
        public StringBuilder morphology;

        public returnString()
        {
            morphology = new StringBuilder();
        }

        public void append(string str)
        {
            this.morphology.Append(str);
        }

        public override string ToString()
        {
            return morphology.ToString();
        }
    }
}
