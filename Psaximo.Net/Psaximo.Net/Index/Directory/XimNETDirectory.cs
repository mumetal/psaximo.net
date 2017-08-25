using RepoType = Psaximo.Net.Util.Enums.RepositoryType;
using RepoData = System.IO.DirectoryInfo;


namespace Psaximo.Net.Index.Directory
{
    public sealed class XimNETDirectory : XimDirectory
    {
        private static RepoType repositoryType;

        private XimNETDirectory(string directoryPath, bool isMonitored) : base(directoryPath, isMonitored) {
            repositoryType = REPOSITORY_TYPE;
        }

        protected override RepoType REPOSITORY_TYPE { get => GetRepositoryType(); }

        private RepoType GetRepositoryType() {
            return RepoType.Web;
        }

        public static XimDirectory Open(string dir, bool isMonitored) {
            new XimNETDirectory(dir, isMonitored);
            return Open(new RepoData(dir), isMonitored, repositoryType);
        }



    }
}
