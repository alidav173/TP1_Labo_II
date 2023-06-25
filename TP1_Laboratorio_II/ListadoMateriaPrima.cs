using Controlador;
using Data;
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
  public partial class ListadoMateriaPrima : Form
  {
    DataTable dt = new DataTable();
    public List<MateriaPrima> lista = new List<MateriaPrima>();
    public ListadoMateriaPrima()
    {
      InitializeComponent();
    }

    private void ListadoMateriaPrima_Load(object sender, EventArgs e)
    {
      dt.Columns.Add("Id");
      dt.Columns.Add("Nombre");
      dt.Columns.Add("Descripción");
      dt.Columns.Add("Tipo Material");
      dt.Columns.Add("Precio");
      dt.Columns.Add("Unidad de medida");

      dataGridView1.DataSource = dt;
      int Id = 1;
      MateriaPrima materiaNueva = ControladorMaterial.BuscarMaterialPorID(Archivo.ConvertirIntAString(Id));
      while (materiaNueva != null)
      {
        DataRow row = dt.NewRow();
        row["Id"] = materiaNueva.Id;
        row["Nombre"] = materiaNueva.Nombre;
        row["Descripción"] = materiaNueva.Descripcion;
        row["Tipo Material"] = materiaNueva.TipoMaterial;
        row["Precio"] = materiaNueva.Precio;
        row["Unidad de medida"] = materiaNueva.UnidadMedida;
        dt.Rows.Add(row);
        Id++;
        materiaNueva = ControladorMaterial.BuscarMaterialPorID(Archivo.ConvertirIntAString(Id));
      }
        
      }

    private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
    {

    }

    private async void btnSeleccionar_Click(object sender, EventArgs e)
    {
  
      int filasSeleccionadas = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
      if (filasSeleccionadas > 0)
      {
    
        string id;
        string nombre;
        string descripcion;
        string precio;
        string tipoMaterial;
        string unidadMedida;

        for (int i = 0; i < filasSeleccionadas; i++)
        {
          id = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();

          nombre = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();

          descripcion = dataGridView1.SelectedRows[i].Cells[2].Value.ToString();

          tipoMaterial = dataGridView1.SelectedRows[i].Cells[3].Value.ToString();

          precio = dataGridView1.SelectedRows[i].Cells[4].Value.ToString();

          unidadMedida = dataGridView1.SelectedRows[i].Cells[5].Value.ToString();

          MateriaPrima mp = new MateriaPrima();
          mp.Id = int.Parse(id);
          mp.Nombre = nombre;
          mp.Descripcion = descripcion;
          mp.TipoMaterial = tipoMaterial;
          mp.Precio = float.Parse(precio);
          mp.UnidadMedida = unidadMedida;
          lista.Add(mp);
        }
      }
      this.Close();
    }

    private void btnCancelar_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}
