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
      LoginVista lg = new LoginVista();
      lg.Show();
    }

    private void toolStripMenuItem5_Click(object sender, EventArgs e)
    {
      RegistroVista rg = new RegistroVista();
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
    }

    private void nuevoMaterialToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MateriaPrimaVista nuevoMaterial = new MateriaPrimaVista();
      nuevoMaterial.Show();
    }

    private void productoReventaToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ProductoRevVista prdto = new ProductoRevVista();
      prdto.Show();
    }

    private void productoFabricacionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ProductosFabVista pdFb = new ProductosFabVista();
      pdFb.Show();
    }

    private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      BuscarProducto bp = new BuscarProducto();
      bp.Show();
    }

    private void nuevoPresupuestoToolStripMenuItem_Click(object sender, EventArgs e)
    {
      PresupuestoVista pV = new PresupuestoVista();
      pV.Show();
    }

    private void listadoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Listado listadoUno = new Listado();
      listadoUno.Show();
    }

    private void buscarPorNomnreToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void nuevoClienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ClienteVista cv = new ClienteVista();
      cv.Show();
    }

    private void mostrarClientesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ListadoClientes lc = new ListadoClientes();
      lc.Show();
    }

    private void exportarACSVToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ControladorCliente.ExportarAcsv("C:\\Users\\alida\\source\\repos\\TP1_Laboratorio_II\\Clientes.csv"));

    }

    private void exportarAJSONToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ControladorCliente.ExportarAJson("C:\\Users\\alida\\source\\repos\\TP1_Laboratorio_II\\Clientes.json"));
    }

    private void presupuestosToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ControladorCliente.ExportarApdf("C:\\Users\\alida\\source\\repos\\TP1_Laboratorio_II\\Clientes.pdf"));
    }
  }
}
