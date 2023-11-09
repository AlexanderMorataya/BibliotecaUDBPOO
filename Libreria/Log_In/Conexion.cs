using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Log_In
{
    class Conexion
    {
        public string servidor, usuario, clave, db;
        public string cadena;

        public void Conec()
        {
<<<<<<< HEAD
            servidor = ""; //Nombre del servidor donde se encuentra la base
            db = "";
            usuario = "";
            clave = "";
            cadena = @"server=" + servidor + ";integrated security=true;database=" + db;
=======
            servidor = "DESKTOP-AKPGMGL"; //Nombre del servidor donde se encuentra la base
            db = "LibraryProyect";
            usuario = "sa";
            clave = "123456";
            cadena = "server=" + servidor + ";uid=" + usuario + ";pwd=" + clave + ";database=" + db;
>>>>>>> 190c953a561ffeb178a9366df4f2fbc5973d6eff
        }
    }
}
