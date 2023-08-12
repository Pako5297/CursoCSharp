using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio8
{
    public class AlugaQuarto
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public int Quarto { get; set; }

        public override string ToString()
        {
            return "QUARTO "
                + Quarto
                + ": "
                + Nome
                + ", "
                + Email;
        }
    }
}
