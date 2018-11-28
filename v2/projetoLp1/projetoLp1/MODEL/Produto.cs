using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    public class Produto
    {
        public enum TIPO {Perfume = 1, Quarto, Roupa, Cozinha, Maquiagem};
        private string codigo;
        private string nome;
        private decimal preco;
        private string descricao;
        private int quantidade;
        private int pontos;
        private TIPO tipo;
        private string estado;        


        public Produto(string codigo, decimal preco, int quantidade)
        {
            this.Codigo = codigo;
            this.Preco = preco;
            this.Quantidade = quantidade;            
        }



        public string Codigo
        {
            get { return codigo; }

            set
            {
                if (value.Length > 0)
                {
                    codigo = value;
                }
            }
        }

        public string Nome
        {
            get { return nome; }

            set
            {
                if (value.Length > 0)
                {
                    nome = value;
                }
            }
        }
        public decimal Preco
        {
            get { return preco; }

            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
            }
        }
        public string Descricao
        {
            get { return descricao; }

            set
            {
                if (value.Length >= 0)
                {
                    descricao = value;
                }
            }
        }
        public int Quantidade
        {
            get { return quantidade; }

            set
            {
                if (value >= 0)
                {
                    quantidade = value;
                }
            }
        }

        public int Pontos
        {
            get
            {
                return pontos;
            }

            set
            {
                pontos = value;
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
                

        public TIPO Tipo
        {
            get
            {
                return tipo;
            }

            set
            {
                tipo = value;
            }
        }


        //fazer as regras de negocios 

    }
}
