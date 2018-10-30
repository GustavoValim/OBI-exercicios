using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    class Produto
    {
        string codigo;
        string nome;
        decimal preco;
        string descricao;
        int quantidade;
        int pontos;

        public string Codigo {
            get { return codigo; }

            set
            {
                if(value.Length > 0)
                {
                    codigo = value;
                }
            }            
        }

        public string Nome {
            get { return nome; }

            set
            {
                if (value.Length > 0)
                {
                    nome = value;
                }
            }
        }
        public decimal Preco {
            get { return preco; }

            set
            {
                if (value >= 0)
                {
                    preco = value;
                }
            }
        }
        public string Descricao {
            get { return descricao; }

            set
            {
                if (value.Length >= 0)
                {
                    descricao = value;
                }
            }
        }
        public int Quantidade {
            get { return quantidade; }

            set
            {
                if (value >= 0)
                {
                    quantidade = value;
                }
            }
        }
        public int Pontos {
            get { return pontos; }

            set
            {
                if (value >= 0)
                {
                    pontos = value;
                }
            }
        }
    }
}
