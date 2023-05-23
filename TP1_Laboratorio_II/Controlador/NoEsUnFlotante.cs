using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class NoEsUnFlotante : Exception
  {
    public NoEsUnFlotante()
    {
    }

    public NoEsUnFlotante(string? message) : base(message)
    {
    }

    public NoEsUnFlotante(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected NoEsUnFlotante(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}