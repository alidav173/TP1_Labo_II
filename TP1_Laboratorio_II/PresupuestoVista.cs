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
using Modelos;
using Modelos.Fabricacion;
using Controlador;

namespace TP1_Laboratorio_II
{
  public partial class PresupuestoVista : Form
  {
    DataTable dt = new DataTable();
    List<Producto> listado = new List<Producto>();
    List<string> impuestos = new List<string>();
    public PresupuestoVista()
    {
      InitializeComponent();
    }

    private void textBox4_TextChanged(object sender, EventArgs e)
    {

    }

    private void PresupuestoVista_Load(object sender, EventArgs e)
    {
      foreach (var tipos in Enum.GetValues(typeof(Modelos.Cliente.tipoCliente)))
      {
      listBoxTipoCliente.Items.Add(tipos);
      }

      foreach (var tipos in Enum.GetValues(typeof(Modelos.Presupuesto.tipoImpuesto)))
      {
        checkedListBox1.Items.Add(tipos);
      }
    }

    private void btnCrearPres_Click(object sender, EventArgs e)
    {
      try {
        string razonSocial = txtBxNombreCliente.Text;
        string cuit = txtbxCuit.Text;
        string tipoCliente = listBoxTipoCliente.SelectedItem.ToString();
        for (int i = 0; i < checkedListBox1.Items.Count - 1; i++)
        {
          if (checkedListBox1.GetItemChecked(i))
          {
            impuestos.Add(checkedListBox1.Items[i].ToString());
          }

        }
        MessageBox.Show(ControladorPresupuesto.ConectarDB(razonSocial, cuit, tipoCliente, listado, impuestos));

      }
      catch (Exception ex)
      {
        MessageBox.Show("Ingrese el tipo de cliente o los impuestos");
      }

    }

    private void listBoxTipoCliente_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private void txtBxNombreCliente_TextChanged(object sender, EventArgs e)
    {

    }

    private void btnAgregarCliente_Click(object sender, EventArgs e)
    {
      string mensaje = string.Empty;
      try
      {
        string razonSocial = txtBxNombreCliente.Text;
        string cuit = txtbxCuit.Text;
        string tipoCliente = listBoxTipoCliente.SelectedItem.ToString();
        mensaje = ControladorCliente.ConectarDB(cuit, razonSocial, tipoCliente);
        MessageBox.Show(mensaje);
      }
      catch (Exception ex)
      {
        mensaje = "Ingrese un tipo de cliente";
        MessageBox.Show(mensaje);
      }
    }

    private async void btnAgregarProducto_Click(object sender, EventArgs e)
    {
       ListadoProductos lp = new ListadoProductos();
       lp.Show();
       listado = lp.lista;

    }

    private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
