using System.Runtime.Serialization;

namespace Controlador
{
  [Serializable]
  internal class CadenaVaciaException : ApplicationException
  {
    public CadenaVaciaException()
    {
    }

    public CadenaVaciaException(string? message) : base(message)
    {
    }

    public CadenaVaciaException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    protected CadenaVaciaException(SerializationInfo info, StreamingContext context) : base(info, context)
    {
    }
  }
}
