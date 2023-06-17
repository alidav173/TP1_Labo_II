using Modelos;
using Data;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;
using Google.Cloud.Firestore;
using Newtonsoft.Json;
using System.Text.Json.Nodes;
using System.Reflection.Metadata;
using Controlador;
using System.Windows.Forms;

namespace TP1_Laboratorio_II
{
  public partial class LoginVista : Form
  {

    public LoginVista()
    {
      InitializeComponent();
      this.IsMdiContainer= true;
    }

    private void textBoxUsuario_TextChanged(object sender, EventArgs e)
    {

    }

    private void textBoxContraseña_TextChanged(object sender, EventArgs e)
    {

    }

    private void boton_Login_Click(object sender, EventArgs e)
    {
 
        string email = textBoxUsuario.Text;
        string contraseña = textBoxContraseña.Text;
        string mensaje = ControladorLogin.ConectarBd(email, contraseña);
        MessageBox.Show(mensaje);
        if (mensaje == "¡Bienvenido!")
        {
        this.Hide();
        PantallaPrincipal pP = new PantallaPrincipal();
        pP.Show();

       }
    }

    private void Login_Load(object sender, EventArgs e)
    {

    }
  }
}
