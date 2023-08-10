using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5
{
    public class Aluno
    {
        public string Nome { get; set; }
        public double Nota1 { get; set; }
        public double Nota2 { get; set; }
        public double Nota3 { get; set; }
        
        public double Media()
        {
            return (Nota1 + Nota2 + Nota3) / 3;
        }

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public void AprovaReprova()
        {
            if(NotaFinal() > 59)
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + (60-NotaFinal())+ " PONTOS");
            }
        }

    }
}
