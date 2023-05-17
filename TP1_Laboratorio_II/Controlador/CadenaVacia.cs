using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class CadenaVacia : ApplicationException
  {
    public CadenaVacia()
    {
    }

    public CadenaVacia(string? message) : base(message)
    {
    }

    public CadenaVacia(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected CadenaVacia(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
