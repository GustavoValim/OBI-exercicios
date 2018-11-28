using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    sealed class Perfume:Produto
    {
        double ml;
        string marca;


        public Perfume(string codigo, decimal preco, int quantidade) : base(codigo, preco, quantidade)
        {
            base.Codigo = codigo;
            base.Preco = preco;
            base.Quantidade = quantidade;
          
        }


    public string Marca
        {
            get
            {
                return marca;
            }

            set
            {                
                   marca = value;
            }

        }

        public double Ml
        {
            get
            {
                return ml;
            }

            set
            {
                if (value > 0)
                    ml = value;
            }
        }

    }
}
