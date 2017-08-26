using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psaximo.Net.Query.Parser
{
    class ProximityParser
    {
        //Two evaluation forms represented by : boolean IsAdjacent = (query.contains("*" $n "*")) ? true : false; 
        //Evaluating Queries with "(term[k] $n (max number of words betwwen trems) term[k+1]) 
        //NOTE: '$' indicates adjacency : term[k] / phrase[k] must occur b4 term[k+1] /phrase[k+1] =>  (term[k] $n term[k+n]).
        //Evaluating Queries with "(term[k] %n (max number of words betwwen trems) term[k+1]) 

    }
}
