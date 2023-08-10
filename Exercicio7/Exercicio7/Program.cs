/*Em um banco, para se cadastrar uma conta bancária, é necessário
  informar o número da conta, o nome do titular, e o valor de depósito
  inicial que o titular depositou ao abrir a conta. Esse valor de depósito
  inicial, entretanto, é opcional, ou seja: se o titular não tiver dinheiro
  a depositar no momento de abrir sua conta, o depósito inicial não será feito
  e o saldo inicial da conta será, naturalmente, zero.
  IMPORTATNTE: uma vez que uma conta bancária foi aberta, o número da conta nunca
  poderá ser alterado. Por fim, o saldo da conta não pode ser alterado livremente.
  É preciso haver um mecanismo para proteger isso. O saldo só aumenta por meio de depósitos,
  e só diminui por meio de saques. Para cada saque realizado, o banco cobra uma taxa de R$5,00.
  NOTA: a conta pode ficar com saldo negativo se o saldo não for suficiente para realizar o saque e/ou pagar a taxa.
 */
using Exercicio7;

Console.Write("Entre o numero da conta: ");
int conta = int.Parse(Console.ReadLine());
Console.Write("Entre o numero da conta: ");
string nome = Console.ReadLine();
ContaBancaria contaBancaria = new ContaBancaria(nome, conta);
Console.Write("Haverá deposito inicial (s/n)?");
char escolha = char.Parse(Console.ReadLine().ToUpper());
if(escolha == 'S')
{
    Console.Write("Entre o valor de depósito inicial: ");
    double valor = double.Parse(Console.ReadLine());
    contaBancaria = new ContaBancaria(nome, conta, valor);
}
Console.WriteLine("Dados da conta: ");
Console.WriteLine(contaBancaria.ToString());
Console.Write("Entre um valor para depósito: ");
double deposito = double.Parse(Console.ReadLine());
contaBancaria.Deposito(deposito);
Console.WriteLine("Dados atualizados: ");
Console.WriteLine(contaBancaria.ToString());
Console.Write("Entre um valor para saque: ");
double saque = double.Parse(Console.ReadLine());
contaBancaria.Saque(saque);
Console.WriteLine("Dados atualizados: ");
Console.WriteLine(contaBancaria.ToString());