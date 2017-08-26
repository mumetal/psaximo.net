using System;
using Lz4Net;

namespace Psaximo.Net.Util.Compressors
{
    internal class LZ4Compressor
    {
        //Fast lz4 paced Compression algorithms used:
        //used for XimIndex , XimDocument, XimData Compression.
        public LZ4Compressor() {
            Lz4.GetCompressedSize(new byte[] { });
        }
    }
}
