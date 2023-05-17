using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class EmailInvalido : ApplicationException
  {
    public EmailInvalido()
    {
    }

    public EmailInvalido(string? message) : base(message)
    {
    }

    public EmailInvalido(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected EmailInvalido(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
