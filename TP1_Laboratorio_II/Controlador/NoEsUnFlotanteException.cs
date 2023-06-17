using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class NoEsUnFlotanteException : Exception
  {
    public NoEsUnFlotanteException()
    {
    }

    public NoEsUnFlotanteException(string? message) : base(message)
    {
    }

    public NoEsUnFlotanteException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NoEsUnFlotanteException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
