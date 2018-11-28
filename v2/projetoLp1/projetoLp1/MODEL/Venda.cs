using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    class Venda
    {
        private Cliente cliente;
        private List<Produto> listaDeProdutos;

        private string codigo;
        private DateTime diaVenda;
        private DateTime diaPagamento;

        public string Codigo
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

        public DateTime DiaVenda
        {
            get
            {
                return diaVenda;
            }

            set
            {
                diaVenda = value;
            }
        }

        public DateTime DiaPagamento
        {
            get
            {
                return diaPagamento;
            }

            set
            {
                diaPagamento = value;
            }
        }


        //adicionarProduto
        public void adicionar(Produto p)
        {
            listaDeProdutos.Add(p);
        }


        //RemoverProduto
        public void remover(string codigo)
        {
            foreach (Produto p in listaDeProdutos)            
                if(p.Codigo == codigo)                
                    listaDeProdutos.Remove(p);
        }


        public void limparLista()
        {
            listaDeProdutos.Clear();
        }

        public void total()
        {
            decimal total = 0;
            foreach (Produto p in listaDeProdutos)
            {
                total += p.Preco * p.Quantidade;
            }
        }




    }
}
