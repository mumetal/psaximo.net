using RepoType = Psaximo.Net.Util.XimEnum.RepositoryType;
using RepoData = System.IO.DirectoryInfo;


namespace Psaximo.Net.Index.Directory
{
    public sealed class NETDirectory : XimRepository
    {
        private static RepoType repositoryType;

        private NETDirectory(string directoryPath, bool isMonitored) : base(directoryPath, isMonitored) {
            repositoryType = REPOSITORY_TYPE;
        }

        protected override RepoType REPOSITORY_TYPE { get => GetRepositoryType(); }

        private RepoType GetRepositoryType() {
            return RepoType.Web;
        }

        public static XimRepository Open(string dir, bool isMonitored) {
            new NETDirectory(dir, isMonitored);
            return Open(new RepoData(dir), isMonitored, repositoryType);
        }



    }
}
