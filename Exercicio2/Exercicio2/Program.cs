/*Fazer um programa para ler o nome e salario de dois funcionarios.
 * Depois, mostrar o salário medio dos funcionarios
 */

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();
Console.WriteLine("Dados do primeiro funcionario:");
Console.Write("Nome: ");
p1.Nome = Console.ReadLine();
Console.Write("Salario: ");
p1.Salario = double.Parse(Console.ReadLine());

Console.WriteLine("Dados do segundo funcionario:");
Console.Write("Nome: ");
p2.Nome = Console.ReadLine();
Console.Write("Salario: ");
p2.Salario = double.Parse(Console.ReadLine());

double media = (p1.Salario + p2.Salario) / 2;
Console.WriteLine("Média salarial: R$" + media.ToString("F2"));