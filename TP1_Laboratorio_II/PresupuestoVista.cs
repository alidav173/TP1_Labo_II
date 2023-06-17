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
  public partial class PresupuestoVista : Form
  {
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

    }
  }
}
