using Data;
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
  public partial class AboutIt : Form
  {
    public AboutIt()
    {
      InitializeComponent();
      this.IsMdiContainer = true;
      textBox1.Text = Archivo.leerDesdeTxt("C:\\Users\\alida\\source\\repos\\TP1_Laboratorio_II\\Acerca_de.txt");
    }

    private void AboutIt_Load(object sender, EventArgs e)
    {
      
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }

    private void btn_Aceptar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
