namespace Psaximo.Net.Util
{
    public  static class XimEnum
    {
        public enum RepositoryType { Local, Remote, Web }

        public enum FieldScope : sbyte { Default = (Content & Name), Content = 0, Name = 1, Modified = 2, Date = 3, Size = 4, Metadata = 5 }

        public enum SearchMode : sbyte { Free = 0, Rigid = ~Free, Natural = 1 }

        public enum QueryMode { Simple, Full }

        public enum FileFetchMode : sbyte { Minimal = sbyte.MinValue, Normal = 0, Detailed = 1, Absolute = sbyte.MaxValue }

        protected internal enum FileType { MEDIA, DOCUMENT }



    }
}
