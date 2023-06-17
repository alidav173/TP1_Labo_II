using Data;
using FireSharp.Response;
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


    public static string ConectarDBMaterial(string nombre, string descripcion, string tipoMaterial, string precio, string unidadMedida)
    {
      string mensajeSalida = string.Empty;
      float PrecioFloat;
      try
      {
        string mensajeControlador = ValidarDatosMaterial(nombre, descripcion, tipoMaterial, precio, unidadMedida);
        if (mensajeControlador == "datos validos")
        {
          if (float.TryParse(precio, out PrecioFloat) == true)
          {
            var client = ConexionDatos.ConectarBD();
            var nuevoMaterial = new MateriaPrima(nombre, descripcion, tipoMaterial, PrecioFloat, unidadMedida);
            SetResponse response = client.Set("Materiales/" + nuevoMaterial.Id, nuevoMaterial);
            //MateriaPrima result = response.ResultAs<MateriaPrima>();
            mensajeSalida = "Se creó el material con ID: " + nuevoMaterial.Id;
          }

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


    public static MateriaPrima BuscarMaterialPorID(string id)
    {

      string mensajeSalida = string.Empty;
      MateriaPrima materialNuevo = null;
      string mensaje;
      try
      {
        var client = ConexionDatos.ConectarBD();
        int idMaterial;
        if (int.TryParse(id, out idMaterial) == true)
        {
          for (int i = 1; i < 20; i++)
          {
            FirebaseResponse response = client.Get("Materiales/" + i);
            MateriaPrima materia = response.ResultAs<MateriaPrima>();

            if (materia.Id == idMaterial)
            {
              materialNuevo = materia;
              mensaje = "Material Encontrado";
              break;
            }
          }
        }
        else
        {
          throw new NoEsUnEnteroException();
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
  }
}
