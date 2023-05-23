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
  internal class ControladorProducto
  {
    /// <summary>
    /// Valida los datos ingresados por paramtros de un producto.
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="descripcion"></param>
    /// <param name="costo"></param>
    /// <param name="porcentaje"></param>
    /// <returns>
    /// Retorna una cadena de texto con el mensaje "datos validos", sino devuelve una cadena con el error.
    /// </returns>
    public static string validarDatos(string nombre, string descripcion, string costo, string porcentaje)
    {
      string mensaje = string.Empty;
      float costoFloat;
      float porcentajeFloat;
      try
      {
        if (nombre != string.Empty & descripcion != string.Empty & float.TryParse(costo, out costoFloat) == true & float.TryParse(porcentaje, out porcentajeFloat) == true)
        {
          mensaje = "datos validos";
        }
        else if (string.IsNullOrEmpty(nombre) == true)
        {
          throw new CadenaVacia();
        }
        else if (string.IsNullOrEmpty(descripcion) == true)
        {
          throw new CadenaVacia();
        }
        else if (string.IsNullOrEmpty(costo) == true)
        {
          throw new CadenaVacia();
        }
        else if (string.IsNullOrEmpty(porcentaje) == true)
        {
          throw new CadenaVacia();
        }
        else if (float.TryParse(costo, out costoFloat) == false)
        {
          throw new NoEsUnFlotante();
        }
        else if (float.TryParse(porcentaje, out porcentajeFloat) == false)
        {
          throw new NoEsUnFlotante();
        }

      }
      catch(CadenaVacia vacio)
        {
        mensaje = "Ingrese un dato valido " + vacio.Message;
      }

      catch (NoEsUnFlotante error)
      {
        mensaje = "Ingrese un valor valido " + error.Message;
      }

      return mensaje;
    }
    /// <summary>
    /// Valida los parametros ingresados y si son correctos, añade un nuevo producto a la BD
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="descripcion"></param>
    /// <param name="costo"></param>
    /// <param name="porcentaje"></param>
    /// <param name="tipo"></param>
    /// <returns>
    ///Retorna una cadena de texto con el mensaje "Se creó el Producto con ID:", sino devuelve una cadena con el error.
    /// </returns>
    public static string ConectarDB(string nombre, string descripcion, string costo, string porcentaje, string tipo)
    {
      string mensajeSalida = string.Empty;
      float costoFloat;
      float porcFloat;
      try
      {
        string mensajeControlador = validarDatos(nombre, descripcion, costo, porcentaje);
        if (mensajeControlador == "datos validos")
        {
          if (float.TryParse(costo, out costoFloat) == true & float.TryParse(porcentaje, out porcFloat) == true)
          {
            var client = ConexionDatos.ConectarBD();
            if (tipo == "Reventa")
            {
              ProductoReventa nuevoProducto = new ProductoReventa(nombre, descripcion, costoFloat);
              nuevoProducto.CalcularPrecioVenta(porcFloat);
              SetResponse response = client.Set("Productos/" + nuevoProducto.IdProducto, nuevoProducto);
              mensajeSalida = "Se creó el Producto con ID: " + nuevoProducto.IdProducto;
            }
            else{
              List<MateriaPrima> lista = new List<MateriaPrima>();
              ProductoFabricacion nuevoProducto2 = new ProductoFabricacion(nombre, descripcion, costoFloat, lista);
              SetResponse response = client.Set("Productos/" + nuevoProducto2.IdProducto, nuevoProducto2);
              mensajeSalida = "Se creó el Producto con ID: " + nuevoProducto2.IdProducto;
            }  
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

    /// <summary>
    /// Busca un producto por su nombre en la BD. Retorna una cadena de texto
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="producto"></param>
    /// <returns>
    /// Retorna una cadena de texto con el mensaje "producto encontrado", sino devuelve una cadena con el error.
    /// </returns>
    public static string BuscarProductoPorNombre(string nombre, out Producto producto)
    {
      string mensajeSalida = string.Empty;
       producto = null;
      try
      {
        var client = ConexionDatos.ConectarBD();
          for (int i = 1001; i <1100; i++)
          {
            FirebaseResponse response = client.Get("Productos/" + i);
            Producto productoBuscado = response.ResultAs<Producto>();

            if (productoBuscado.NombreProducto == nombre)
            {
            productoBuscado = producto;
            mensajeSalida = "Producto Encontrado";
            break;
          }
          }
        
      }
      catch (Exception cv)
      {
        mensajeSalida = "Error";
      }

      return mensajeSalida;
    }
    /// <summary>
    /// Busca un producto en la BD por id. Retorna una cadena de texto
    /// </summary>
    /// <param name="id"></param>
    /// <param name="productoBuscado"></param>
    /// <returns>
    ///etorna una cadena de texto con el mensaje "producto encontrado", sino devuelve una cadena con el error.
    /// </returns>
    public static string BuscarProductoPorID(string id, out Producto productoBuscado)
    {
      productoBuscado = null;
      string mensajeSalida = string.Empty;
      try
      {
        var client = ConexionDatos.ConectarBD();
        int idProducto;
        if (int.TryParse(id, out idProducto) == true)
        {
          for (int i = 1001; i < 1100; i++) 
          {
            FirebaseResponse response = client.Get("Productos/" + i);
            Producto producto = response.ResultAs<Producto>();

            if (producto.IdProducto == idProducto)
            {
              productoBuscado = producto;
              mensajeSalida = "Producto Encontrado";
              break;
            }
          }
        }
        else
        {
          throw new NoEsUnEntero();
        }
      }
      catch (NoEsUnEntero cv)
      {
        mensajeSalida = "No es un numero";
      }
      catch (Exception ex)
      {
        mensajeSalida = "No se encontro el producto";
      }

      return mensajeSalida;
    }
  }
}
