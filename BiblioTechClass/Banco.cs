using MySql.Data.MySqlClient;
using System.Globalization;
using System.Security.Cryptography;

namespace BiblioTechClass
{
    public class Banco
    {
       public static string StrConn { get; set; }

        /// <summary>
        /// Método para abrir uma conexão com o banco de dados
        /// </summary>
        /// <param name="strconn">uma conexão</param>
        /// <returns>Objeto MySqlCommand</returns>
       public static MySqlCommand Abrir(string strconn="")
        {
            MySqlCommand cmd = new();

            StrConn = strconn;
            if(strconn == string.Empty)
            {
                StrConn = @$"server=127.0.0.1;database=bibliotech;user=root;password=";
                MySqlConnection cn = new(StrConn);

                try
                {
                    cn.Open();
                    cmd.Connection = cn;
                }
                catch(MySqlException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return cmd;
        }
    }
}
