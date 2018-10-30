using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    class Cliente
    {
        string nome;
        string nomeRua;
        string nroRua;
        string bairro;
        string telefone;

        public string Nome { get => nome; set => nome = value; }
        public string NomeRua { get => nomeRua; set => nomeRua = value; }
        public string NroRua { get => nroRua; set => nroRua = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
