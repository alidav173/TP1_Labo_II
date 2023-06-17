using Controlador;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Modelos;
using Modelos.Fabricacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TP1_Laboratorio_II
{
  public partial class MateriaPrimaVista : Form
  {
    IFirebaseConfig config = new FirebaseConfig
    {
      AuthSecret = "Ftl3sYMwIdMqDoMLCwOKFGOrpK7bn1RUn2QGzh7b",
      BasePath = "https://pruebaapp-39ea7-default-rtdb.firebaseio.com/"
    };

    IFirebaseClient client;
    public MateriaPrimaVista()
    {
      InitializeComponent();
    }

    private void Material_Load(object sender, EventArgs e)
    {
      client = new FireSharp.FirebaseClient(config);
      foreach (var tipos in Enum.GetValues(typeof(Modelos.Fabricacion.MateriaPrima.tipoMaterial)))
      {
        listBox1.Items.Add(tipos);
      }
    }

    private async void button1_Click(object sender, EventArgs e)
    {
      crearMaterial();
    /*  try
      {
        string nombreMaterial = textBox2.Text;
        string descripcion = textBox3.Text;
        string tipo = listBox1.SelectedItem.ToString();
        string precio = textBox4.Text;
        string unidadMedida = textBox5.Text;
        string mensajeControlador = ControladorMaterial.ConectarDBMaterial(nombreMaterial, descripcion, tipo, precio, unidadMedida);

          if(mensajeControlador.Contains("Se creó el material con ID"))
          {
            /*var nuevoMaterial = new MateriaPrima(nombreMaterial, descripcion, tipo, precioMaterial, unidadMedida);
            SetResponse response = await client.SetTaskAsync("Materiales/" + nuevoMaterial.Id, nuevoMaterial);
            //MateriaPrima result = response.ResultAs<MateriaPrima>();
            MessageBox.Show(mensajeControlador);
            this.Close();
        }
          else
          {
            MessageBox.Show(mensajeControlador);
          }
             
      }
      catch (NullReferenceException ex)
      {
        MessageBox.Show("Seleccione el tipo de material");
      }
*/
    }


    private void label6_Click(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged(object sender, EventArgs e)
    {

    }

    private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void textBox5_TextChanged_1(object sender, EventArgs e)
    {

    }

    private void button2_Click(object sender, EventArgs e)
    {
      ListadoProductosFab listFab = new ListadoProductosFab();
      listFab.Show();

      //crearMaterial();
    }

    private void crearMaterial()
    {
      try
      {
        string nombreMaterial = textBox2.Text;
        string descripcion = textBox3.Text;
        string tipo = listBox1.SelectedItem.ToString();
        string precio = textBox4.Text;
        string unidadMedida = textBox5.Text;
        string mensajeControlador = ControladorMaterial.ConectarDBMaterial(nombreMaterial, descripcion, tipo, precio, unidadMedida);

        if (mensajeControlador.Contains("Se creó el material con ID"))
        {
          MessageBox.Show(mensajeControlador);
          this.Close();
        }
        else
        {
          MessageBox.Show(mensajeControlador);
        }

      }
      catch (NullReferenceException ex)
      {
        MessageBox.Show("Seleccione el tipo de material");
      }

    }
  }
}
