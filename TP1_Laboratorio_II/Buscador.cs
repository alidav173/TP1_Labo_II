using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Modelos;

namespace TP1_Laboratorio_II
{
  public partial class Buscador : Form
  {
    Usuario usuarioBuscado;
    public Buscador()
    {
      InitializeComponent();
    }

    private void Buscador_Load(object sender, EventArgs e)
    {
      foreach (var tipos in Enum.GetValues(typeof(Usuario.TiposUsuario)))
      {
        listBox1.Items.Add(tipos);
      }
    }

    private void btnBuscarID_Click(object sender, EventArgs e)
    {
      string id = txtBxId.Text;
      ControladorBase bs = new ControladorBase();
      MessageBox.Show(bs.buscarObjetoPorID(int.Parse(id), "Usuarios", out usuarioBuscado));
      if (usuarioBuscado != null)
      {
        txtBxId2.Text = usuarioBuscado.Id.ToString();
        txtBxNombre.Text = usuarioBuscado.Nombre;
        txtBxApellido.Text = usuarioBuscado.Apellido;
        txtBxDni.Text = usuarioBuscado.Dni.ToString();
        txtBxEmail.Text = usuarioBuscado.Email;
        txtBxContraseña.Text = usuarioBuscado.Contraseña;
      }
    }

    private void btnBuscarValor_Click(object sender, EventArgs e)
    {
      string campo = txtBxCampo.Text;
      string valor = txtBxValor.Text;
      ControladorBase bs = new ControladorBase();
      MessageBox.Show(bs.buscarObjetoPorCampo(valor, campo, "Usuarios", out usuarioBuscado));
      if (usuarioBuscado != null)
      {
        txtBxId2.Text = usuarioBuscado.Id.ToString();
        txtBxNombre.Text = usuarioBuscado.Nombre;
        txtBxApellido.Text = usuarioBuscado.Apellido;
        txtBxDni.Text = usuarioBuscado.Dni.ToString();
        txtBxEmail.Text = usuarioBuscado.Email;
        txtBxContraseña.Text = usuarioBuscado.Contraseña;
      }
    }

    private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      try
      {
        string nombre = txtBxNombre.Text;
        string apellido = txtBxApellido.Text;
        string id = txtBxId2.Text;
        usuarioBuscado.Nombre = nombre;
        usuarioBuscado.Apellido = apellido;
        ControladorBase bs = new ControladorBase();
        MessageBox.Show(bs.Modificar(usuarioBuscado, "Usuarios", int.Parse(id)));
        this.Close();

      }
      catch (CadenaVaciaException ex)
      {
        MessageBox.Show("Ingrese los datos correspondientes");
      }
      catch (Exception ex2)
      {
        MessageBox.Show("Ingrese los datos correspondientes");
      }

    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txtBxId.Text;
        ControladorBase bs = new ControladorBase();
        MessageBox.Show(bs.Eliminar(int.Parse(id),"Usuarios"));
        this.Close();

      }
  
      catch (CadenaVaciaException ex)
      {
        MessageBox.Show("Ingrese los datos correspondientes");
      }
      catch (Exception ex2)
      {
        MessageBox.Show("Ingrese los datos correspondientes");
      }

    }
  }
}
