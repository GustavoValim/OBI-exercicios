using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    class DAOcliente
    {

        public void salvar(Cliente c)
        {
            StringBuilder sql = new StringBuilder();
            sql.Append("INSERT INTO cliente (nome, nomeRua, nroRua, bairro, telefone, complemento)");
            sql.Append(string.Format("VALUES('{0}', '{1}', '{2}', '{3}', '{4}','{5}')", c.Nome, c.NomeRua, c.NroRua, c.Bairro, c.Telefone, c.Complemento));

            MySqlConnection conn;
            conn = Database.Conn();
            Database.executeNoQuery(sql.ToString(), conn);
        }

        public void atualizar(Cliente c)
        {
            string sql = string.Format("UPDATE cliente SET nome = '{0}', nomeRua = '{1}', nroRua = '{2}', bairro = '{3}', telefone = '{4}', complemento = '{5}' WHERE codigo = '{6}';", c.Nome, c.NomeRua, c.NroRua, c.Bairro, c.Telefone, c.Complemento, c.Codigo);
            MySqlConnection conn;
            conn = Database.Conn();
            Database.executeNoQuery(sql, conn);
        }

        public void remover(int codigoCliente) {
            string sql = "DELETE FROM cliente WHERE codigo = " + codigoCliente;
            MySqlConnection conn;
            conn = Database.Conn();
            Database.executeNoQuery(sql, conn);
        }

        public Cliente dadosCliente(int codigoCliente) {
            string sql = "SELECT * FROM cliente WHERE codigo = " + codigoCliente;

            MySqlConnection conn = Database.Conn();
            DataSet resposta = Database.executeQuery(sql, conn);

                DataRow r = resposta.Tables[0].Rows[0];
                string nome = r["nome"].ToString();
                string nomeRua = r["nomeRua"].ToString();
                string n = r["nroRua"].ToString();
                string bairro = r["bairro"].ToString();
                string telefone = r["telefone"].ToString();
                string complemento = r["complemento"].ToString();

                Cliente c = new Cliente(nome, nomeRua, n, bairro, telefone, complemento);

                c.Codigo = int.Parse(r["codigo"].ToString());
                c.Estado = r["estado"].ToString();
            return c;                
            

        }

        public List<Cliente> listaClientes()
        {

            string sql = "SELECT * FROM cliente";

            MySqlConnection conn = Database.Conn();
            DataSet resposta = Database.executeQuery(sql, conn);

            List<Cliente> listaClientes = new List<Cliente>();
            foreach (DataRow r in resposta.Tables[0].Rows)
            {
                string nome = r["nome"].ToString();
                string nomeRua = r["nomeRua"].ToString();
                string n = r["nroRua"].ToString();
                string bairro = r["bairro"].ToString(); 
                string telefone = r["telefone"].ToString();
                string complemento = r["complemento"].ToString();

                Cliente c = new Cliente(nome, nomeRua, n, bairro, telefone, complemento);

                c.Codigo = int.Parse(r["codigo"].ToString());
                c.Estado = r["estado"].ToString();
                listaClientes.Add(c);
            }
            return listaClientes;
        }

    }



}
