using Controlador;
using Data;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Google.Protobuf.WellKnownTypes;
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
using Enum = System.Enum;

namespace TP1_Laboratorio_II
{
  public partial class RegistroVista : Form
  {
    public RegistroVista()
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
      foreach (var tipos in Enum.GetValues(typeof(Usuario.TiposUsuario)))
      {
        listBox_Usuario.Items.Add(tipos);
      }
    }

    private void btn_Registrar_Click(object sender, EventArgs e)
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
        //ControladorBase controladorUno = new ControladorBase();
        Usuario usuarioNuevo = new Usuario(email,contraseña,nombre,apellido);
        usuarioNuevo.TipoUsuario = 1;
        usuarioNuevo.Dni = dni;
        //string mensaje = ControladorRegistro.ConectarDB(email, contraseña, rContraseña, nombre, apellido, tipoUsuario,dni);
       // MessageBox.Show(controladorUno.Agregar(usuarioNuevo,"Usuarios"));
        this.Close();

      }
      catch (NullReferenceException ex)
      {
        MessageBox.Show("Ingrese el tipo de usuario");
      }

    }

    private void listBox_Usuario_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    private void btn_Cancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void textBox6_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
