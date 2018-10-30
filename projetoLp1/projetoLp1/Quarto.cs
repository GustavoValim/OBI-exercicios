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
