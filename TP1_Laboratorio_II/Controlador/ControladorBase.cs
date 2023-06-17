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

    /*
    public int Modificar(Usuario usuarioNuevo)
    {

    }
    public int Eliminar(int id)
    {

    }
      */
  }
}
