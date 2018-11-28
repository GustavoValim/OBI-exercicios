using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    sealed class Cozinha:Produto
    {
        double peso;
        double altura;
        double largura;
        string material;

        public Cozinha(string codigo, decimal preco, int quantidade) : base(codigo, preco, quantidade)
        {
            base.Codigo = codigo;
            base.Preco = preco;
            base.Quantidade = quantidade;            
        }




    public double Peso {
            get
            {
                return peso;
            }
            set
            {
                if (value > 0)
                    peso = value;
            }
        }
        public double Altura {
            get
            {
                return altura;
            }
            set
            {
                if(value > 0)
                    altura = value;
            }
        }
        public double Largura {
            get {
                return largura;
            }
            set
            {
                if(value > 0)
                    largura = value;
            }
        }
        public string Material {
            get
            {
                return material;
            }
            set
            {
                if (value.Length > 0)
                    material = value;
            }
        }
    }
}
