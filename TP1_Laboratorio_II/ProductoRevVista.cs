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
using Data;
using Firebase.Auth.Requests;
using Controlador;

namespace TP1_Laboratorio_II
{
  public partial class ProductoRevVista : Form
  {
    public ProductoRevVista()
    {
      InitializeComponent();

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void Producto_Load(object sender, EventArgs e)
    {
      /*foreach (var tipos in Enum.GetValues(typeof(Modelos.Fabricacion.Producto.tipoProducto)))
      {
        listBox1.Items.Add(tipos);
      }*/
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        string nombreProducto = textBox2.Text;
        string descripcion = textBox3.Text;
        //string tipo = listBox1.SelectedItem.ToString();
        string costoProducto = textBox6.Text;
        string porcentajeGanancia = textBox4.Text;
        List<MateriaPrima> lista = new List<MateriaPrima>();
        string mensajeControlador = ControladorProducto.Agregar(nombreProducto, descripcion, costoProducto, porcentajeGanancia, Producto.tipoProducto.Reventa.ToString(), lista);
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

    private void button2_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {
  
     
    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void label7_Click(object sender, EventArgs e)
    {

    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
