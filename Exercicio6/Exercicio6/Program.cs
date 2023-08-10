/*Faça um programa para ler a cotação do dólar, e depois um valor em dólar a ser comprado
  por uma pessoa em reais. Informar quantos reais a pessoa vai pagar pelos dólares, considerando
  ainda que a pessoa tera que pagar 6% de IOF sobre o valor em dólar. Criar uma classe "ConversorDeMoeda"
  para ser responsavel pelos cálculos.
 */

using Exercicio6;

Console.Write("Qual é a cotação do dolar? ");
ConversorDeMoeda.Cotacao = double.Parse(Console.ReadLine());
Console.Write("Quantos dolares você vai comprar? ");
ConversorDeMoeda.Dolar = double.Parse(Console.ReadLine());
Console.WriteLine($"Valor a ser pago em Reais: R${ConversorDeMoeda.IOF()}");


