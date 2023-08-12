/*Fazer um programa para ler um número N e depois os dados (ID, NOME, SALARIO)
 * de N funcionários. Não deve haver repetição de ID.
 * Em seguida, efetuar o aumento de X por cento no salário de um determinado funcionário.
 * Para isso, o programa deve ler um ID e o valor X. Se o ID informação não existir, mostrar uma 
 * mensagem e abortar a operação. Ao final, mostrar a listagem atualizada dos funcionários,
 * conforme exemplo.
 * Lembre-se de aplicar a técnica de encapsulamento para não permitir que o SALARIO possa
 * ser mudado livremente. Um salário só pode ser aumentado com base em uma operação de aumento
 * por porcentagem dada.
 */
using Exercicio9;

List<Funcionario> funcionarios = new List<Funcionario>();
Console.Write("Quantos funcionarios serão registrados? ");
int n = int.Parse(Console.ReadLine());
for(int i = 0; i < n; i++)
{
    Console.WriteLine($"Funcionário #{i+1}");
    Console.Write("ID: ");
    int id = int.Parse(Console.ReadLine());
    Console.Write("Nome: ");
    string nome = Console.ReadLine();
    Console.Write("Salário: ");
    double salario = double.Parse(Console.ReadLine());
    funcionarios.Add(new Funcionario (id, nome, salario));
}
Console.WriteLine("Lista de funcionários!");
foreach(Funcionario func in funcionarios)
{
    Console.WriteLine(func.ToString());
}
Console.WriteLine("");
Console.Write("Digite o ID do funcionário que deseja aumentar o salário: ");
n = int.Parse(Console.ReadLine());
var acharID = funcionarios.Find(x => x.ID == n);
if(acharID != null)
{
    Console.Write("Digite a porcentagem: ");
    double pct = double.Parse(Console.ReadLine());
    acharID.Aumento(pct);
}
else
{
    Console.WriteLine("Não existe funcionário com este ID!");
}
Console.WriteLine("");
Console.WriteLine("Lista de funcionários atualizada!");
foreach (Funcionario func in funcionarios)
{
    Console.WriteLine(func.ToString());
}