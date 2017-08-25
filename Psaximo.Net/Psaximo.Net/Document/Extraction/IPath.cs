using System;
using directory = System.IO.DirectoryInfo;
using FetchMode = Psaximo.Net.Util.Enums.FileFetchMode;
using file = System.IO.FileInfo;
using stream = System.IO.Stream;

namespace Psaximo.Net.Document.Extraction
{
    internal interface IPath
    {
        //Holds Path method for XimPath 


        bool WeakScan { get; set;}


    }
}
