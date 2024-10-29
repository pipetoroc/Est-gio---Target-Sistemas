namespace Estagio_Target_Sistemas.Exercicios
{
    public class Exercicio2
    {
        public static void Executa(int n)
        {
            // Manejo de casos especiales
            if (n <= 0)
            {
                Console.WriteLine($"O número {n} da sequência Fibonacci é: 0");
                return;
            }
            else if (n == 1)
            {
                Console.WriteLine($"O número {n} da sequência Fibonacci é: 1");
                return;
            }

            int a = 0;
            int b = 1;
            int resultado = 0;

            for (int i = 2; i <= n; i++)
            {
                resultado = a + b;
                a = b;
                b = resultado;
            }
            Console.WriteLine($"O número {n} da frecuencia Fibonnaci é :{resultado}");
        }
    }
}
