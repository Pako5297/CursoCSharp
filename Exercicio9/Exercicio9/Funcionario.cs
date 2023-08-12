using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio9
{
    public class Funcionario
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Salario { get; private set; }

        public Funcionario(int iD, string nome, double salario)
        {
            ID = iD;
            Nome = nome;
            Salario = salario;
        }

        public void Aumento(double valor)
        {
            Salario = Salario + ((Salario * valor) / 100);
        }

        public override string ToString()
        {
            return "ID: "
                + ID
                + ", NOME: "
                + Nome
                + ", SALÁRIO R$"
                + Salario.ToString("F2");
        }
    }
}
