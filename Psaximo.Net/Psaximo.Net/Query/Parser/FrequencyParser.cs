using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psaximo.Net.Query.Parser
{
    class FrequencyParser
    {
        //Evalutes frequency of term in corpus .... as query = [term[k] >n ] : wher n is min number of occurence of term[k] in  a Xim Document.
        //Frequency queries must be of syntax => ["phrase[k]" >n] (for phrase frequency queries) OR syntax => [term[k] >n] for single keyword search.
        //Notice the 0th-proximity of '>n' ,i.e. query operator (>) must be 0-characters away from n(valid non-negative Int32).
        //Frequenncy queries should be escaped or parentherized i.e freq query => [james >2]  : freq query => [\james >2\](prefered)
        //same rules go for operator '<' (n is maximum number of occurences of phrase/keyword in xim document).

    }
}
