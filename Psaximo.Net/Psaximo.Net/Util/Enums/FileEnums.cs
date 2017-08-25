using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Psaximo.Net.Util.Enums
{
   public enum FileFetchMode : sbyte { Minimal = sbyte.MinValue , Normal = 0 , Detailed = 1 , Absolute = sbyte.MaxValue}
   internal static class FileEnums
    {
        protected internal enum FileType { MEDIA , DOCUMENT}

        
    }
}
