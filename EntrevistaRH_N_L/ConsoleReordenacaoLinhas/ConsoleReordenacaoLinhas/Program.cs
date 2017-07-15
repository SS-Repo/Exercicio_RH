using System;

namespace ConsoleReordenacaoLinhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_linhas;
            int num_1 = 0;
            int num_2 = 1;
            int aux;

            Console.WriteLine("**Reordenacao de Linhas**");
            Console.WriteLine(" ");
            Console.WriteLine("Digite o numero de linhas do arquivo:");
            numero_linhas = Convert.ToInt32(Console.ReadLine());

            int[] array_1 = new int[numero_linhas];
            for (int i = 0; i < numero_linhas; i++)
            {
                aux = num_1 + num_2;
                num_1 = num_2;
                num_2 = aux;

                if (num_2 < numero_linhas)
                {
                    array_1[i] = num_2;
                }
            }

            int[] array_2 = new int[numero_linhas + 1];
            for (int i = 1; i < numero_linhas + 1; i++)
            {
                array_2[i] = i;
            }

            for (int i = 0; i < numero_linhas; i++)
            {
                for (int j = 0; j < array_2.Length; j++)
                {
                    if (array_1[i] == array_2[j])
                    {
                        array_2[j] = 0;
                    }
                }
            }

            Console.WriteLine(" ");
            Array.Sort(array_2);
            for (int i = 0; i < numero_linhas; i++)
            {
                if (array_2[i + 1] != 0)
                {
                    array_1[i] = array_2[i + 1];
                }
                Console.WriteLine("indice" + "[" + i + "]" + " = " + array_1[i]);
            }
            Console.ReadKey();
        }
    }
}