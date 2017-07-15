using System;

namespace ConsolePermutacaoString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string 1
            string word_1;
            //string 2
            string word_2;

            //Imprimi o titulo na tela 
            Console.WriteLine("Algoritmo Permutacao de String");

            //Imprimi a frase na tela 
            Console.WriteLine("Escreva uma palavra:");
            //Recebe os dados do teclado e armazena na variavel
            word_1 = Console.ReadLine();
           
            //Imprimir a frase na tela 
            Console.WriteLine("Escreva outra palavra:");
            //Recebe os dados do teclado e armazena na variavel
            word_2 = Console.ReadLine();

            //isPermutation => metodo que determina se duas strings são permutação uma da outra 
            //if => se a resposta for true entao,imprime a mensagem (E permutacao)
            if (isPermutation(word_1, word_2))
            {
                Console.WriteLine("E permutacao");
            }
            //else => se false entao,imprime a mensagem(nao e permutacao)
            else {
                Console.WriteLine("Nao e permutacao");
            }
            //Espera uma ação no teclado para finalizar o algoritmo
            Console.ReadKey();
        }

        //metodo que verifica permutação entre strings
        //Custo do algoritmo 
        //tempo O(m+n)
        //espaço O(1)
        private static bool isPermutation(string word_1, string word_2)
        {
            //variavel inteira inicializada com valor 0
            int result = 0;//O(1)
            //percorre enquanto i que tem valor 0,for menor que o tamanho da string
            for (int i = 0; i < word_1.Length; i++)//O(n)
            {
                //^ => operador de (ou)chor exclusivo
                //funciona da seguinte maneira:dados 2 bits de entrada
                //se os 2 bits forem iguais 11 ou 00,o resultado da operação e sempre 0
                //se os dois bits de entrada forem diferentes o resultado sempre sera 1
                //result ira acumular os dados em forma de bits da string word_1
                result = result ^ word_1[i]; 
            }
            //percorre enquanto i que tem valor 0,for menor que o tamanho da string
            for (int i = 0; i < word_2.Length; i++)//O(m)
            {
                //result ira acumular os dados em forma de bits da string word_2
                //quando result comparar dados iguais o resultado sera 0
                result = result ^ word_2[i];
            }
            //Assim quando o resultado de result for igual a 0
            //o retorno do metodo sera positivo(true),ja que e um metodo boolean,
            //e quando o resultado for 1 o retorno sera falso(false)
            return (result == 0);
        }
    }
}