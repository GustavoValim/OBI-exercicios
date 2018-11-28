using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    class Estoque
    {
        private string codigoProduto;
        private Produto.TIPO tipo;
        private int quantidadeProduto;
        private int quantidadeMinima;

        public string CodigoProduto
        {
            get
            {
                return codigoProduto;
            }

            set
            {
                codigoProduto = value;
            }
        }

        public Produto.TIPO Tipo
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

        public int QuantidadeProduto
        {
            get
            {
                return quantidadeProduto;
            }

            set
            {
                quantidadeProduto = value;
            }
        }

        public int QuantidadeMinima
        {
            get
            {
                return quantidadeMinima;
            }

            set
            {
                quantidadeMinima = value;
            }
        }
    }
}
