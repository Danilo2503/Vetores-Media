using System;

namespace Exercico_Vetor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [2];

            int[] notas1 = new int [2];
            int[] notas2 = new int [2];
            int[] notas3 = new int [2];
            int[] notas4 = new int [2];
            int[] media = new int [2];

            for (int i = 0; i < nomes.Length; i++)
            {
              Console.Write($"(i + 1)º aluno: ");
              nomes[i] = Console.ReadLine();

              Console.WriteLine($"Digite a 1ª nota do (i + 1)º aluno: ");
              notas1 [i] = int.Parse(Console.ReadLine());

              Console.WriteLine($"Digite a 2ª nota do (i + 1)º aluno: ");
              notas2 [i] = int.Parse(Console.ReadLine());

              Console.WriteLine($"Digite a 3ª nota do (i + 1)º aluno: ");
              notas3 [i] = int.Parse(Console.ReadLine());  

              Console.WriteLine($"Digite a 4ª nota do (i + 1)º aluno: ");
              notas4 [i] = int.Parse(Console.ReadLine());      
            }

            Console.WriteLine("---------------");
            
            for (var i = 0; i < nomes.Length; i++)
            {
               media[i] = (notas1[i] + notas2[i] + notas3[i] + notas4[i]) / 4;
               Console.WriteLine($"Média de {nomes[i]}: {media[i]} "); 
            }

            Console.WriteLine("---------------");

            for (var i = 0; i < nomes.Length; i++)
            {
                Console.WriteLine($"O aluno {nomes[i]} está: ");
                if(media[i] > 7){
                    Console.WriteLine("Aprovado");
                }else{
                    Console.WriteLine("Reprovado!");
                }
            }
        }
    }
}
