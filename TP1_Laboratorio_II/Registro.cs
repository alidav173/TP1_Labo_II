using Controlador;
using Data;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Modelos;
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
  public partial class Registro : Form
  {
   /* IFirebaseConfig config = new FirebaseConfig
    {
      AuthSecret = "Ftl3sYMwIdMqDoMLCwOKFGOrpK7bn1RUn2QGzh7b",
      BasePath = "https://pruebaapp-39ea7-default-rtdb.firebaseio.com/"
    };

    IFirebaseClient client;*/
    public Registro()
    {
    
      InitializeComponent();
      
    }

    private void label1_Click(object sender, EventArgs e)
    {

    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void label3_Click(object sender, EventArgs e)
    {

    }

    private void label4_Click(object sender, EventArgs e)
    {

    }

    private void label8_Click(object sender, EventArgs e)
    {

    }

    private void label5_Click(object sender, EventArgs e)
    {

    }

    private void Registro_Load(object sender, EventArgs e)
    {
      //cambiar por try catch
      /*client = new FireSharp.FirebaseClient(config);

      if (client is not null)
      {
        MessageBox.Show("Conexión establecida");
      }*/
      foreach (var tipos in Enum.GetValues(typeof(Usuario.TiposUsuario)))
      {
        listBox_Usuario.Items.Add(tipos);
      }
    }

    private async void btn_Registrar_Click(object sender, EventArgs e)
    {
      try
      {
        string nombre = textBox1.Text;
        string apellido = textBox2.Text;
        int dni;
        int.TryParse(textBox3.Text, out dni);
        string email = textBox4.Text;
        string contraseña = textBox5.Text;
        string rContraseña = textBox6.Text;
        string ?tipoUsuario = listBox_Usuario.SelectedItem.ToString();
        string mensajeControlador = ControladorRegistro.ValidarDatosUsuario(email, contraseña, nombre, apellido);
        if (mensajeControlador == "datos validos" & contraseña == rContraseña)
        {
           var usuarioNuevo = new Usuario(email, contraseña, nombre, apellido);
          if (ControladorRegistro.ValidarDni(dni))
          {
            usuarioNuevo.Dni = dni;
          }
            usuarioNuevo.TipoUsuario = tipoUsuario;
            var client = ConexionDatos.ConectarBD();
            SetResponse response = await client.SetTaskAsync("Usuarios/" + usuarioNuevo.Id, usuarioNuevo);
          
          //primer parametro es el nombre de la coleccion
          
          //Usuario result = response.ResultAs<Usuario>();
          MessageBox.Show("Se creó el Usuario con ID: " + usuarioNuevo.Id);
          MessageBox.Show(usuarioNuevo.MostrarDatos());
          this.Close();
        }
        else
        {
          MessageBox.Show(mensajeControlador);
        }

      }
      catch (NullReferenceException ex)
      {
        MessageBox.Show("Ingrese el tipo de usuario");
      }

    }

    private void listBox_Usuario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

   /* private bool validarDatosUsuario(string email, string contraseña, string nombre, string apellido)
    {
      bool flag = false;

      if (!string.IsNullOrEmpty(email) & !string.IsNullOrEmpty(contraseña) & !string.IsNullOrEmpty(nombre) & !string.IsNullOrEmpty(apellido))
      {
        if (Validador.esEmailValido(email) == true & Validador.esContraseñaValida(contraseña))
        {
          flag = true;
        }
      }
      return flag;
    }*/

    private void btn_Cancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
