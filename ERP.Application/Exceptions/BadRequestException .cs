using System;

namespace ERP.Application.Exceptions
{
    public class BadRequestException : Exception
    {
        public BadRequestException() { }
        public BadRequestException(string message) : base(message) { }
        public BadRequestException(string message, Exception innerException) : base(message, innerException) { }
        public BadRequestException(string name, object key)
            : base($"Entity \"{name}\" ({key}) One or more validation errors occurred.")
        {
        }
    }
}