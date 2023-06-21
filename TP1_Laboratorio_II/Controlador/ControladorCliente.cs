using Controlador;
using FireSharp.Response;
using Modelos.Fabricacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using System.Windows.Forms;

namespace TP1_Laboratorio_II.Controlador
{
  public class ControladorCliente
  {
    public static string validarDatos(string cuit, string razonSocial, string tipoCliente)
    {
      string mensaje = string.Empty;
      int cuitInt;
      try
      {
        if (cuit != string.Empty & razonSocial != string.Empty & tipoCliente != String.Empty)
        {
          mensaje = "datos validos";
        }
        else if (string.IsNullOrEmpty(razonSocial) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(tipoCliente) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(cuit) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (int.TryParse(cuit, out cuitInt) == false)
        {
          throw new NoEsUnEnteroException();
        }
      }
      catch (CadenaVaciaException vacio)
      {
        mensaje = "Ingrese un dato valido " + vacio.Message;
      }

      catch (NoEsUnFlotanteException error)
      {
        mensaje = "Ingrese un valor valido " + error.Message;
      }

      return mensaje;
    }
    public static string ConectarDB(string cuit, string razonSocial, string tipoCliente)
    {
      string mensajeSalida = string.Empty;
      int cuitInt;

      try
      {
        string mensajeControlador = validarDatos(cuit, razonSocial, tipoCliente);
        if (mensajeControlador == "datos validos")
        {
          int.TryParse(cuit, out cuitInt);
          Cliente clienteNuevo = new Cliente();
          string mensaje = buscarClientePorCuit(cuitInt); 
          if (mensaje == "No se encontro el cliente")
          {
            var client = ConexionDatos.ConectarBD();
            clienteNuevo = new Cliente(cuitInt, razonSocial, tipoCliente);
            SetResponse response = client.Set("Clientes/" + clienteNuevo.Id, clienteNuevo);
            mensajeSalida = "Se creó el cliente con ID: " + clienteNuevo.Id;
          }
          else
          {
            mensajeSalida = "Cliente existente";
          }

        }
        else
        {
          mensajeSalida = "Compruebe los datos ";
        }

        return mensajeSalida;
      }
      catch (Exception ex)
      {
        return mensajeSalida = "Error" + ex;

      }

    }

    public static string buscarClientePorCuit(int cuit)
    {
      string mensaje = String.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Clientes/" + i);
          Cliente clienteBuscado = response.ResultAs<Cliente>();

          if (clienteBuscado.Cuit == cuit)
          {
            mensaje = "Cliente existente";
            break;
          }
        }

      }
      catch (Exception ex)
      {
        mensaje = "No se encontro el cliente";
      }
      return mensaje;
    }

  }
}
