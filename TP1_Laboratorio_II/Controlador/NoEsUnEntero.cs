using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class NoEsUnEntero : Exception
  {
    public NoEsUnEntero()
    {
    }

    public NoEsUnEntero(string? message) : base(message)
    {
    }

    public NoEsUnEntero(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NoEsUnEntero(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}