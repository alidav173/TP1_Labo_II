using Data;
using FireSharp.Response;
using Modelos;
using Modelos.Fabricacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controlador
{
  internal class ControladorMaterial
  {
    public static string ValidarDatosMaterial(string nombre, string descripcion, string tipoMaterial, string precio, string unidadMedida)
    {
      string mensaje = string.Empty;
      float precioFloat;
      try
      {
        if (!string.IsNullOrEmpty(nombre) & !string.IsNullOrEmpty(descripcion) & !string.IsNullOrEmpty(tipoMaterial) & !string.IsNullOrEmpty(precio) & !string.IsNullOrEmpty(unidadMedida))
        {
          mensaje = "datos validos";

        }
        else if (string.IsNullOrEmpty(nombre) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(descripcion) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(tipoMaterial) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(precio) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(unidadMedida) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (float.TryParse(precio, out precioFloat) == false)
        {
          throw new NoEsUnFlotanteException();
        }

      }
      catch (CadenaVaciaException vacio)
      {
        mensaje = "Ingrese un dato valido " + vacio.Message;
      }
      catch (NoEsUnFlotanteException vacio)
      {
        mensaje = "Ingrese un numero valido " + vacio.Message;
      }

      return mensaje;
    }


    public static string Agregar(string nombre, string descripcion, string tipoMaterial, string precio, string unidadMedida)
    {
      string mensajeSalida = string.Empty;

      try
      {
        string mensajeControlador = ValidarDatosMaterial(nombre, descripcion, tipoMaterial, precio, unidadMedida);
        if (mensajeControlador == "datos validos")
        {
            var client = ConexionDatos.ConectarBD();
            var nuevoMaterial = new MateriaPrima(nombre, descripcion, tipoMaterial, float.Parse(precio), unidadMedida);
            SetResponse response = client.Set("Materiales/" + nuevoMaterial.Id, nuevoMaterial);
            mensajeSalida = "Se creó el material con ID: " + nuevoMaterial.Id;

        }
        else
        {
          mensajeSalida = mensajeControlador;
        }

      }
      catch (Exception ex)
      {
        mensajeSalida = "Error" + ex;
      }

      return mensajeSalida;

    }


    public static MateriaPrima BuscarPorId(int id)
    {
      MateriaPrima materialNuevo = null;
      string mensaje;
      try
      {
        var client = ConexionDatos.ConectarBD();
          for (int i = 1; i < 20; i++)
          {
            FirebaseResponse response = client.Get("Materiales/" + i);
            MateriaPrima materia = response.ResultAs<MateriaPrima>();

            if (materia.Id == id)
            {
              materialNuevo = materia;
              break;
            }
          }
      }
      catch (NoEsUnEnteroException cv)
      {
        mensaje = "No es un numero";
      }
      catch (Exception ex)
      {
        mensaje = "No se encontro el material";
      }

      return materialNuevo;
    }

    public static string Eliminar(int id)
    {
      string mensaje = String.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        for (int i = 1; i < 20; i++)
        {
          FirebaseResponse response = client.Get("Materiales/" + i);
          Cliente clienteBuscado = response.ResultAs<Cliente>();

          if (clienteBuscado.Id == id)
          {
            response = client.Delete("Materiales/" + i);
            mensaje = "Material eliminado";
            break;
          }

        }
      }
      catch (Exception ex)
      {
        mensaje = "No se encontro el material";
      }

      return mensaje;
    }

    public static string Actualizar(MateriaPrima materiaPrima)
    {
      string mensaje = String.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        FirebaseResponse response = client.Update("Materiales/" + materiaPrima.Id, materiaPrima);
        mensaje = "Se actualizaron los datos de la materia prima";

      }
      catch (Exception ex)
      {
        mensaje = "No se pudieron actulizar los datos de la materia prima";
      }

      return mensaje;
    }



    public static string ExportarAJson(string rutaAcceso)
    {
      string mensaje = String.Empty;
      try
      {
        List<MateriaPrima> materiales = new List<MateriaPrima>();
        MateriaPrima materialNuevo;
        for (int id = 1; id < 20; id++)
        {
          materialNuevo = BuscarPorId(id);
          if (materialNuevo is not null)
          {
            materiales.Add(materialNuevo);
          }

        }
        string json = Serializador<MateriaPrima>.SerializarJSON(materiales);
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
        List<MateriaPrima> materiales = new List<MateriaPrima>();
        MateriaPrima materialNuevo;
        for (int id = 1; id < 20; id++)
        {
          materialNuevo = BuscarPorId(id);
          if (materialNuevo is not null)
          {
            materiales.Add(materialNuevo);
          }

        }
        Archivo.EscribirEnArchivoCsv<MateriaPrima>(rutaAcceso, materiales);
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
        List<MateriaPrima> materiales = new List<MateriaPrima>();
        MateriaPrima materialNuevo;
        for (int id = 1; id < 20; id++)
        {
          materialNuevo = BuscarPorId(id);
          if (materialNuevo is not null)
          {
            materiales.Add(materialNuevo);
          }

        }
        StringBuilder sb = new StringBuilder();
        foreach (MateriaPrima material in materiales)
        {
          sb.AppendLine(material.MostrarDatos());
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
