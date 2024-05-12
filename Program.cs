using System;

namespace tp2_CSharp
{
    class Program
    {
        static void Main (string[] args)
        {
            Exercicio3();
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

        public static void Exercicio3 ()
        {
            int n;
            bool primo = true;

            Console.Write("\nVerificar se é um número primo \nDigite o número: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 2; i < Math.Sqrt(n); i ++){
                if (n % i == 0){
                    primo = false;
                }
            }

            if (primo){
                Console.WriteLine($"{n} é um número primo");
            }else {
                Console.WriteLine($"{n} não é um número primo");
            }
            Console.WriteLine();
        }

        public static void Exercicio4 ()
        {
            int nDigitado, primeiro, segundo, terceiro;

            Console.Write("\nDigite um valor iniciar a sequência Fibonacci: ");
            nDigitado = int.Parse(Console.ReadLine());

            primeiro = nDigitado;
            segundo = nDigitado + 1;

            Console.Write($"{primeiro} {segundo}");

            // Mostra 10 números apartir do número informado.
            for (int i = 1; i < 10; i++){
                terceiro = primeiro + segundo;
                Console.Write($" {terceiro}");
                primeiro = segundo;
                segundo = terceiro;
            }
        }
    }
}