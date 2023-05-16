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
  public partial class PantallaPrincipal : Form
  {
    public PantallaPrincipal()
    {
      InitializeComponent();
      IsMdiContainer = true;
    }

    private void btn_registro_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void PantallaPrincipal_Load(object sender, EventArgs e)
    {

    }

    private void PantallaPrincipal_Load_1(object sender, EventArgs e)
    {

    }

    private void acercaDelProductoToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void toolStripMenuItem7_Click(object sender, EventArgs e)
    {
      AboutIt ai = new AboutIt();
      ai.Show();
    }

    private void toolStripMenuItem4_Click(object sender, EventArgs e)
    {
      Login lg = new Login();
      lg.Show();
    }

    private void toolStripMenuItem5_Click(object sender, EventArgs e)
    {
      Registro rg = new Registro();
      rg.Show();
    }

    private void toolStripMenuItem8_Click(object sender, EventArgs e)
    {
      Contacto ct = new Contacto();
      ct.Show();
    }

    private void toolStripMenuItem6_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void nuevoProductoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Productos prdto = new Productos();
      prdto.Show();
    }

    private void nuevoMaterialToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Material nuevoMaterial = new Material();
      nuevoMaterial.Show();
    }
  }
}
