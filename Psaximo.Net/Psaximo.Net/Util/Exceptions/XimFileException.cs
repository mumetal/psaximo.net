using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Psaximo.Net.Util.Exceptions
{
    public class XimFileException : XimException
    {
        protected XimFileException() {
        }

        protected XimFileException(string message) : base(message) {
        }

        protected XimFileException(string message, Exception innerException) : base(message, innerException) {
        }

        protected XimFileException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
