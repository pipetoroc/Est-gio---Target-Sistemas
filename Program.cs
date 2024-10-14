using Estagio_Target_Sistemas.Exercicios;

Console.WriteLine("Exercicio 1:");
Exercicio1.Executa();
Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine("Exercicio 2:");
Console.WriteLine("Escreva um numero para calcular a sequencia fibonacci: ");
int n = int.Parse(Console.ReadLine());
Exercicio2.Executa(n);
Console.WriteLine("-------------------------------------------------------------");