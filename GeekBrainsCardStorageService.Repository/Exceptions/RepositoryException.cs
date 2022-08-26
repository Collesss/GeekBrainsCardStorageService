using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.Repository.Exceptions
{
    public class RepositoryException : Exception
    {
        public virtual string RepositoryName { get; }

        public RepositoryException(string repositoryName)
        {
            RepositoryName = repositoryName;
        }

        public RepositoryException(string repositoryName, string message) : base(message)
        {
            RepositoryName = repositoryName;
        }

        public RepositoryException(string repositoryName, string message, Exception innerException) : base(message, innerException)
        {
            RepositoryName = repositoryName;
        }
    }
}
