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
  }
}
