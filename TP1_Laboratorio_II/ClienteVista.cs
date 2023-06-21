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
        mensaje = ControladorCliente.ConectarDB(cuit, razonSocial, tipoCLiente);
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
  }
}
