using Controlador;
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
      MessageBox.Show(ControladorCliente.ExportarAcsv(".\\Clientes.csv"));

    }

    private void exportarAJSONToolStripMenuItem_Click(object sender, EventArgs e)
    {
       MessageBox.Show(ControladorCliente.ExportarAJson(".\\Clientes.json"));
    }

    private void presupuestosToolStripMenuItem_Click(object sender, EventArgs e)
    {

    }

    private void exportarAPDFToolStripMenuItem_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ControladorCliente.ExportarApdf(".\\Clientes.pdf"));
    }

    private void exportarACSVToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ControladorPresupuesto.ExportarAcsv(".\\documentos\\csv\\Presupuestos.csv"));
    }

    private void exportarAJSONToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ControladorPresupuesto.ExportarAJson(".\\documentos\\json\\Presupuestos.json"));
    }

    private void exportarAPDFToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ControladorPresupuesto.ExportarApdf(".\\documentos\\pdf\\Presupuestos.pdf"));
    }

 
    private void exportarACSVToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ControladorUsuario.ExportarAcsv(".\\documentos\\csv\\Usuarios.csv"));
    }

    private void exportarAJSONToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      MessageBox.Show( ControladorUsuario.ExportarAJson(".\\documentos\\json\\Usuarios.json"));
    }

    private void exportarAPDFToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      MessageBox.Show(ControladorUsuario.ExportarApdf(".\\documentos\\pdf\\Usuarios.pdf"));
    }

    private void editarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
    {
      UsuarioVista uv = new UsuarioVista();
      uv.Show();
;    }

    private void editarMaterialToolStripMenuItem_Click(object sender, EventArgs e)
    {
      EditarMaterial em = new EditarMaterial();
      em.Show();
    }

    private void editarClienteToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ClienteVista cv = new ClienteVista();
      cv.Show();
    }
  }
}
