using Psaximo.Net.Util.Enums;
using System;
using RepoType = Psaximo.Net.Util.Enums.RepositoryType;
using RepoData = System.IO.DirectoryInfo;

namespace Psaximo.Net.Index.Directory
{
    public sealed class XimREMDirectory : XimDirectory
    {

        private static RepoType repositoryType;

        private XimREMDirectory(string directoryPath, bool isMonitored) : base(directoryPath, isMonitored) {
            repositoryType = REPOSITORY_TYPE;
        }

        protected override RepoType REPOSITORY_TYPE => throw new NotImplementedException();


        private RepoType GetRepositoryType() {
            return RepoType.Remote;
        }
    }
}
