using Data;
using FireSharp.Response;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
  public class ControladorUsuario
  {
    public static string ValidarDatosUsuario(string email, string contraseña, string nombre, string apellido)
    {
      string mensaje = string.Empty;
      try
      {
        if (!string.IsNullOrEmpty(email) & !string.IsNullOrEmpty(contraseña) & !string.IsNullOrEmpty(nombre) & !string.IsNullOrEmpty(apellido) & Validador.esEmailValido(email) == true & Validador.esContraseñaValida(contraseña))
        {
          mensaje = "datos validos";
        }
        else if (string.IsNullOrEmpty(email) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(contraseña) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(nombre) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(apellido) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (!Validador.esEmailValido(email))
        {
          throw new EmailInvalidoException();
        }
        else if (!Validador.esContraseñaValida(contraseña))
        {
          throw new ContraseñaInvalidaException();
        }
      }
      catch (CadenaVaciaException vacio)
      {
        mensaje = "Ingrese un dato valido " + vacio.Message;
      }
      catch (EmailInvalidoException em)
      {
        mensaje = "Ingrese un email valido " + em.Message;
      }
      catch (ContraseñaInvalidaException ci)
      {
        mensaje = "Ingrese una contraseña valida " + ci.Message;
      }
      return mensaje;
    }


    /// <summary>
    /// Valida si un numero de dni es valido
    /// </summary>
    /// <param name="dni"></param>
    /// <returns>
    ///Retorna true si es valido el dni, sino retorna false
    /// </returns>
    public static bool ValidarDni(int dni)
    {
      return Validador.esDniValido(dni);

    }
    public static string Agregar(string email, string contraseña, string rContraseña, string nombre, string apellido, string tipo, int dni)
    {
      string mensajeSalida = string.Empty;
      try
      {
        string mensajeControlador = ValidarDatosUsuario(email, contraseña, nombre, apellido);
        if (mensajeControlador == "datos validos" & contraseña == rContraseña)
        {
          var usuarioNuevo = new Usuario(email, contraseña, nombre, apellido);
          if (ValidarDni(dni))
          {
            usuarioNuevo.Dni = dni;
          }
          var client = ConexionDatos.ConectarBD();
          SetResponse response = client.Set("Usuarios/" + usuarioNuevo.Id, usuarioNuevo);
          mensajeSalida = "Se creó el Usuario con ID: " + usuarioNuevo.Id;
        }
        else
        {
          mensajeSalida = mensajeControlador;
        }

      }
      catch (Exception ex)
      {

      }

      return mensajeSalida;

    }

    public static Usuario BuscarPorId(int id)
    {
      string mensaje = String.Empty;
      Usuario usuario = null;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Usuarios/" + i);
          Usuario usuarioBuscado = response.ResultAs<Usuario>();

          if (usuarioBuscado.Id == id)
          {
            usuario = usuarioBuscado;
            break;
          }
        }

      }
      catch (Exception ex)
      {
        mensaje = "No se encontro el usuario";
      }

      return usuario;
    }

    public static string Eliminar(int id)
    {
      string mensaje = String.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Usuarios/" + i);
          Usuario usuarioBuscado = response.ResultAs<Usuario>();

          if (usuarioBuscado.Id == id)
          {
            response = client.Delete("Usuarios/" + i);
            mensaje = "Usuario eliminado";
            break;
          }

        }
      }
      catch (Exception ex)
      {
        mensaje = "No se encontro el usuario";
      }

      return mensaje;
    }

    public static string Actualizar(Usuario usuario)
    {
      string mensaje = String.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        FirebaseResponse response = client.Update("Usuarios/" + usuario.Id, usuario);
        mensaje = "Se actualizaron los datos del usuario";

      }
      catch (Exception ex)
      {
        mensaje = "No se pudieron actulizar los datos del usuario";
      }

      return mensaje;
    }



    public static string ExportarAJson(string rutaAcceso)
    {
      string mensaje = String.Empty;
      try
      {
        List<Usuario> usuarios = new List<Usuario>();
        Usuario usuarioNuevo;
        for (int id = 1; id < 20; id++)
        {
          usuarioNuevo = BuscarPorId(id);
          if (usuarioNuevo is not null)
          {
            usuarios.Add(usuarioNuevo);
          }

        }
        string json = Serializador<Usuario>.SerializarJSON(usuarios);
        if (Archivo.EscribirEnArchivoJSON(json, rutaAcceso))
        {
          mensaje = "Archivo generado";
        }
      }
      catch (Exception ex)
      {
        mensaje = "error" + ex;
      }

      return mensaje;
    }

    public static string ExportarAcsv(string rutaAcceso)
    {
      string mensaje = String.Empty;
      try
      {
        List<Usuario> clientes = new List<Usuario>();
        Usuario usuarioNuevo;
        for (int id = 1; id < 20; id++)
        {
          usuarioNuevo = BuscarPorId(id);
          if (usuarioNuevo is not null)
          {
            clientes.Add(usuarioNuevo);
          }

        }
        Archivo.EscribirEnArchivoCsv<Usuario>(rutaAcceso, clientes);
        mensaje = "Archivo generado";

      }
      catch (Exception ex)
      {
        mensaje = "error" + ex;
      }

      return mensaje;
    }

    public static string ExportarApdf(string rutaAcceso)
    {
      string mensaje = String.Empty;
      try
      {
        List<Usuario> usuarios= new List<Usuario>();
        Usuario usuarioNuevo;
        for (int id = 1; id < 20; id++)
        {
          usuarioNuevo = BuscarPorId(id);
          if (usuarioNuevo is not null)
          {
            usuarios.Add(usuarioNuevo);
          }

        }
        StringBuilder sb = new StringBuilder();
        foreach (Usuario usuario in usuarios)
        {
          sb.AppendLine(usuario.MostrarDatos());
        }
        Archivo.EscribirEnArchivoPdf(rutaAcceso, sb.ToString());
        mensaje = "Archivo generado";

      }
      catch (Exception ex)
      {
        mensaje = "error" + ex;
      }

      return mensaje;
    }

  }
}
