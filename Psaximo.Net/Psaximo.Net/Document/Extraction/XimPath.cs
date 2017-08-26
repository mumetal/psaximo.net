using System;
using System.IO;
using FileFetchMode = Psaximo.Net.Util.XimEnum.FileFetchMode;
using Psaximo.Net.Index.Directory;

namespace Psaximo.Net.Document.Extraction
{
    public sealed class XimPath : IPath 
    {
        //indicates if file open would skip on exception(false) , else break try on exception(true).
        private static bool weakscan; 

        //Path includes path to file for creating a valid ximfile , 
        //a ximfile is a representation of a certain file from specified input path
        //a ximfile holds the data of a file 

        //ximpath does the following : validate input path , which must fall in 
        // - valid directory path (string)
        // - valid file information (fileinfo)
        // - valid directory information (directoryinfo)
        // - valid url link to file or directory (uri)

            
         internal string XimFilePath { get; set;}

         internal bool Result { get; set;}



        internal FileInfo ValidFile { get;  }
        public bool WeakScan { get { return weakscan; } set { weakscan = value;} }

        private XimPath() { XimRepository ximNET = NETDirectory.Open("", false);
           
        }

        public static XimFile TryOpen(string filepath, FileFetchMode fetchMode, bool weakscan, out bool result) {
            throw new NotImplementedException();
        }

        public static XimFile TryOpen(FileInfo file, FileFetchMode fetchMode, bool weakscan, out bool result) {
            throw new NotImplementedException();
        }

        public static XimFile TryOpen(DirectoryInfo directory, FileFetchMode fetchMode, bool weakscan, out bool result) {
            throw new NotImplementedException();
        }

        public static XimFile TryOpen(Uri link, FileFetchMode fetchMode, bool weakscan, out bool result) {
            throw new NotImplementedException();
        }

        public static XimFile TryOpen(Stream filestream, FileFetchMode fetchMode, bool weakscan, out bool result) {
            throw new NotImplementedException();
        }



    }


}
