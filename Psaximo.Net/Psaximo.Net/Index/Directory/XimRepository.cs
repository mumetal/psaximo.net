using System;
using static Psaximo.Net.Analysis.DirectoryAnalyzer;
using RepoData = System.IO.DirectoryInfo;
using RepoType = Psaximo.Net.Util.XimEnum.RepositoryType;

namespace Psaximo.Net.Index.Directory
{
    public abstract class XimRepository
    {
        private static bool ismonitored;
        private static string repoPath;
        private static RepoData repository;


        protected abstract RepoType REPOSITORY_TYPE { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the repository should be monitored for changes by the crawler.
        /// This value can be changed (true|false), like a switch.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is monitored; otherwise, <c>false</c>.
        /// </value>
        public virtual bool IsMonitored { get => ismonitored; set => ismonitored = value; }

        /// <summary>
        /// Gets the path as reference to path to the Search Repository,
        /// The Indexer takes this repository as input to get all existing valid files which then is
        /// each indexed.
        /// <para/> A readOnly Property of XimDirectory.
        /// </summary>
        /// <value>
        /// The path.
        /// </value>
        public virtual string Path => repoPath;
        protected virtual RepoData Repository => repository;

        protected internal XimRepository(string directoryPath, bool isMonitored) {
            var valdity = ValidatePath(directoryPath);

            repoPath = valdity.Path;
            repository = valdity.RepositoryInfo;
            this.IsMonitored = isMonitored;
        }

        //TODO:: Add ctor (uri,bool) - net
        // Add ctor(stream,bool) - rem
        // Add  ctor(directoryinfo ,bool) - rem ,net , fs
        // once repository is created only expose certain calls from (stream,directoryinfo,uri) to get directory details


        protected static XimRepository Open(RepoData directory, bool isMonitored, RepoType repositoryType) {

            return null;
        }


        protected static XimRepository OpenRead(RepoData directory, bool isMonitored, RepoType repositoryType) {

            return null;
        }

        /// <summary>
        /// Tries to close the Specified psaXimo Repository.
        /// <code>isClosable</code> returns <c>true</c> if closing operation succeeds ,else false.
        /// </summary>
        /// <param name="ximRepository">The xim repository.</param>
        /// <param name="isClosable">if set to <c>true</c> [is closable].</param>
        protected static void TryClose(XimRepository ximRepository , out bool isClosable) {

            isClosable = true;

          
        }



        private (string Path, RepoData RepositoryInfo) ValidatePath(string dirPath) {
            string realizedPath = RealizePath(dirPath);
            RepoData repo = new RepoData(realizedPath);




            return (realizedPath, repo);
        }


        static XimRepository() {
            ismonitored = false;
            repoPath = null;
        }

        ~XimRepository() {
            Action<XimRepository> action = (XimRepository dir) => { if (dir != null) { ((IDisposable)dir).Dispose(); } };
            action.Invoke(this);
        }
    }
}
