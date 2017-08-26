using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psaximo.Net.Query.Parser
{
    class FieldScopeParser
    {
        //Evaluates field based queries i.e queries with specified field name
        //NOTE: XimQuery q = Query.Create(string:query , SearchMode: mode, QueryMode: querymode, params FieldScope[] fieldscope)
        //passing no fieldscope into query sets deafault as FieldScope.Default 
        //Fieldscope includes : Default(Content and Name) , Content(content of file) , Name(fullname,name,title of file(s)) -
        // -Modified(last modified) , Date(date created) , Size (size of file), Metadata (metadata of file) 

        //sample check --  enum @ Util.Enums.QueryEnum
       
    }
}
