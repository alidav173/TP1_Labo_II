using Controlador;
using Data;
using Modelos;
using Modelos.Fabricacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP1_Laboratorio_II
{
  public partial class Listado : Form
  {
    DataTable dt = new DataTable();
    public Listado()
    {
      InitializeComponent();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private async void Listado_Load(object sender, EventArgs e)
    {
      dt.Columns.Add("Id");
      dt.Columns.Add("Nombre");
      dt.Columns.Add("Apellido");
      dt.Columns.Add("Dni");
      dt.Columns.Add("email");
      dt.Columns.Add("contraseña");
      dt.Columns.Add("tipo Usuario");

      dataGridView1.DataSource = dt;
      ControladorBase controladorUno = new ControladorBase();

      List<Usuario> lista = controladorUno.Traer();

      foreach(Usuario usuarioNuevo in lista)
      {
        DataRow row = dt.NewRow();
        row["Id"] = usuarioNuevo.Id;
        row["Nombre"] = usuarioNuevo.Nombre;
        row["Apellido"] = usuarioNuevo.Apellido;
        row["Dni"] = usuarioNuevo.Dni;
        row["email"] = usuarioNuevo.Email;
        row["contraseña"] = usuarioNuevo.Contraseña;
        row["tipo Usuario"] = usuarioNuevo.TipoUsuario;
        dt.Rows.Add(row);

      }
    }
  }
}
