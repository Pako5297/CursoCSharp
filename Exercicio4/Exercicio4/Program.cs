/*Fazer um programa para ler os dados de um funcionário (nome, 
salário bruto e imposto). Em seguida, mostrar os dados do 
funcionário (nome e salário líquido). Em seguida, aumentar o salário 
do funcionário com base em uma porcentagem dada (somente o 
salário bruto é afetado pela porcentagem) e mostrar novamente os 
dados do funcionário.
 */

using Exercicio4;

Funcionario func = new Funcionario();
Console.WriteLine("Dados do funcionário:");
Console.Write("Nome: ");
func.Nome = Console.ReadLine();
Console.Write("Salário bruto: ");
func.SalarioBruto = double.Parse(Console.ReadLine());
Console.Write("Imposto: ");
func.Imposto = double.Parse(Console.ReadLine());
Console.WriteLine($"Funcionário: {func.Nome}, R${func.SalarioLiquido().ToString("F2")}");
Console.Write("Digite a porcentagem para aumentar o salário: ");
double pct = double.Parse(Console.ReadLine());
func.AumentarSalario(pct);
Console.WriteLine($"Dados atualizados: {func.Nome}, R${func.SalarioLiquido().ToString("F2")}");

