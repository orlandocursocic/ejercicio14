using System;
using System.Runtime.Serialization;

namespace ejercicio14
{
    [Serializable]
    internal class EntradaNoExisteException : Exception
    {
        public EntradaNoExisteException()
        {
        }

        public EntradaNoExisteException(string message) : base(message)
        {
        }

        public EntradaNoExisteException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected EntradaNoExisteException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}