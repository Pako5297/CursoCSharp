/*A dona de um pensionato possui 10 quartos para alugar para estudantes, sendo esses
  quartos identificados pelos números 0 a 9.
  Fazer um programa que inicie com todos os 10 quartos vazios, e depois leia uma quantidade
  N representando o número de estudantes que vão alugar quartos (N pode ser de 1 a 10). Em seguida,
  registre o aluguel dos N estudantes. Para cada registro de aluguel, informar o nome e email do
  estudante, bem como qual dos quartos ele escolheu (de 0 a 9). Suponha que seja esscolhido um quarto vago.
  Ao final, seu programa deve imprimir um relatório de todas as ocupações de pensionato, 
  por ordem de quarto, conforme exemplo.
 */

using Exercicio8;

AlugaQuarto[] vect = new AlugaQuarto[10];

Console.Write("Quantos quartos serão alugados? ");
int qtd = int.Parse(Console.ReadLine());
for(int i = 0; i < qtd; i++)
{
    Console.WriteLine($"QUARTO #{i+1}");
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Email: ");
    string email = Console.ReadLine();
    Console.Write("Quarto: ");
    int quarto = int.Parse(Console.ReadLine());
    vect[quarto] = new AlugaQuarto { Nome = nome, Email = email, Quarto = quarto };
}
Console.WriteLine("Quartos alugados");
foreach (AlugaQuarto i in vect)
{
    if(i != null) Console.WriteLine(i.ToString());
}
