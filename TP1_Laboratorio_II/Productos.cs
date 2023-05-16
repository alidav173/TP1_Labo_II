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

namespace TP1_Laboratorio_II
{
  public partial class Productos : Form
  {
    public Productos()
    {
      InitializeComponent();

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void Producto_Load(object sender, EventArgs e)
    {
      foreach (var tipos in Enum.GetValues(typeof(Modelos.Fabricacion.Producto.tipoProducto)))
      {
        listBox1.Items.Add(tipos);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        string nombreProducto = textBox2.Text;
        string descripcion = textBox3.Text;
        string tipo = listBox1.SelectedItem.ToString();
        string costoProducto = textBox6.Text;
        float costoProdNum;
        float.TryParse(costoProducto, out costoProdNum);


        //despues buscar donde poner la logica
        if (validarDatos(nombreProducto, descripcion, tipo, costoProdNum))
        {
          if (tipo == "Fabricacion")
          {
            var listMateriales = new List<MateriaPrima>();
            var productoNuevo = new ProductoFabricacion(nombreProducto, descripcion, listMateriales);
            productoNuevo.CostoProducto = 0;
            MessageBox.Show("Ingrese los materiales que componen el producto de fabricación");
            MessageBox.Show(productoNuevo.MostrarDatos());

          }
          else if (tipo == "Reventa")
          {

            var productoNuevo2 = new ProductoReventa(nombreProducto, descripcion, costoProdNum);
            MessageBox.Show(productoNuevo2.MostrarDatos());

          }
        }
        else
        {
          MessageBox.Show("Ingrese todos los datos del producto");
        }

        this.Close();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Seleccione un valor de la lista");
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

    public bool validarDatos(string nombre, string descripcion, string tipo, float costo)
    {
      bool flag = false;

        if (nombre != string.Empty & descripcion != string.Empty & tipo != string.Empty & costo >= 0)
        {
          flag = true;
        }
      
      return flag;
    }
  }
}
