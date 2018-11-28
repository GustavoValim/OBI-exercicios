using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    sealed class maquiagem:Produto
    {
        double peso;
        string cor;


        public maquiagem(string codigo, decimal preco, int quantidade) : base(codigo, preco, quantidade)
        {
            base.Codigo = codigo;
            base.Preco = preco;
            base.Quantidade = quantidade;           
        }

    public double Peso {
            get {
                return peso;
            }
            set {
                if(value > 0)
                    peso = value;
            }
        }
        public string Cor {
            get { return cor; }
            set
            {
                if(value.Length > 0)
                    cor = value;
            }
        }
    }
}
