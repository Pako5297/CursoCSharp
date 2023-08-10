/*Fazer um programa para ler o nome de um aluno e as três primeiras notas que ele obteve nos três
  trimestres do ano (primeiro trimestre vale 30 e o segundo e terceiro valem 35 cada). Ao final,
  mostrar qual a nota final do aluno no ano. Dizer também se o aluno está APROVADO ou REPROVADO 
  e, em caso negativo, quantos pontos faltam para o aluno obter o mínino para ser APROVADO (que é
  60 pontos). Você deve criar uma classe 'Aluno' para resolver este problema.
 */
using Exercicio5;

Aluno aluno = new Aluno();
Console.WriteLine("Digitem os dados do aluno:");
Console.Write("Nome: ");
aluno.Nome = Console.ReadLine();
Console.Write("Nota 1: ");
aluno.Nota1 = double.Parse(Console.ReadLine());
Console.Write("Nota 2: ");
aluno.Nota2 = double.Parse(Console.ReadLine());
Console.Write("Nota 3: ");
aluno.Nota3 = double.Parse(Console.ReadLine());

Console.WriteLine($"NOTA FINAL: {aluno.NotaFinal().ToString("F2")}");
aluno.AprovaReprova();
