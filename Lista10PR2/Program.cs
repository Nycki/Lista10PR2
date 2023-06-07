using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lista10PR2
{
    internal class Program
    {
        public static void Exercicio1()
        {
            Console.Write("Digite o tamanho : ");
            int tamanho = int.Parse(Console.ReadLine());

            float[] numeros = new float[tamanho];

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite o número {0}: ", i);
                numeros[i] = float.Parse(Console.ReadLine());
            }

            float menor = numeros[0], maior = numeros[0], soma = 0;


            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] < menor)
                    menor = numeros[i];

                if (numeros[i] > maior)
                    maior = numeros[i];

                soma = soma + numeros[i];
            }

            float media = soma / tamanho;

            Console.WriteLine("Menor número: {0}", menor);
            Console.WriteLine("Maior número: {0}", maior);
            Console.WriteLine("Média aritmética: {0}", media);
        }
        public static void Exercicio2()
        {
            Console.Write("Digite o tamanho do vetor N: ");
            int tamanho = int.Parse(Console.ReadLine());

            while (tamanho <= 0)
            {
                Console.WriteLine("O valor de N deve ser maior que zero");
                Console.Write("Digite o tamanho do vetor N: ");
                tamanho = int.Parse(Console.ReadLine());
            }

            float[] numeros = new float[tamanho];
            float soma = 0;

            for (int i = 0; i < tamanho; i++)
            {
                Console.Write("Digite o número {0}: ", i);
                numeros[i] = float.Parse(Console.ReadLine());
                soma += numeros[i];
            }

            float media = soma / tamanho;

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] >= media)
                    Console.WriteLine(numeros[i]);
            }
        }
        public static void Exercicio3()
        {
            Random rand = new Random();
            Console.Write("Digite o tamanho do vetor N: ");
            int tamanho = int.Parse(Console.ReadLine());

            while (tamanho <= 0)
            {
                Console.WriteLine("O valor de N deve ser maior que zero");
                Console.Write("Digite o tamanho do vetor N: ");
                tamanho = int.Parse(Console.ReadLine());
            }

            float[] numeros = new float[tamanho];
            float soma = 0;

            for (int i = 0; i < tamanho; i++)
            {
                numeros[i] = rand.Next(10, 50);
                soma += numeros[i];
            }

            float media = soma / tamanho;

            Console.WriteLine("Números maiores ou iguais à média:");

            for (int i = 0; i < tamanho; i++)
            {
                if (numeros[i] >= media)
                    Console.WriteLine(numeros[i]);
            }
        }
        public static void Exercicio4()
        {
            string[] vet5;
            Console.WriteLine("entre com o tamanho");
            int t = int.Parse(Console.ReadLine());

            vet5 = new string[t];

            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("entre com os nomes");
                vet5[i] = Console.ReadLine();
            }

                for (int i = t-1; i >= 0; i--)
                {
                Console.WriteLine("posição [{0}] = {1}", i, vet5[i]);

                }
            
        }
        public static void Exercicio5()
        {
            int[] vet2;
            int t, somai = 0, somap = 0;


            Console.WriteLine("entre com o tamanho");
            t = int.Parse(Console.ReadLine());
            vet2 = new int[t];
            Random rand = new Random();

            for (int i = 0; i < t; i++)
            {

                vet2[i] = rand.Next(1, 1000);

            }

            for (int i = 0; i < t; i++)
            {

                if (vet2[i] % 2 == 0)
                {
                    somai++;
                }
                else
                {
                    somap++;
                }

            }
            for (int i = 0; i < t; i++)
            {
                Console.WriteLine("posição [{0}] = {1}", i, vet2[i]);


            }

            Console.WriteLine("neste vetor existem: " + somai + " numeros pares e: " + somap + " numeros impares");
        }

        static void Main(string[] args)
        {
            int opcao;
            do
            {
                Console.WriteLine(">>>>MENU<<<<");
                Console.WriteLine("PARA SAIR 0");
                Console.WriteLine("EXERCICIO 1");
                Console.WriteLine("EXERCICIO 2");
                Console.WriteLine("EXERCICIO 3");
                Console.WriteLine("EXERCICIO 4");
                Console.WriteLine("EXERCICIO 5");
                Console.WriteLine(">>>>><<<<<<");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 0:
                        Console.WriteLine("obrigada");
                        break;
                    case 1:
                        Exercicio1();
                        break;
                    case 2:
                        Exercicio2();
                        break;
                    case 3:
                        Exercicio3();
                        break;
                    case 4:
                        Exercicio4();
                        break;
                    case 5:
                        Exercicio5();
                        break;
                    default:
                        Console.WriteLine("não existe esse exercicio");
                        break;

                }

            } while (opcao != 0);
        }
    }
}
