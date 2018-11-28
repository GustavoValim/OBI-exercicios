using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    class Database
    {
        private const string urlConexaoAula = "server=localhost;database=sistemaBancoLP;user=root;password=ifsp;";
        private const string urlConexaoCasa = "server=localhost;database=sistemaBancoLP;user=root;password=ifsp;";        

        public static MySqlConnection Conn()
        {
            MySqlConnection conexao = new MySqlConnection(urlConexaoAula);
            return conexao;
        }

        

        public static void executeNoQuery(string sql, MySqlConnection conn)
        {
            try
            {

                if (conn.State == System.Data.ConnectionState.Closed)              
                    conn.Open();
                
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
            }
            catch
            {
              
            }
            finally
            {
                conn.Close();
            }

            
        }

        public static DataSet executeQuery(string sql, MySqlConnection conn)
        {
            try
            {
                if(conn.State == System.Data.ConnectionState.Closed)                
                   conn.Open();
                
                MySqlCommand cmd = new MySqlCommand(sql, conn);
                MySqlDataAdapter r = new MySqlDataAdapter(cmd);
                DataSet resposta = new DataSet();
                resposta.Clear();
                r.Fill(resposta);
                return resposta;
            }
            catch(Exception ex)
            {
                return null;
            }   
            finally
            {
                conn.Close();
            }             
        }

    }
}
