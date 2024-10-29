using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
// • O menor valor de faturamento ocorrido em um dia do mês; 
//• O maior valor de faturamento ocorrido em um dia do mês; 
//• Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

// IMPORTANTE: a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal; b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;

namespace Estagio_Target_Sistemas.Exercicios
{
    public class Exercicio3
    {
        public int Dia { get; set; }
        public double Valor { get; set; }
    }
}