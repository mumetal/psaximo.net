using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Psaximo.Net.Document.Extraction
{
    public class XimFile 
    {

        public XimFile() {

            string @value;
            (var val,var un ,var i) = getData(2);
            int number = 123_456_789;
            WriteLine();
            
        }



        (string name, int age, string dob) getData(int id) {
            string val1 = "john";  int val2 = 8; string val3 = "august29";
           
            return (val1, val2, val3);

        }
    }
}
