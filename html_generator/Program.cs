using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace html_generator
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = File.ReadAllText(args[0]);
            string output = Generator.GenerateHTML(input);
            File.WriteAllText(args[1], output);
        }
    }
}
