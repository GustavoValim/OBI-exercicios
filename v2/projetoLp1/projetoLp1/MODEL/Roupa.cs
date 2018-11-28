using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    class Roupa:Produto
    {
        string cor;
        bool p;
        bool m;
        bool g;
        bool gg;


        public Roupa(string codigo, decimal preco, int quantidade) : base(codigo, preco, quantidade)
        {
            base.Codigo = codigo;
            base.Preco = preco;
            base.Quantidade = quantidade;
           
        }



    public string Cor {
            get { return cor; }

            set {
                if(value.Length > 0)
                cor = value;
            }
        }

        public bool P
        {
            get
            {
                return p;
            }

            set
            {
                p = value;
            }
        }

        public bool M
        {
            get
            {
                return m;
            }

            set
            {
                m = value;
            }
        }

        public bool G
        {
            get
            {
                return g;
            }

            set
            {
                g = value;
            }
        }

        public bool Gg
        {
            get
            {
                return gg;
            }

            set
            {
                gg = value;
            }
        }
    }
}
