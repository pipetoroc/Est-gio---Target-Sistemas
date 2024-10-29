using Estagio_Target_Sistemas.Exercicios;
using Newtonsoft.Json;

Console.WriteLine("Exercicio 1:");
Exercicio1.Executa();
Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine("Exercicio 2:");
Console.WriteLine("Escreva um numero para calcular a sequencia fibonacci: ");
int n = int.Parse(Console.ReadLine());
Exercicio2.Executa(n);
Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine("Exercicio 3:");

string valorFaturamento = File.ReadAllText("./Arquivos/dados.json");

List<Exercicio3> listaFaturamento = JsonConvert.DeserializeObject<List<Exercicio3>>(valorFaturamento);

// • O menor valor de faturamento ocorrido em um dia do mês; 
var menorFaturamento = listaFaturamento
    .Where(f => f.Valor > 0)
    .OrderBy(f => f.Valor)
    .FirstOrDefault();

Console.WriteLine($"O menor valor de faturamento foi de: {menorFaturamento.Valor} ocurrido no dia: {menorFaturamento.Dia}");

//• O maior valor de faturamento ocorrido em um dia do mês; 
var maiorFaturamento = listaFaturamento
    .Where(f => f.Valor > 0)
    .OrderBy(f => f.Valor)
    .LastOrDefault();

Console.WriteLine($"O maior valor de faturamento foi de: {maiorFaturamento.Valor} ocurrido no dia: {maiorFaturamento.Dia}");

//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.
double mediaFaturamento = listaFaturamento
    .Where(f => f.Valor > 0)
    .Average(f => f.Valor);

int numeroDiasFaturamento = listaFaturamento
    .Where(f => f.Valor > mediaFaturamento)
    .Count();

Console.WriteLine($"A media de faturamento é: {mediaFaturamento}, os numeros de dias no mes onde o faturamento diário foi superior á média mensal é: {numeroDiasFaturamento}");

Console.WriteLine("-------------------------------------------------------------");

Console.WriteLine("Exercicio 4:");
Exercicio4.Executa();
Console.WriteLine("-------------------------------------------------------------");


Console.WriteLine("Exercicio 5:");
Console.WriteLine("Escreve o texto a reverter");
Exercicio5.Executa(Console.ReadLine());
Console.WriteLine("-------------------------------------------------------------");
