using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace ZKTecoFingerPrintScanner_Implementation.Helpers
{
    public class SqliteDataAccess
    {
        public static List<PersonModel> BuscaCedula(int CEDULA)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<PersonModel>("Select * from CONTROLGF where CEDULA = " + CEDULA + "", new DynamicParameters());
                return output.ToList();
            }
        }



        public static void CargaHuella(int CEDU, string NOMBRE, string HUELLA, int STATUS, string FECHA_INSC, string TIPO_INSC)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into CONTROLGF (CEDULA, NOMBRE, HUELLA, STATUS, FECHA_INSC, TIPO_INSC) values " +
                    "(" + CEDU + ", '" + NOMBRE + "', '" + HUELLA + "', " + STATUS + ", '" + FECHA_INSC + "', '" + TIPO_INSC + "')");

            }
        }

        private static string LoadConnectionString(string id = "Default")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
