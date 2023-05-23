using Controlador;
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
  public partial class ProductosFab : Form
  {
    public ProductosFab()
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
      Material nMaterial = new Material();
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
  }
}
