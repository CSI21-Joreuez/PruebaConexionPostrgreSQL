using Microsoft.AspNetCore.Http;

namespace pruebaConexionPostgreSQLV.Util
{
    /* variablesConexionPostgreSQL - Clase que recoger las variables de conexión a PostgreSQL.
    * @author garfe
    * 02/10/2022
    */
    public class VariablesConexionPostgreSQL
    {
        //Datos de conexión a PostgreSQL
       public const string USER = "postgres";
       public const string PASS = "Ore-2002";
       public const string PORT = "5432";
       public const string HOST = "localhost";
       public const string DB = "Ejemploinicial";
    }
}
