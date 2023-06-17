using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class EmailInvalidoException : ApplicationException
  {
    public EmailInvalidoException()
    {
    }

    public EmailInvalidoException(string? message) : base(message)
    {
    }

    public EmailInvalidoException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected EmailInvalidoException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
