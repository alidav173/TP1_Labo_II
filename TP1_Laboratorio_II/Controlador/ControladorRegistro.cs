using Data;
using FireSharp.Response;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using static Modelos.Usuario;

namespace Controlador
{
  internal class ControladorRegistro
  {
    /*
    /// <summary>
    /// Valida los campos de un usuario pasados por parametros
    /// </summary>
    /// <param name="email"></param>
    /// <param name="contraseña"></param>
    /// <param name="nombre"></param>
    /// <param name="apellido"></param>
    /// <returns>
    ///Retorna una cadena de texto con el mensaje "datos validos", sino una cadena con el error.
    /// </returns>
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
        mensaje = "Ingrese un dato valido " +vacio.Message;
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
    */

    /// <summary>
    /// Verifica y conecta a la BD si los datos pasados por parametros son correctos
    /// </summary>
    /// <param name="email"></param>
    /// <param name="contraseña"></param>
    /// <param name="rContraseña"></param>
    /// <param name="nombre"></param>
    /// <param name="apellido"></param>
    /// <param name="tipo"></param>
    /// <param name="dni"></param>
    /// <returns>
    ///Retorna una cadena de texto con el mensaje "Se creó el Usuario con ID:", sino una cadena con el error.
    /// </returns>
    public static string Agregar(string email, string contraseña,string rContraseña, string nombre, string apellido, string tipo, int dni)
    {
      string mensajeSalida = ControladorUsuario.Agregar(email, contraseña, rContraseña, nombre, apellido, tipo, dni);
      return mensajeSalida;
      /*try
      {
        string mensajeControlador = ValidarDatosUsuario(email, contraseña, nombre, apellido);
        if (mensajeControlador == "datos validos" & contraseña == rContraseña)
        {
          var usuarioNuevo = new Usuario(email, contraseña, nombre, apellido);
          if (ValidarDni(dni))
          {
            usuarioNuevo.Dni = dni;
          }
          //usuarioNuevo.TipoUsuario = tipo;
          var client = ConexionDatos.ConectarBD();
          SetResponse response =  client.Set("Usuarios/" + usuarioNuevo.Id, usuarioNuevo);
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
      */
    }

  }
  }

