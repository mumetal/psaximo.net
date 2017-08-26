using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psaximo.Net.Query.Parser
{
    internal abstract class QueryParser : IFormattable
    {
        protected QueryParser() {
        }

        //Base Class of all Parsers ..
        //this class simple checks if query contains and valid querysyntax as specified fy Analysis.SyntaxAnalyzer
        //A

        public string ToString(string format, IFormatProvider formatProvider) {
            throw new NotImplementedException();
        }

        public override string ToString() {
            return base.ToString();
        }
    }
}
