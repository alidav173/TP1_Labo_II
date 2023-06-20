using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data;
using System.Data;

namespace Controlador
{
  public class ControladorBase : ConsultaSQL
  {
    private List<Usuario> lista;

    public List<Usuario> Traer()
    {
      var usuarios = new List<Usuario>();

      try
      {

        DataTable data1 = EjecutarConsulta("SELECT * FROM Usuarios");
        foreach (DataRow row in data1.Rows)
        {
          Usuario usuario = new Usuario();
          usuario.Id = Convert.ToInt32(row["Id"]);
          usuario.Nombre = row["nombre"].ToString();
          usuario.Apellido = row["apellido"].ToString();
          usuario.Dni = Convert.ToInt32(row["dni"]);
          usuario.Email = row["email"].ToString();
          usuario.Contraseña = row["contraseña"].ToString();
          usuarios.Add(usuario);
        }

        return usuarios;

      }
      catch (Exception ex)
      {

        string message = "error " + ex;
        return usuarios;
      }

    }

    public string Agregar(Usuario usuarioNuevo, string nombreTabla)
    {
      string mensaje = String.Empty;

      try
      {
        StringBuilder sb = new StringBuilder();
        sb.Append($"INSERT INTO {nombreTabla} VALUES");
        sb.Append($"({usuarioNuevo.Id},'{usuarioNuevo.Nombre}','{usuarioNuevo.Apellido}',{usuarioNuevo.Dni},'{usuarioNuevo.Email}','{usuarioNuevo.Contraseña}',{usuarioNuevo.TipoUsuario})");
        EjecutarConsulta(sb.ToString());
        return mensaje = "Usuario agregado";
      }
      catch (Exception ex)
      {
        return mensaje = "Error" + ex;
      }

    }

    public string buscarObjetoPorID(int id, string nombreTabla, out Usuario usuarioBuscado)
    {
      string mensaje = "";
      usuarioBuscado = null;
      try
      {
        Usuario nuevoUsuario = new Usuario();
        StringBuilder sb = new StringBuilder();
        sb.Append($"SELECT * FROM {nombreTabla} WHERE Id ={id}");
        DataTable data1 = EjecutarConsulta(sb.ToString());
        foreach (DataRow row in data1.Rows)
        {
          nuevoUsuario.Id = Convert.ToInt32(row["Id"]);
          nuevoUsuario.Nombre = row["nombre"].ToString();
          nuevoUsuario.Apellido = row["apellido"].ToString();
          nuevoUsuario.Dni = Convert.ToInt32(row["dni"]);
          nuevoUsuario.Email = row["email"].ToString();
          nuevoUsuario.Contraseña = row["contraseña"].ToString();
        }

        if (nuevoUsuario.Id > 0)
        {
          usuarioBuscado = nuevoUsuario;

          return mensaje = "Usuario Encontrado";
        }
        else
        {
          usuarioBuscado = null;

          return mensaje = "Usuario Inexistente";


        }

      }
      catch (Exception ex)
      {
        usuarioBuscado = null;
        return mensaje + ex;
      }
    }


    public string buscarObjetoPorCampo(string valor,string campo, string nombreTabla, out Usuario usuarioBuscado)
    {
      string mensaje = "";
      usuarioBuscado = null;
      try
      {
        Usuario nuevoUsuario = new Usuario();
        StringBuilder sb = new StringBuilder();
        sb.Append($"SELECT * FROM {nombreTabla} WHERE {campo} ='{valor}'");
        DataTable data1 = EjecutarConsulta(sb.ToString());
        foreach (DataRow row in data1.Rows)
        {
          nuevoUsuario.Id = Convert.ToInt32(row["Id"]);
          nuevoUsuario.Nombre = row["nombre"].ToString();
          nuevoUsuario.Apellido = row["apellido"].ToString();
          nuevoUsuario.Dni = Convert.ToInt32(row["dni"]);
          nuevoUsuario.Email = row["email"].ToString();
          nuevoUsuario.Contraseña = row["contraseña"].ToString();
        }

        if (nuevoUsuario.Id > 0)
        {
          usuarioBuscado = nuevoUsuario;

          return mensaje = "Usuario Encontrado";
        }
        else
        {
          usuarioBuscado = null;

          return mensaje = "Usuario Inexistente";


        }

      }
      catch (Exception ex)
      {
        usuarioBuscado = null;
        return mensaje + ex;
      }
    }

    

    public string Modificar(Usuario usuarioNuevo, string nombreTabla, int id)
  {
        string mensaje = String.Empty;

    try
    {
      StringBuilder sb = new StringBuilder();
      sb.Append($"UPDATE {nombreTabla} SET nombre = '{usuarioNuevo.Nombre}', apellido = '{usuarioNuevo.Apellido}' WHERE Id = {id}");
      EjecutarConsulta(sb.ToString());
      return mensaje = "Usuario modificado";
    }
    catch (Exception ex)
    {
      return mensaje = "Error" + ex;
    }
  }

    
  public string Eliminar(int id, string nombreTabla)
  {
      string mensaje = String.Empty;
      try
      {
        StringBuilder sb = new StringBuilder();
        sb.Append($"DELETE FROM {nombreTabla} WHERE Id = {id}");
        EjecutarConsulta(sb.ToString());
        return mensaje = "Usuario eliminado";

      }
      catch (Exception ex)
      {
        return mensaje = "Error" + ex;
      }
    }
   
  }
  }

