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
            servidor = "LAPTOP-I3M358MN\\MSSQLSERVER01"; //Nombre del servidor donde se encuentra la base
            db = "LibraryProyect";
            usuario = "";
            clave = "";
            cadena = @"server=" + servidor + ";integrated security=true;database=" + db+";MultipleActiveResultSets = True";
        }
    }
}
