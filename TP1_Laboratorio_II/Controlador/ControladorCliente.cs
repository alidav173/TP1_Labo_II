using Controlador;
using FireSharp.Response;
using Modelos.Fabricacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelos;
using Data;
using System.Collections;


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
    public static string Agregar(string cuit, string razonSocial, string tipoCliente, string direccion, string email, int telefono)
    {
      string mensajeSalida = string.Empty;
      int cuitInt;

      try
      {
        string mensajeControlador = validarDatos(cuit, razonSocial, tipoCliente);
        if (mensajeControlador == "datos validos")
        {
          int.TryParse(cuit, out cuitInt);
          Cliente clienteNuevo = BuscarClientePorCuit(cuitInt);
          if (clienteNuevo is null)
          {
            var client = ConexionDatos.ConectarBD();
            clienteNuevo = new Cliente(cuitInt, razonSocial, tipoCliente);
            clienteNuevo.Email = email;
            clienteNuevo.Direccion = direccion;
            clienteNuevo.Telefono = telefono;
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

    public static Cliente BuscarClientePorCuit(int cuit)
    {
      Cliente clienteBuscado = null;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Clientes/" + i);
          Cliente cliente = response.ResultAs<Cliente>();

          if (cliente.Cuit == cuit)
          {
            clienteBuscado = cliente;
            break;
          }
        }

      }
      catch (Exception ex)
      {
        string mensaje = "No se encontro el cliente" + ex;
      }
      return clienteBuscado;
    }

    public static Cliente BuscarPorId(int id)
    {
      string mensaje = String.Empty;
      Cliente cliente = null;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Clientes/" + i);
          Cliente clienteBuscado = response.ResultAs<Cliente>();

          if (clienteBuscado.Id == id)
          {
            cliente = clienteBuscado;
            break;
          }
        }

      }
      catch (Exception ex)
      {
        mensaje = "No se encontro el cliente";
      }

      return cliente;
    }
    
    public static string Eliminar(int id)
    {
      string mensaje = String.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Clientes/" + i);
          Cliente clienteBuscado = response.ResultAs<Cliente>();

          if (clienteBuscado.Id == id)
          {
            response = client.Delete("Clientes/" + i);
            mensaje = "Cliente eliminado";
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

    public static string Actualizar(Cliente cliente)
    {
      string mensaje = String.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        FirebaseResponse response = client.Update("Clientes/" + cliente.Id, cliente);
        mensaje = "Se actualizaron los datos del cliente";

      }
      catch (Exception ex)
      {
        mensaje = "No se pudieron actulizar los datos del cliente";
      }

      return mensaje;
    }



    public static string ExportarAJson(string rutaAcceso)
    {
      string mensaje = String.Empty;
      try
      {
        List<Cliente> clientes = new List<Cliente>();
        Cliente clienteNuevo;
        for (int id = 1; id < 20; id++)
        {
          clienteNuevo = BuscarPorId(id);
          if (clienteNuevo is not null)
          {
            clientes.Add(clienteNuevo);
          }

        }
        string json = Serializador<Cliente>.SerializarJSON(clientes);
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
        List<Cliente> clientes = new List<Cliente>();
        Cliente clienteNuevo;
        for (int id = 1; id < 20; id++)
        {
          clienteNuevo = BuscarPorId(id);
          if (clienteNuevo is not null)
          {
            clientes.Add(clienteNuevo);
          }

        }
        Archivo.EscribirEnArchivoCsv<Cliente>(rutaAcceso, clientes);
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
        List<Cliente> clientes = new List<Cliente>();
        Cliente clienteNuevo;
        for (int id = 1; id < 20; id++)
        {
          clienteNuevo = BuscarPorId(id);
          if (clienteNuevo is not null)
          {
            clientes.Add(clienteNuevo);
          }

        }
        StringBuilder sb = new StringBuilder();
        foreach (Cliente cliente in clientes)
        {
          sb.AppendLine(cliente.MostrarDatos());
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
