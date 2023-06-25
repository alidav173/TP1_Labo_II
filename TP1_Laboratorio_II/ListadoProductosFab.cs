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
  public partial class ListadoProductosFab : Form
  {
    DataTable dt = new DataTable();
    public ListadoProductosFab()
    {
      InitializeComponent();
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private async void ListadoProductosFab_Load(object sender, EventArgs e)
    {
      MessageBox.Show("Ingrese el id del producto al cual desea agregar el material");
      dt.Columns.Add("Id");
      dt.Columns.Add("Nombre");
      dt.Columns.Add("Descripción");
      dt.Columns.Add("Costo");
      dt.Columns.Add("Precio");

      dataGridView1.DataSource = dt;
      
      Producto productoNuevo; 
      int Id = 1001;
      productoNuevo = ControladorProducto.BuscarPorID(Id.ToString());
      while (productoNuevo != null)
      {
        if (productoNuevo.TipoProducto == "Fabricacion")
        {
          DataRow row = dt.NewRow();
          row["Id"] = productoNuevo.Id;
          row["Nombre"] = productoNuevo.Nombre;
          row["Descripción"] = productoNuevo.Descripcion;
          row["Costo"] = productoNuevo.Costo;
          row["Precio"] = productoNuevo.Precio;
          dt.Rows.Add(row);
        }
        Id++;
        
        productoNuevo = ControladorProducto.BuscarPorID(Id.ToString());
      }
    
    }
  }
}
