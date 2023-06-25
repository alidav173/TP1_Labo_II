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
  public partial class BuscarProducto : Form
  {
    public BuscarProducto()
    {
      InitializeComponent();
    }

    private void BuscarProducto_Load(object sender, EventArgs e)
    {

    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox2_TextChanged(object sender, EventArgs e)
    {

    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        string Id = textBox1.Text;
        int Idint;
        if (!string.IsNullOrEmpty(Id) & int.TryParse(Id, out Idint) == true)
        {
          Producto productoBuscado = ControladorProducto.BuscarPorID(Id);
          if (productoBuscado != null)
          {
            MessageBox.Show(productoBuscado.MostrarDatos());
            textBox2.Text = productoBuscado.Nombre;
            textBox3.Text = productoBuscado.Costo.ToString();
            textBox4.Text = productoBuscado.Descripcion;
            textBox5.Text = productoBuscado.Precio.ToString();
            this.Close();
          }
          else
          {
            MessageBox.Show("No se ha encontrado el producto");
          }
        }
        else if (string.IsNullOrEmpty(Id))
        {
          throw new CadenaVaciaException();
        }
        else if (int.TryParse(Id,out Idint) == false)
        {
          throw new NoEsUnEnteroException();
        }
      }
      catch (CadenaVaciaException cv)
      {
        MessageBox.Show("Ingrese un ID de producto");
      }
      catch(NoEsUnEnteroException ex)
      {
        MessageBox.Show("No es un numero entero");
      }

    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox3_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void button3_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void button2_Click(object sender, EventArgs e)
    {
      try
      {
        string nombre = textBox2.Text;
        if (!string.IsNullOrEmpty(nombre))
        {

          Producto productoBuscado = ControladorProducto.BuscarProductoPorNombre(nombre);
          if (productoBuscado != null)
          {
            MessageBox.Show(productoBuscado.MostrarDatos());
            textBox1.Text = productoBuscado.Id.ToString();
            textBox3.Text = productoBuscado.Costo.ToString();
            textBox4.Text = productoBuscado.Descripcion;
            textBox5.Text = productoBuscado.Precio.ToString();
            this.Close();
          }
          else
          {
            MessageBox.Show("No se ha encontrado el producto");
          }
        }
        else
        {
          throw new CadenaVaciaException();
        }
      }
      catch (CadenaVaciaException cv)
      {
        MessageBox.Show("Ingrese un nombre del producto");
      }
    }
  }
}
