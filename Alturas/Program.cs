using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alturas {
    class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;

            int n, i, menores;
            double soma, media, porcentagem;

            Console.Write("Quantas pessoas serao digitadas? ");// insere numero de pessoas
            n = int.Parse(Console.ReadLine());

            string[] nomes = new string[n];
            int[] idades = new int[n];
            double[] alturas = new double[n];

            for (i = 0; i < n; i++) {                     // atribui dados aos vetores            
                Console.WriteLine("Dados da " + (i + 1) + "a pessoa:");

                Console.Write("Nome: ");
                nomes[i] = Console.ReadLine();

                Console.Write("Idade: ");
                idades[i] = int.Parse(Console.ReadLine(), CI);

                Console.Write("Altura: ");
                alturas[i] = double.Parse(Console.ReadLine(), CI);
            }

            soma = 0;
            menores = 0;
            for (i = 0; i < n; i++) {          // soma as alturas
                soma = soma + alturas[i];
            }
            
            media = soma / n;
            Console.WriteLine();
            Console.WriteLine("Altura média: " + media.ToString("F2", CI));

            for (i = 0; i < n; i++) {       // soma os menores de 16
                if (idades[i] < 16) {
                    menores = menores + 1;
                }
            }

            porcentagem = menores * 100 / n;
            Console.WriteLine("Pessoas com menos de 16 anos: "+porcentagem.ToString("F1",CI)+"%");

            for (i = 0; i < n; i++) {       // imprime o nome dos menores 
                if (idades[i] < 16) {
                    Console.WriteLine(nomes[i]);
                }
            }
        }
    }
}
