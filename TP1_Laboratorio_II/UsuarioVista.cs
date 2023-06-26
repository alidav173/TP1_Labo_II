using Controlador;
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
  public partial class UsuarioVista : Form
  {
    public UsuarioVista()
    {
      InitializeComponent();
    }

    private void UsuarioVista_Load(object sender, EventArgs e)
    {
      foreach (var tipos in Enum.GetValues(typeof(Usuario.TiposUsuario)))
      {
       listBoxTipoUsuario.Items.Add(tipos);
      }
    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txtBxID.Text;
        Usuario usuario = ControladorUsuario.BuscarPorId(int.Parse(id));
        txtNombre.Text = usuario.Nombre;
        txtApellido.Text = usuario.Apellido;
        txtBxEmail.Text = usuario.Email;
        txtBxContraseña.Text = usuario.Contraseña;
        txtBxRContraseña.Text = usuario.Contraseña;
        txtBxDni.Text = usuario.Dni.ToString();
        listBoxTipoUsuario.SelectedItem = usuario.TipoUsuario;
      }
      catch (NoEsUnEnteroException ex)
      {
        MessageBox.Show("Ingrese un Id válido");
      }
      catch (NullReferenceException ex2)
      {
        MessageBox.Show("No se encontró al usuario");
      }
      
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnModificar_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txtBxID.Text;
        Usuario usuarioModificado = ControladorUsuario.BuscarPorId(int.Parse(id));
        string nombre = txtNombre.Text;
        string apellido = txtApellido.Text;
        string email = txtBxEmail.Text;
        string contraseña = txtBxContraseña.Text;
        string rContraseña = txtBxRContraseña.Text;
        string dni = txtBxDni.Text;
        string tipoUsuario = listBoxTipoUsuario.SelectedItem.ToString();
        if (contraseña == rContraseña)
        {
          usuarioModificado.Nombre = nombre;
          usuarioModificado.Apellido = apellido;
          usuarioModificado.Email = email;
          usuarioModificado.Dni = int.Parse(dni);
          usuarioModificado.Contraseña = contraseña;
          usuarioModificado.TipoUsuario = tipoUsuario;
          MessageBox.Show(ControladorUsuario.Actualizar(usuarioModificado));
          this.Close();
        }

      }
      catch (NoEsUnEnteroException ex)
      {
        MessageBox.Show("Ingrese un dni valido");
      }
      catch (CadenaVaciaException ex)
      {
        MessageBox.Show("Ingrese una contraseña valida");
      }
      catch (NullReferenceException ex3)
      {
        MessageBox.Show("Escoja el tipo de usuario");
      }
      catch (Exception ex4)
      {
        MessageBox.Show("Error" + ex4);
      }

    }
  }
}
