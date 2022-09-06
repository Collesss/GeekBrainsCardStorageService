using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeekBrainsCardStorageService.Repository.Exceptions
{
    public class RepositoryFieldExeption : RepositoryException
    {
        public virtual ErrorCodeRepositoryEnum ErrorCode { get; }

        public virtual string FieldName { get; }

        public RepositoryFieldExeption() { }

        public RepositoryFieldExeption(string fieldName, ErrorCodeRepositoryEnum errorCode, string repositoryName/*, int errorCode*/)
        {
            FieldName = fieldName;
            ErrorCode = errorCode;
        }

        public RepositoryFieldExeption(string fieldName, ErrorCodeRepositoryEnum errorCode, string repositoryName/*, int errorCode*/, string message) : base(repositoryName, message)
        {
            FieldName = fieldName;
            ErrorCode = errorCode;
        }

        public RepositoryFieldExeption(string fieldName, ErrorCodeRepositoryEnum errorCode, string repositoryName/*, int errorCode*/, string message, Exception innerException) : base(repositoryName, message, innerException)
        {
            FieldName = fieldName;
            ErrorCode = errorCode;
        }
    }
}
