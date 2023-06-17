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

    private void button1_Click(object sender, EventArgs e)
    {
      MateriaPrimaVista nMaterial = new MateriaPrimaVista();
      nMaterial.Show();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        string nombreProducto = textBox2.Text;
        string descripcion = textBox3.Text;
        //string tipo = listBox1.SelectedItem.ToString();
        string costoProducto = textBox6.Text;
        string porcentajeGanancia = textBox4.Text;
        string mensajeControlador = ControladorProducto.ConectarDB(nombreProducto, descripcion, costoProducto, porcentajeGanancia,Producto.tipoProducto.Fabricacion.ToString());
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
      dt.Columns.Add("Id");
      dt.Columns.Add("Nombre");
      dt.Columns.Add("Descripción");
      dt.Columns.Add("Precio");
      dt.Columns.Add("Tipo Material");
      dt.Columns.Add("Unidad de Medida");

      dataGridView1.DataSource = dt;
      MateriaPrima mpNueva;
      int Id = 1;
      mpNueva = ControladorMaterial.BuscarMaterialPorID(ParserCSV.ConvertirIntAString(Id));
      while (mpNueva != null)
      {
          DataRow row = dt.NewRow();
          row["Id"] = mpNueva.Id;
          row["Nombre"] = mpNueva.Nombre;
          row["Descripción"] = mpNueva.Descripcion;
          row["Precio"] = mpNueva.Precio;
          row["Tipo Material"] = mpNueva.TipoMaterial;
          row["Unidad de Medida"] = mpNueva.UnidadMedida;
          dt.Rows.Add(row);
          Id++;

        mpNueva = ControladorMaterial.BuscarMaterialPorID(ParserCSV.ConvertirIntAString(Id));
      }
    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }
  }
}
