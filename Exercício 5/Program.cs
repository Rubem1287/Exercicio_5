using System;
using System.Globalization;
namespace Exercício_5
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeros;

            int n = int.Parse(Console.ReadLine());

            numeros = new double[n];
            double soma = 0;
            int contador = 0;
            string[] vetor = Console.ReadLine().Split(' ');
            for (int i = 0; i < n; i++)
            {
                numeros[i] = int.Parse(vetor[i], CultureInfo.InvariantCulture);
                if(numeros[i]%2==0)
                {
                    soma = soma + numeros[i];
                    contador++;
                }
                
            }
            double media = 0;

            media = soma / contador;
            Console.WriteLine(media.ToString("F1",CultureInfo.InvariantCulture));
        }
    }
}
