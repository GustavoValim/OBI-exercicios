using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoLp1
{
    class Roupa
    {
        string cor;
        bool p;
        bool m;
        bool g;
        bool gg;

        public string Cor {
            get { return cor; }

            set {
                if(value.Length > 0)
                cor = value;
            }
        }

        public bool P { get => p; set => p = value; }
        public bool M { get => m; set => m = value; }
        public bool G { get => g; set => g = value; }
        public bool Gg { get => gg; set => gg = value; }
    }
}
