using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace html_generator
{
    static public class Generator
    {
        static public string HandleParargaphs(string input)
        {
            var regex = new Regex(@"(?<=^|(?:\r\n *){2})(.+?)(?=$|(?:\r\n *))");
            var replacement = @"<p>$1</p>";
            return regex.Replace(input, replacement);
        }
        static public string HandleEms(string input)
        {
            var regex = new Regex(@"(?<=[^\\]_)(.+?)(?=[^\\]_)");
            var replacement = @"<em>$1</em>";
            return regex.Replace(input, replacement);
        }
        static public string GenerateHTML(string input)
        {
            if (input == null)
                return input;
            string output = HandleParargaphs(input);
            output = HandleEms(output);
            return output;
        }
    }
}
