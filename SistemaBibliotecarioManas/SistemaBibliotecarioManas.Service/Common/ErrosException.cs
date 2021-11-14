using System;
using System.Collections.Generic;

namespace SistemaBibliotecarioManas.Application.Common
{
    public class ErrosException : Exception
    {
        public List<Error> Errors { get; private set; }

        public ErrosException(List<Error> errors)
        {
            this.Errors = errors;
        }

        public ErrosException(string message) : base(message) { }
        public ErrosException(string message, Exception inner) : base(message, inner) { }
        protected ErrosException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
