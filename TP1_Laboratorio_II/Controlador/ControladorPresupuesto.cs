using Data;
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

            Cliente clienteBuscado = ControladorCliente.BuscarClientePorCuit(cuitInt);
            if (clienteBuscado == null)
            {
             Cliente clienteNuevo = new Cliente(cuitInt, razonSocial, tipoCliente);

            }
            Presupuesto presupuestoBuscado = BuscarPorId(int.Parse(cuit));
            if (presupuestoBuscado is null)
            {
              Presupuesto nuevoPresupuesto = new Presupuesto(cuitInt, razonSocial, productos, impuestos);
              SetResponse response = client.Set("Presupuestos/" + nuevoPresupuesto.Id, nuevoPresupuesto);
              clienteBuscado = ControladorCliente.BuscarClientePorCuit(cuitInt);
              clienteBuscado.Presupuestos.Add(nuevoPresupuesto.Id);
              ControladorCliente.Actualizar(clienteBuscado);
              mensajeSalida = "Se creó el Presupuesto con ID: " + nuevoPresupuesto.Id;
            }
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

    public static Presupuesto BuscarPresupuestoPorCuit(int cuit)
    {
      Presupuesto presupuestoBuscado = null;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Presupuesto/" + i);
          Presupuesto presupuesto = response.ResultAs<Presupuesto>();

          if (presupuesto.Cuit == cuit)
          {
            presupuestoBuscado = presupuesto;
            break;
          }
        }

      }
      catch (Exception ex)
      {
        string mensaje = "Error" + ex;
      }
      return presupuestoBuscado;
    }

    public static Presupuesto BuscarPorId(int id)
    {
      string mensaje = String.Empty;
      Presupuesto presupuesto = null;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Clientes/" + i);
          Presupuesto presupuestoBuscado = response.ResultAs<Presupuesto>();

          if (presupuestoBuscado.Id == id)
          {
            presupuesto = presupuestoBuscado;
            break;
          }
        }

      }
      catch (Exception ex)
      {
        mensaje = "No se encontro el cliente";
      }

      return presupuesto;
    }

    public static string Eliminar(int id)
    {
      string mensaje = String.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Presupuestos/" + i);
          Presupuesto presupuestoBuscado = response.ResultAs<Presupuesto>();

          if (presupuestoBuscado.Id == id)
          {
            response = client.Delete("Presupuestos/" + i);
            mensaje = "Presupuesto eliminado";
            break;
          }

        }
      }
      catch (Exception ex)
      {
        mensaje = "No se encontro el presupuesto";
      }

      return mensaje;
    }

    public static string Actualizar(Presupuesto presupuesto)
    {
      string mensaje = String.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        FirebaseResponse response = client.Update("Presupuestos/" + presupuesto.Id, presupuesto);
        mensaje = "Se actualizaron los datos del presupuesto";

      }
      catch (Exception ex)
      {
        mensaje = "No se pudieron actulizar los datos del presupuesto";
      }

      return mensaje;
    }



    public static string ExportarAJson(string rutaAcceso)
    {
      string mensaje = String.Empty;
      try
      {
        List<Presupuesto> presupuestos = new List<Presupuesto>();
        Presupuesto presupuestoNuevo;
        for (int id = 1; id < 20; id++)
        {
          presupuestoNuevo = BuscarPorId(id);
          if (presupuestoNuevo is not null)
          {
            presupuestos.Add(presupuestoNuevo);
          }

        }
        string json = Serializador<Presupuesto>.SerializarJSON(presupuestos);
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
        List<Presupuesto> presupuestos = new List<Presupuesto>();
        Presupuesto presupuestoNuevo;
        for (int id = 1; id < 20; id++)
        {
          presupuestoNuevo = BuscarPorId(id);
          if (presupuestoNuevo is not null)
          {
            presupuestos.Add(presupuestoNuevo);
          }

        }
        Archivo.EscribirEnArchivoCsv<Presupuesto>(rutaAcceso, presupuestos);
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
        List<Presupuesto> presupuestos = new List<Presupuesto>();
        Presupuesto presupuestoNuevo;
        for (int id = 1; id < 20; id++)
        {
          presupuestoNuevo = BuscarPorId(id);
          if (presupuestoNuevo is not null)
          {
            presupuestos.Add(presupuestoNuevo);
          }

        }
        StringBuilder sb = new StringBuilder();
        sb.AppendLine("Presupuestos: ");
        foreach (Presupuesto presupuesto in presupuestos)
        {
          sb.AppendLine(presupuesto.MostrarDatos());
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
