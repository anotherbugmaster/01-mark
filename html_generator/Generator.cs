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
        static public string HandleStrongs(string input)
        {
            var regex = new Regex(@"(?<=[\n ^\>])__(.+?)__(?=[\r $\<])");
            var replacement = @"<strong>$1</strong>";
            return regex.Replace(input, replacement);
        }
        static public string HandleEms(string input)
        {
            var regex = new Regex(@"(?<=[\n ^\>])_(.+?)_(?=[\r $\<])");
            var replacement = @"<em>$1</em>";
            return regex.Replace(input, replacement);
        }

        static public string HandleScreening(string input)
        {
            var regex = new Regex(@"\\(.)");
            var replacement = @"$1";
            return regex.Replace(input, replacement);
        }
        static public string GenerateHTML(string input)
        {
            if (input == null)
                return input;
            string output = input;
            output = HandleParargaphs(output);
            output = HandleStrongs(output);
            output = HandleEms(output);
            output = HandleScreening(output);
            return output;
        }
    }
}
