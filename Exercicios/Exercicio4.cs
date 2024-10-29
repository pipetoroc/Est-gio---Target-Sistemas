using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Estagio_Target_Sistemas.Exercicios
{
    public class Exercicio4
    {
        /*
        Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado: • SP – R$67.836,43 • RJ – R$36.678,66 • MG – R$29.229,88 • ES – R$27.165,48 • Outros – R$19.849,53
        Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.
        */

        public static void Executa()
        {

            Dictionary<string, double> faturamentoPorEstado = new Dictionary<string, double>
            {
                { "SP", 67836.43 },
                { "RJ", 36678.66 },
                { "MG", 29229.88 },
                { "ES", 27165.48 },
                { "Outros", 19849.53 }
            };

            double faturamentoTotal = 0;


            foreach (KeyValuePair<string, double> faturamento in faturamentoPorEstado)
            {
                faturamentoTotal += faturamento.Value;
            };

            foreach (var estado in faturamentoPorEstado)
            {
                double percentual = (estado.Value / faturamentoTotal) * 100;
                Console.WriteLine($"O estado {estado.Key}, faturou um percentual de: {percentual:F2}%");
            }
        }
    }
}