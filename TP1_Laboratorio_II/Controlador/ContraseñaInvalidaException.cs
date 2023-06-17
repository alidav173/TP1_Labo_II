using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class ContraseñaInvalidaException : ApplicationException
  {
    public ContraseñaInvalidaException()
    {
    }

    public ContraseñaInvalidaException(string? message) : base(message)
    {
    }

    public ContraseñaInvalidaException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected ContraseñaInvalidaException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
