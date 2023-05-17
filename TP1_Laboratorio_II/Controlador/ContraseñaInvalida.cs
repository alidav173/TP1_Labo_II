using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class ContraseñaInvalida : ApplicationException
  {
    public ContraseñaInvalida()
    {
    }

    public ContraseñaInvalida(string? message) : base(message)
    {
    }

    public ContraseñaInvalida(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected ContraseñaInvalida(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
