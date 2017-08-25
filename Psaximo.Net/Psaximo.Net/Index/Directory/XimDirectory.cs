using System;
using static Psaximo.Net.Analysis.DirectoryAnalyzer;
using RepoData = System.IO.DirectoryInfo;
using RepoType = Psaximo.Net.Util.Enums.RepositoryType;

namespace Psaximo.Net.Index.Directory
{
    public abstract class XimDirectory
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

        protected internal XimDirectory(string directoryPath, bool isMonitored) {
            var valdity = ValidatePath(directoryPath);

            repoPath = valdity.Path;
            repository = valdity.RepositoryInfo;
            this.IsMonitored = isMonitored;
        }

        protected static XimDirectory Open(RepoData directory, bool isMonitored, RepoType repositoryType) {

            return null;
        }


        private  (string Path, RepoData RepositoryInfo) ValidatePath(string dirPath) {
            string realizedPath = RealizePath(dirPath);
            RepoData repo = new RepoData(realizedPath);




            return (realizedPath, repo);
        }


        static XimDirectory() {
            ismonitored = false;
            repoPath = null;
        }

        ~XimDirectory() {
            Action<XimDirectory> action = (XimDirectory dir) => { if (dir != null) { ((IDisposable)dir).Dispose(); } };
            action.Invoke(this);
        }
    }
}
