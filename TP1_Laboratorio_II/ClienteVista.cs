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
using TP1_Laboratorio_II.Controlador;

namespace TP1_Laboratorio_II
{
  public partial class ClienteVista : Form
  {
    public ClienteVista()
    {
      InitializeComponent();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnAgregar_Click(object sender, EventArgs e)
    {
      string mensaje = String.Empty;
      try
      {
        string razonSocial = txtBxRazonSocial.Text;
        string cuit = txtbxCuit.Text;
        string tipoCLiente = listBoxTipoCliente.SelectedItem.ToString();
        string email = txtBxEmail.Text;
        string direccion = txtBxDireccion.Text;
        string telefono = txtBxTelefono.Text;
        mensaje = ControladorCliente.Agregar(cuit, razonSocial, tipoCLiente, direccion, email, int.Parse(telefono));
        MessageBox.Show(mensaje);
        this.Close();

      }
    catch(Exception ex)
      {
        mensaje = "Seleccione el tipo de cliente";
        MessageBox.Show(mensaje);
      }
    }

    private void ClienteVista_Load(object sender, EventArgs e)
    {
      foreach (var tipos in Enum.GetValues(typeof(Modelos.Cliente.tipoCliente)))
      {
        listBoxTipoCliente.Items.Add(tipos);
      }
    }

    private void btnActualizar_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txtBxID.Text;
        Cliente clienteNuevo = ControladorCliente.BuscarPorId(int.Parse(id));
        clienteNuevo.Cuit = int.Parse(txtbxCuit.Text);
        clienteNuevo.RazonSocial = txtBxRazonSocial.Text;
        clienteNuevo.Email = txtBxEmail.Text;
        clienteNuevo.Direccion = txtBxDireccion.Text;
        clienteNuevo.Telefono = int.Parse(txtBxTelefono.Text);
        string mensaje = ControladorCliente.Actualizar(clienteNuevo);
        MessageBox.Show(mensaje);
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error");
      }
    }

    private void btnBuscarPorID_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txtBxID.Text;
        Cliente clienteNuevo = ControladorCliente.BuscarPorId(int.Parse(id));
        if (clienteNuevo is not null)
        {
          MessageBox.Show("Cliente encontrado");
        }
        txtbxCuit.Text = clienteNuevo.Cuit.ToString();
        txtBxRazonSocial.Text = clienteNuevo.RazonSocial;
        txtBxEmail.Text = clienteNuevo.Email;
        txtBxDireccion.Text = clienteNuevo.Direccion;
        txtBxTelefono.Text = clienteNuevo.Telefono.ToString();
      }
      catch (Exception ex)
      {
        MessageBox.Show("Error. Cliente no encontrado");
      }

    }
  }
}
