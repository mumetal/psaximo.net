using RepoType = Psaximo.Net.Util.XimEnum.RepositoryType;

namespace Psaximo.Net.Index.Directory
{
    public sealed class FSDirectory : XimRepository
    {

        private static RepoType repositoryType;

        private FSDirectory(string directoryPath, bool isMonitored) : base(directoryPath, isMonitored) {
            repositoryType = REPOSITORY_TYPE;
        }

        protected override RepoType REPOSITORY_TYPE { get => GetRepositoryType(); }

        private RepoType GetRepositoryType() {
            return RepoType.Local;
        }
    }
}
