using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    sealed class Quarto:Produto
    { 
        string cor;
        double altura;
        double largura;
        string material;


        /*public Quarto(string cor, double altura, double largura, string material, string c, string n, decimal p, string d, int q, int po, int tipo) 
        :base(string c, string n, decimal p, string d, int q, int po, int tipo)
         {
             base.Codigo = c;
             base.Descricao = d;
             base.Nome = n;
             base.Pontos = po;
             base.Preco = p;
             base.Quantidade = q;
             base.Tipo = tipo;
         }*/

        public Quarto(string codigo, decimal preco, int quantidade) : base(codigo,  preco,  quantidade)
        {
            base.Codigo = codigo;
            base.Preco = preco;
            base.Quantidade = quantidade;
            
        }

             
        public string Cor
        {
            get { return cor; }

            set
            {
                if (value.Length > 0)
                {
                    cor = value;
                }
            }
        }
        public double Altura
        {
            get { return altura; }

            set
            {
                if (value > 0)
                {
                    altura = value;
                }
            }
        }
        public double Largura
        {
            get { return largura; }

            set
            {
                if (value > 0)
                {
                    largura = value;
                }
            }
        }
        public string Material
        {
            get { return material; }

            set
            {
                if (value.Length > 0)
                {
                    material = value;
                }
            }
        }
    }
}
