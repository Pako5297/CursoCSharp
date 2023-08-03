/*Fazer um programa para ler os valores da largura e altura de um retângulo. Em 
seguida, mostrar na tela o valor de sua área, perímetro e diagonal. Usar uma classe 
como mostrado no projeto ao lado.
 */
using Exercicio3;

Retangulo ret = new Retangulo();
Console.WriteLine("Entre a largura e altura do retângulo:");
Console.Write("Digite a largura: ");
ret.Largura = double.Parse(Console.ReadLine());
Console.Write("Digite a altura: ");
ret.Altura = double.Parse(Console.ReadLine());
Console.WriteLine("ÁREA: " + ret.Area().ToString("F2"));
Console.WriteLine($"PERÍMETRO: {ret.Perimetro().ToString("F2")}");
Console.WriteLine($"DIAGONAL: {ret.Diagonal().ToString("F2")}");
