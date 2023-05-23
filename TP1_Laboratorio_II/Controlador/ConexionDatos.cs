using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Controlador
{
  internal class ConexionDatos
  {
    /// <summary>
    /// Conecta a la base de datos firestore 
    /// </summary>
    /// <returns>
    ///Retorna un cliente de la Base de datos firestore
    /// </returns>
    public static FireSharp.FirebaseClient ConectarBD()
    {
      IFirebaseConfig config = new FirebaseConfig
      {
        AuthSecret = "Ftl3sYMwIdMqDoMLCwOKFGOrpK7bn1RUn2QGzh7b",
        BasePath = "https://pruebaapp-39ea7-default-rtdb.firebaseio.com/"
      };

      IFirebaseClient client;
      client = new FireSharp.FirebaseClient(config);

      return (FireSharp.FirebaseClient)client;

    }

  }
}
