using System;

namespace tp2_CSharp
{
    class Program
    {
        static void Main (string[] args)
        {
            Exercicio2();
        }

        public static void Exercicio2 ()
        {
            int min, max, par = 0, impa = 0;

            Console.Write("\nEntre com o valor minímo: ");
            min = int.Parse(Console.ReadLine());

            Console.Write("Entre com o valor máximo: ");
            max = int.Parse(Console.ReadLine());

            for (int i= min; i <= max; i++){
                if (i % 2 == 0){
                    par += i;
                }
                else{
                    impa += i;
                }
            }

            Console.WriteLine($"Soma dos números Pares: {par} \nSoma dos números Ímpares: {impa}");
        }
    }
}