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
  public partial class Contacto : Form
  {
    public Contacto()
    {
      InitializeComponent();
      this.IsMdiContainer = true;
      textBox1.Text = ParserCSV.leerDesdeTxt("C:\\Users\\alida\\source\\repos\\TP1_Laboratorio_II\\Contacto.txt");
    }

    private void textBox1_TextChanged(object sender, EventArgs e)
    {

    }
  }
}
