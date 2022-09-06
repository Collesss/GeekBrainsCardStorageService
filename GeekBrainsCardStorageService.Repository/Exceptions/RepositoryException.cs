using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.Repository.Exceptions
{
    public class RepositoryException : Exception
    {
        //public virtual int ErrorCode { get; }

        public virtual string RepositoryName { get; }

        public RepositoryException() { }

        public RepositoryException(string repositoryName/*, int errorCode*/)
        {
            RepositoryName = repositoryName;
            //ErrorCode = errorCode;
        }

        public RepositoryException(string repositoryName/*, int errorCode*/, string message) : base(message)
        {
            RepositoryName = repositoryName;
            //ErrorCode = errorCode;
        }

        public RepositoryException(string repositoryName/*, int errorCode*/, string message, Exception innerException) : base(message, innerException)
        {
            RepositoryName = repositoryName;
            //ErrorCode = errorCode;
        }
    }
}
