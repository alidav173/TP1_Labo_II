using Modelos;
using Data;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace TP1_Laboratorio_II
{
  public partial class Login : Form
  {
    IFirebaseConfig config = new FirebaseConfig
    {
      AuthSecret = "Ftl3sYMwIdMqDoMLCwOKFGOrpK7bn1RUn2QGzh7b",
      BasePath = "https://pruebaapp-39ea7-default-rtdb.firebaseio.com/"
    };

    IFirebaseClient client;

    public Login()
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
      string mensaje;
      mensaje = ValidadorUsuarios.ValidadorUsuario(email, contraseña);

      if (mensaje == "usuario ok")
      {
        Usuario usuarioNuevo = new Usuario(email, contraseña);
      }
      
      MessageBox.Show(mensaje);
      this.Hide();
      PantallaPrincipal pP = new PantallaPrincipal();
      pP.Show();
    }

    private void Login_Load(object sender, EventArgs e)
    {
      client = new FireSharp.FirebaseClient(config);

      if (client is not null)
      {
        MessageBox.Show("Connection is established");
      }
   
    }
  }
}
