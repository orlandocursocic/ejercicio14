using System;
using System.Runtime.Serialization;

namespace ejercicio14
{
    [Serializable]
    internal class EntradaYaExisteException : Exception
    {
        public EntradaYaExisteException()
        {
        }

        public EntradaYaExisteException(string message) : base(message)
        {
        }

        public EntradaYaExisteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntradaYaExisteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}