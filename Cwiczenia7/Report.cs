using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cwiczenia7
{
    class Report : IGenerateHTML
    {
        public void GenerateHTML()
        {
            Console.WriteLine(ToHTMLString());
        }

        public string ToHTMLString()
        {
            return "<p>This is a placeholder for the report.</p>";
        }
    }
}
