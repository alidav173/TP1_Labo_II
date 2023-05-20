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
          throw new CadenaVacia();
        }
        else if (string.IsNullOrEmpty(contraseña) == true)
        {
          throw new CadenaVacia();
        }
        else if (string.IsNullOrEmpty(nombre) == true)
        {
          throw new CadenaVacia();
        }
        else if (string.IsNullOrEmpty(apellido) == true)
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
        mensaje = "Ingrese un dato valido " +vacio.Message;
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

    public static bool ValidarDni(int dni)
    {
      return Validador.esDniValido(dni);

    }

    public static string ConectarDB(string email, string contraseña,string rContraseña, string nombre, string apellido, string tipo, int dni)
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
          usuarioNuevo.TipoUsuario = tipo;
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

    }

  }
  }

