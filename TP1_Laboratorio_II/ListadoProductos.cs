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

namespace TP1_Laboratorio_II
{
  public partial class ListadoProductos : Form
  {
    DataTable dt = new DataTable();
    public List<Producto> lista = new List<Producto>();
    public ListadoProductos()
    {
      InitializeComponent();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private async void btnAgregar_Click(object sender, EventArgs e)
    {
      int filasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
      if (filasSeleccionadas > 0)
      {

        string id;
        string nombre;
        string descripcion;
        string costo;
        string precio;
        string tipo;

        for (int i = 0; i < filasSeleccionadas; i++)
        {
          id = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();

          nombre = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();

          descripcion = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();

          costo = dataGridView1.SelectedRows[i].Cells[3].Value.ToString();

          precio = dataGridView1.SelectedRows[i].Cells[4].Value.ToString();

          tipo = dataGridView1.SelectedRows[i].Cells[5].Value.ToString();

          Producto productoNuevo = new Producto();
          productoNuevo.IdProducto = int.Parse(id);
          productoNuevo.NombreProducto = nombre;
          productoNuevo.DescripcionProducto = descripcion;
          productoNuevo.CostoProducto = float.Parse(costo);
          productoNuevo.PrecioProducto = float.Parse(precio);
          productoNuevo.TipoProducto = tipo;
          lista.Add(productoNuevo);
        }
      }
      this.Close();
    }

    private void ListadoProductos_Load(object sender, EventArgs e)
    {
      MessageBox.Show("Seleccione los productos agregar en el presupuesto");
      dt.Columns.Add("Id");
      dt.Columns.Add("Nombre");
      dt.Columns.Add("Descripción");
      dt.Columns.Add("Costo");
      dt.Columns.Add("Precio");

      dataGridView1.DataSource = dt;
      Producto productoNuevo;
      int Id = 1001;
      productoNuevo = ControladorProducto.BuscarProductoPorID(ParserCSV.ConvertirIntAString(Id));
      while (productoNuevo != null)
      {
          DataRow row = dt.NewRow();
          row["Id"] = productoNuevo.IdProducto;
          row["Nombre"] = productoNuevo.NombreProducto;
          row["Descripción"] = productoNuevo.DescripcionProducto;
          row["Costo"] = productoNuevo.CostoProducto;
          row["Precio"] = productoNuevo.PrecioProducto;
          dt.Rows.Add(row);
          Id++;
        productoNuevo = ControladorProducto.BuscarProductoPorID(ParserCSV.ConvertirIntAString(Id));
      }
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
