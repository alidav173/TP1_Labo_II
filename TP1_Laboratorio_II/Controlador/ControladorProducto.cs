using FireSharp.Response;
using Modelos;
using Modelos.Fabricacion;
using System;
using System.Collections;
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
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(descripcion) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(costo) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (string.IsNullOrEmpty(porcentaje) == true)
        {
          throw new CadenaVaciaException();
        }
        else if (float.TryParse(costo, out costoFloat) == false)
        {
          throw new NoEsUnFlotanteException();
        }
        else if (float.TryParse(porcentaje, out porcentajeFloat) == false)
        {
          throw new NoEsUnFlotanteException();
        }

      }
      catch(CadenaVaciaException vacio)
        {
        mensaje = "Ingrese un dato valido " + vacio.Message;
      }

      catch (NoEsUnFlotanteException error)
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
    public static string ConectarDB(string nombre, string descripcion, string costo, string porcentaje, string tipo, List<MateriaPrima> lista)
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
              ProductoFabricacion nuevoProducto2 = new ProductoFabricacion(nombre, descripcion, costoFloat, lista);
              nuevoProducto2.CalcularPrecioVenta(porcFloat);
              SetResponse response = client.Set("Productos/" + nuevoProducto2.IdProducto, nuevoProducto2);
              mensajeSalida = "Se creó el Producto con ID: " + nuevoProducto2.IdProducto;
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

    /// <summary>
    /// Busca un producto por su nombre en la BD. Retorna un producto
    /// </summary>
    /// <param name="nombre"></param>
    /// <param name="producto"></param>
    /// <returns>
    /// Retorna un producto, sino devuelve un producto nulo.
    /// </returns>
    public static Producto BuscarProductoPorNombre(string nombre)
    {
      string mensajeSalida = string.Empty;
       Producto producto = null;
      try
      {
        var client = ConexionDatos.ConectarBD();
          for (int i = 1001; i <1100; i++)
          {
           FirebaseResponse response =  client.Get("Productos/" +i);
           Producto productoBuscado = response.ResultAs<Producto>();

          if (productoBuscado.NombreProducto == nombre)
            {
            producto = productoBuscado;
            mensajeSalida = "Producto Encontrado";
            break;
          }
          }
        
      }
      catch (Exception cv)
      {
        mensajeSalida = "No se encontró el producto";
      }

      return producto;
    }
    /// <summary>
    /// Busca un producto en la BD por id. Retorna un producto
    /// </summary>
    /// <param name="id"></param>
    /// <param name="productoBuscado"></param>
    /// <returns>
    ///Retorna un producto, sino devuelve un producto nulo.
    /// </returns>
    public static Producto BuscarProductoPorID(string id)
    {
      string mensajeSalida = string.Empty;
      Producto productoBuscado = null;
      string mensaje;
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
              mensaje = "Producto Encontrado";
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
        mensaje = "No se encontro el producto";
      }

      return productoBuscado;
    }

  }
}
