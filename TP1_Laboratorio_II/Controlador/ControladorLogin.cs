using Data;
using FireSharp.Response;
using Modelos;

namespace Controlador
{
  public class ControladorLogin
  {
    /// <summary>
    /// Valida los campos de un usuario, pasados por parametro
    /// </summary>
    /// <param name="email"></param>
    /// <param name="contraseña"></param>
    /// <returns>
    ///Retorna una cadena de texto con el mensaje "datos validos" si todo ok, sino devulve un mensaje con el error.
    /// </returns>
    public static string ValidarDatosUsuario(string email, string contraseña)
    { 
      string mensaje = string.Empty;
      try
      {
        if (!string.IsNullOrEmpty(email) & !string.IsNullOrEmpty(contraseña) & Validador.esEmailValido(email) == true & Validador.esContraseñaValida(contraseña))
        {
          mensaje = "datos validos";
        }
        else if (string.IsNullOrEmpty(email) == true)
        {
          throw new CadenaVacia();
        }
        else if (string.IsNullOrEmpty(contraseña) == true)
        {
          throw new CadenaVacia();
        }
        else if (!Validador.esEmailValido(email))
        {
          throw new EmailInvalido();
        }
        else if (!Validador.esContraseñaValida(contraseña))
        {
          throw new ContraseñaInvalida();
        }
      }
      catch (CadenaVacia vacio)
      {
        mensaje = "Ingrese un dato valido " + vacio.Message;
      }
      catch (EmailInvalido em)
      {
        mensaje = "Ingrese un email valido " + em.Message;
      }
      catch (ContraseñaInvalida ci)
      {
        mensaje = "Ingrese una contraseña valida " + ci.Message;
      }
      return mensaje;
    }

    /// <summary>
    /// Busca y verifica si los datos ingresados en los parametros, se encuentran en la BD
    /// </summary>
    /// <param name="email"></param>
    /// <param name="contraseña"></param>
    /// <returns>
    ///REtorna una cadena de texto con el mensaje ¡Bienvenido!", sino una cadena con el error.
    /// </returns>
    public static string ConectarBd(string email, string contraseña)
    {
      
      string mensajeSalida = string.Empty;
      try {
        var client = ConexionDatos.ConectarBD();
        string mensajeControlador = ValidarDatosUsuario(email, contraseña);
        if (mensajeControlador == "datos validos")
        {
          for (int i = 1; i < 20; i++) 
          {
            FirebaseResponse response = client.Get("Usuarios/" + i);
            Usuario usuarioBuscado = response.ResultAs<Usuario>();

            if (usuarioBuscado.Email == email & usuarioBuscado.Contraseña == contraseña)
            {
              mensajeSalida = "¡Bienvenido!";
              break;
            }
          }
        }
        else
        {
          mensajeSalida = mensajeControlador;
        }

      }
      catch (Exception ex)
      {
        mensajeSalida = "Usuario no encontrado";
      }

      return mensajeSalida;
    }
  }
}
