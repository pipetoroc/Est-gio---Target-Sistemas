using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Estagio_Target_Sistemas.Exercicios
{
    public class Exercicio5
    {
        public static void Executa(string s)
        {
            string reverseWord = "";
            for (int i = s.Length - 1; i >= 0; i--)
            {
                reverseWord += s[i];
            }
            Console.WriteLine(reverseWord);
        }
    }
}