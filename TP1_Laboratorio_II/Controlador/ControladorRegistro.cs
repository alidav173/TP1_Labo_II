using Data;
using FireSharp.Response;
using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Runtime.Serialization;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static Modelos.Usuario;

namespace Controlador
{
  internal class ControladorRegistro
  {

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
    public static string Agregar(string email, string contraseña, string rContraseña, string nombre, string apellido, string tipo, int dni)
    {

      return ControladorUsuario.Agregar(email, contraseña, rContraseña, nombre, apellido, tipo, dni);
    }

  }
}

  

