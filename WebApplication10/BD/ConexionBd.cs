using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication10.BD
{
    public class ConexionBd
    {

        private string cadenaConexion;

        public ConexionBd()
        {

            this.cadenaConexion = "Integrated Security=SSPI;Persist Security Info=False;User ID=matias;Initial Catalog=webApiEjemplo;Data Source=DESKTOP-M6BU4CP";

        }

        public SqlConnection crearConexion()
        {

            ConexionBd con = new ConexionBd();

            SqlConnection sqlConnection = new SqlConnection(con.cadenaConexion);

            try
            {

                sqlConnection.Open();

                return sqlConnection;

            }

            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);

                return null;
            }

        }

    }
}