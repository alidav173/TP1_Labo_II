using Controlador;
using Data;
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
using Modelos;
using TP1_Laboratorio_II.Controlador;

namespace TP1_Laboratorio_II
{
  public partial class ListadoClientes : Form
  {
    DataTable dt = new DataTable();
    public List<Cliente> lista = new List<Cliente>();
    public ListadoClientes()
    {
      InitializeComponent();
    }

    private void btnCerrar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void ListadoClientes_Load(object sender, EventArgs e)
    {
      dt.Columns.Add("Id");
      dt.Columns.Add("Razon Social");
      dt.Columns.Add("Cuit");
      dt.Columns.Add("Email");
      dt.Columns.Add("Telefono");
      dt.Columns.Add("Direccion");
      dt.Columns.Add("Tipo Cliente");

      dataGridView1.DataSource = dt;
      Cliente clienteNuevo;
      int Id = 1;
      clienteNuevo = ControladorCliente.BuscarPorId(Id);
      while (clienteNuevo != null)
      {
        DataRow row = dt.NewRow();
        row["Id"] = clienteNuevo.Id;
        row["Razon Social"] = clienteNuevo.RazonSocial;
        row["Cuit"] = clienteNuevo.Cuit;
        row["Email"] = clienteNuevo.Email;
        row["Telefono"] = clienteNuevo.Telefono;
        row["Direccion"] = clienteNuevo.Direccion;
        row["Tipo Cliente"] = clienteNuevo.TipoCliente;
        dt.Rows.Add(row);
        Id++;
        clienteNuevo = ControladorCliente.BuscarPorId(Id);
      }
    }
  }
}
