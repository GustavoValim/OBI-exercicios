using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
 

    public class Cliente
    {
        private string nome;
        private int codigo;
        private string nomeRua;
        private string nroRua;
        private string bairro;
        private string telefone;
        private string complemento;
        private string estado;        

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }

        public string NomeRua
        {
            get
            {
                return nomeRua;
            }

            set
            {
                nomeRua = value;
            }
        }

        public string NroRua
        {
            get
            {
                return nroRua;
            }

            set
            {
                nroRua = value;
            }
        }

        public string Bairro
        {
            get
            {
                return bairro;
            }

            set
            {
                bairro = value;
            }
        }

        public string Telefone
        {
            get
            {
                return telefone;
            }

            set
            {
                telefone = value;
            }
        }

        public string Complemento
        {
            get
            {
                return complemento;
            }

            set
            {
                complemento = value;
            }
        }

        public int Codigo
        {
            get
            {
                return codigo;
            }

            set
            {
                codigo = value;
            }
        }

        public string Estado
        {
            get
            {
                return estado;
            }

            set
            {
                estado = value;
            }
        }

        public Cliente(string nome, string nomeRua, string n, string bairro, string telefone, string complemento)
        {
            this.Nome = nome;
            this.NomeRua = nomeRua;
            this.NroRua = n;
            this.Bairro = bairro;
            this.Telefone = telefone;
            this.Complemento = complemento;
        }

        public Cliente() { }

        


    }
}
