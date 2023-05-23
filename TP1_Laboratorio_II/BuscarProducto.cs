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
        if (!string.IsNullOrEmpty(Id))
        {
          Producto productoBuscado;
           string mensaje =  ControladorProducto.BuscarProductoPorID(Id, out productoBuscado);
          if (mensaje ==  "Producto encontrado")
          {
            textBox2.Text = productoBuscado.NombreProducto;
            textBox3.Text = productoBuscado.CostoProducto.ToString();
            textBox4.Text = productoBuscado.DescripcionProducto;
            textBox5.Text = productoBuscado.PrecioProducto.ToString();
          }
          else
          {
            MessageBox.Show(mensaje);
          }
        }
        else
        {
          throw new CadenaVacia();
        }
      }
      catch (CadenaVacia cv)
      {
        MessageBox.Show("Ingrese un ID de producto");
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
          Producto productoBuscado;
          string mensaje = ControladorProducto.BuscarProductoPorNombre(nombre, out productoBuscado);
          if (mensaje == "Producto encontrado")
          {
            textBox1.Text = productoBuscado.IdProducto.ToString();
            textBox3.Text = productoBuscado.CostoProducto.ToString();
            textBox4.Text = productoBuscado.DescripcionProducto;
            textBox5.Text = productoBuscado.PrecioProducto.ToString();
          }
          else
          {
            MessageBox.Show(mensaje);
          }
        }
        else
        {
          throw new CadenaVacia();
        }
      }
      catch (CadenaVacia cv)
      {
        MessageBox.Show("Ingrese un ID de producto");
      }
    }
  }
}
