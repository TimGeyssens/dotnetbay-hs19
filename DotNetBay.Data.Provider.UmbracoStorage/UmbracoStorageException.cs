using System;
using System.Runtime.Serialization;

namespace DotNetBay.Data.Provider.UmbracoStorage
{
    [Serializable]
    public class UmbracoStorageException : Exception
    {
        public UmbracoStorageException()
        {
        }

        public UmbracoStorageException(string message)
            : base(message)
        {
        }

        public UmbracoStorageException(string message, Exception innerException)
            : base(message, innerException)
        {
        }

        protected UmbracoStorageException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }
    }
}
