using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class NoEsUnEnteroException : Exception
  {
    public NoEsUnEnteroException()
    {
    }

    public NoEsUnEnteroException(string? message) : base(message)
    {
    }

    public NoEsUnEnteroException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NoEsUnEnteroException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
