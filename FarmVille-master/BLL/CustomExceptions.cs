using System;

namespace BLL
{
    [Serializable]
    public class WriteException : Exception
    {
        public WriteException() { }
        public WriteException(string message) : base(message) { }
        public WriteException(string message, Exception inner) : base(message, inner) { }
        protected WriteException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }

    [Serializable]
    public class ReadException : Exception
    {
        public ReadException() { }
        public ReadException(string message) : base(message) { }
        public ReadException(string message, Exception inner) : base(message, inner) { }
        protected ReadException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}


//kyuutu