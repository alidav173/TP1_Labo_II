using ceTe.DynamicPDF.PageElements.Forms;
using Controlador;
using Modelos.Fabricacion;
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
  public partial class EditarMaterial : Form
  {
    public EditarMaterial()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {

    }

    private void EditarMaterial_Load(object sender, EventArgs e)
    {
      foreach (var tipos in Enum.GetValues(typeof(Modelos.Fabricacion.MateriaPrima.tipoMaterial)))
      {
        listBoxTipoMaterial.Items.Add(tipos);
      }
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnActualizar2_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txtBxId.Text;
        string nombre = txtBxNombre.Text;
        string descripcion = txtBxDescripcion.Text;
        string precio = txtBxPrecio.Text;
        string unidadMedida = txtBxUnidadMedida.Text;
        string tipoMaterial = listBoxTipoMaterial.SelectedItem.ToString();
        string mensaje = ControladorMaterial.ValidarDatosMaterial(nombre, descripcion, tipoMaterial, precio, unidadMedida);
        if (mensaje == "datos validos")
        {
          MateriaPrima mpActualizada = new MateriaPrima();
          mpActualizada.Id = int.Parse(id);
          mpActualizada.Nombre = nombre;
          mpActualizada.Descripcion = descripcion;
          mpActualizada.Precio = float.Parse(precio);
          mpActualizada.TipoMaterial = tipoMaterial;
          mpActualizada.UnidadMedida = unidadMedida;
          MessageBox.Show(ControladorMaterial.Actualizar(mpActualizada));

        }
      }
      catch (NullReferenceException ex)
      {
        MessageBox.Show("Seleccione un tipo de material");
      }

    }

    private void btnBuscar_Click(object sender, EventArgs e)
    {
      try
      {
        string id = txtBxId.Text;
        MateriaPrima materialBuscado = ControladorMaterial.BuscarPorId(int.Parse(id));
        txtBxNombre.Text = materialBuscado.Nombre;
        txtBxDescripcion.Text = materialBuscado.Descripcion;
        txtBxPrecio.Text = materialBuscado.Precio.ToString();
        txtBxUnidadMedida.Text = materialBuscado.UnidadMedida;
        MessageBox.Show("Material encontrado");

      }
      catch (CadenaVaciaException ex)
      {
        MessageBox.Show("Ingrese un dato valido");
      }
      catch (NullReferenceException ex1)
      {
        MessageBox.Show("No se encontró el material");
      }
      catch (NoEsUnEnteroException ex2)
      {
        MessageBox.Show("Ingrese un Id válido");
      }
      catch (Exception ex3)
      {
        MessageBox.Show("Error" + ex3);
      }
    }
  }
}
