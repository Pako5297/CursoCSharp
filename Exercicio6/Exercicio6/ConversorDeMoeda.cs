using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio6
{
    public class ConversorDeMoeda
    {
        public static double Cotacao { get; set; }
        public static double Dolar { get; set; }

        public static double Converte()
        {
            return Cotacao * Dolar;
        }

        public static double IOF() 
        {
            return Converte() + (Converte() * 6 / 100);
        }
    }
}
