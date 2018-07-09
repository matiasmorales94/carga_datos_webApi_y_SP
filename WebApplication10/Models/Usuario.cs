using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WebApplication10.BD;

namespace WebApplication10.Models
{
    public class Usuario
    {

       
            public int userId { get; set; }
            public int id { get; set; }
            public string title { get; set; }
            public string body { get; set; }



        public Boolean guardarUsuario(Usuario usuario) {

            ConexionBd con = new ConexionBd();

            SqlConnection sqlConnection = con.crearConexion();

            if (con!=null) {

                try
                {

                    

                    SqlCommand command = new SqlCommand("sp_addCliente", sqlConnection);

                    command.CommandType = CommandType.StoredProcedure;

                    command.Parameters.AddWithValue("userId",usuario.userId);
                    command.Parameters.AddWithValue("id",usuario.id);
                    command.Parameters.AddWithValue("title",usuario.title);
                    command.Parameters.AddWithValue("body",usuario.body);

                    command.ExecuteNonQuery();

                    return true;

                }

                catch (Exception ex) {


                    Console.WriteLine(ex.Message);

                    return false;
                }


                finally {

                    sqlConnection.Close();

                }
            }

            else
            {

                return false;

            }
        }
    }
}