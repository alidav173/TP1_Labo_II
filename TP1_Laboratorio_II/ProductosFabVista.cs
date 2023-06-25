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
  public partial class ProductosFabVista : Form
  {
    DataTable dt = new DataTable();
    List<MateriaPrima> lista = new List<MateriaPrima>();
    public ProductosFabVista()
    {
      InitializeComponent();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      ListadoMateriaPrima nMaterial = new ListadoMateriaPrima();
      nMaterial.Show();
      dt.Columns.Add("Id");
      dt.Columns.Add("Nombre");
      dt.Columns.Add("Descripción");
      dt.Columns.Add("Precio");
      dt.Columns.Add("Tipo Material");
      dt.Columns.Add("Unidad de Medida");
      dt.Columns.Add("Cantidad");

      dataGridView1.DataSource = dt;
      lista = nMaterial.lista;
      foreach (MateriaPrima mp in lista)
      {
        DataRow row = dt.NewRow();
        row["Id"] = mp.Id;
        row["Nombre"] = mp.Nombre;
        row["Descripción"] = mp.Descripcion;
        row["Precio"] = mp.Precio;
        row["Tipo Material"] = mp.TipoMaterial;
        row["Unidad de Medida"] = mp.UnidadMedida;
        row["Cantidad"] = mp.Cantidad;
        dt.Rows.Add(row);
      }
    }

    private async void button2_Click(object sender, EventArgs e)
    {
      try
      {
        string nombreProducto = textBox2.Text;
        string descripcion = textBox3.Text;
        //string tipo = listBox1.SelectedItem.ToString();
        string costoProducto = textBox6.Text;
        string porcentajeGanancia = textBox4.Text;
        string mensajeControlador = ControladorProducto.Agregar(nombreProducto, descripcion, costoProducto, porcentajeGanancia,Producto.tipoProducto.Fabricacion.ToString(), lista);
        MessageBox.Show(mensajeControlador);
        if (mensajeControlador.Contains("Se creó el Producto"))
        {
          this.Close();
        }

      }
      catch (Exception ex)
      {
        MessageBox.Show("Ha ocurrido un error");
      }
    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private async void ProductosFab_Load(object sender, EventArgs e)
    {
      /*
      dt.Columns.Add("Id");
      dt.Columns.Add("Nombre");
      dt.Columns.Add("Descripción");
      dt.Columns.Add("Precio");
      dt.Columns.Add("Tipo Material");
      dt.Columns.Add("Unidad de Medida");
      dt.Columns.Add("Cantidad");

      dataGridView1.DataSource = dt;
      ListadoMateriaPrima lmp = new ListadoMateriaPrima();
      lista = lmp.lista;
      foreach (MateriaPrima mp in lista)
      {
        DataRow row = dt.NewRow();
        row["Id"] = mp.Id;
        row["Nombre"] = mp.Nombre;
        row["Descripción"] = mp.Descripcion;
        row["Precio"] = mp.Precio;
        row["Tipo Material"] = mp.TipoMaterial;
        row["Unidad de Medida"] = mp.UnidadMedida;
        row["Cantidad"] = mp.Cantidad;
        dt.Rows.Add(row);
      }*/
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void selectedRowsButton_Click(object sender, EventArgs e)
    {

    }
  }
}
