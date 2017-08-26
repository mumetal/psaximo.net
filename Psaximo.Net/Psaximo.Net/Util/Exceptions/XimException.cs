using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Psaximo.Net.Util.Exceptions
{
    public abstract class XimException : Exception
    {
        protected XimException(string message) : base(message) {
        }

        protected XimException(string message, Exception innerException) : base(message, innerException) {
        }

        protected XimException() {
        }

        protected XimException(SerializationInfo info, StreamingContext context) : base(info, context) {
        }
    }
}
