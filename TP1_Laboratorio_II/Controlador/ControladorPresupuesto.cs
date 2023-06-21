using FireSharp.Response;
using Modelos;
using Modelos.Fabricacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP1_Laboratorio_II.Controlador;

namespace Controlador
{
  public class ControladorPresupuesto
  {
 

  public static string ConectarDB(string razonSocial,string cuit,string tipoCliente, List<Producto> productos, List<string> impuestos)
  {
    string mensajeSalida = string.Empty;
      int cuitInt;
      try
      {
        string mensajeControlador = validarDatos(razonSocial, cuit);
        if (mensajeControlador == "datos validos")
        {
          if (int.TryParse(cuit, out cuitInt) == true)
          {
            var client = ConexionDatos.ConectarBD();

            string mensaje = ControladorCliente.buscarClientePorCuit(cuitInt);
            if (mensaje == "No se encontro el cliente")
            {
             Cliente clienteNuevo = new Cliente(cuitInt, razonSocial, tipoCliente);

            }
            Presupuesto nuevoPresupuesto = new Presupuesto(cuitInt, razonSocial, productos, impuestos);
              nuevoPresupuesto.CalcularSubtotal();
              nuevoPresupuesto.CalcularTotal();
              SetResponse response = client.Set("Presupuestos/" + nuevoPresupuesto.Id, nuevoPresupuesto);
              mensajeSalida = "Se creó el Presupuesto con ID: " + nuevoPresupuesto.Id;

          }

        }
        else
        {
          mensajeSalida = mensajeControlador;
        }

        return mensajeSalida;
      }
      catch (Exception ex)
      {
        return mensajeSalida = "Error" + ex;

      }
  }

  public static string validarDatos(string razonSocial, string cuit)
  {
    string mensaje = string.Empty;
    int cuitInt;
    try
    {
      if (razonSocial != string.Empty & int.TryParse(cuit, out cuitInt) == true)
      {
        mensaje = "datos validos";
      }
      else if (string.IsNullOrEmpty(razonSocial) == true)
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

    catch (NoEsUnEnteroException error)
    {
      mensaje = "Ingrese un valor valido " + error.Message;
    }

    return mensaje;
  }

}
}
