using System;

namespace ERP.Application.Exceptions
{
    public class SiesaException : Exception
    {
        public SiesaException() { }
        public SiesaException(string message) : base(message) { }
        public SiesaException(string message, Exception innerException) : base(message, innerException) { }
        public SiesaException(string name, object key)
            : base($"Entity \"{name}\" ({key}) One or more validation errors occurred.")
        {
        }
    }
}