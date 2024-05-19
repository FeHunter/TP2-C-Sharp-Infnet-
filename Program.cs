using System;

namespace tp2_CSharp
{
    class Program
    {
        static void Main (string[] args)
        {
            Exercicio1();
            Exercicio2();
            Exercicio3();
            Exercicio4();
        }

        public static void Exercicio1 ()
        {
            char n;
            int h = 0, m = 0, c = 0, i = 0, total;

            Console.WriteLine("\n Digite [h] Homem, [m] Mulher, [c] Criança, [i] Idoso, [f] Finalizar");
            Console.Write("Digite: ");
            n = char.Parse(Console.ReadLine());
            
            while (n != 'f'){
                switch(n){
                    case 'h': h ++; break;
                    case 'm': m ++; break;
                    case 'c': c ++; break;
                    case 'i': i ++; break;
                    default:
                        Console.WriteLine("Caractere Inválido:\nDigite [h] Homem, [m] Mulher, [c] Criança, [i] Idoso, [f] Finalizar");
                        Console.Write("Digite: ");
                        n = char.Parse(Console.ReadLine());
                        break;
                }
                Console.WriteLine("\nDigite [h] Homem, [m] Mulher, [c] Criança, [i] Idoso, [f] Finalizar");
                Console.Write("Digite: ");
                n = char.Parse(Console.ReadLine());
            }
            
            total = h + m + c + i;
            double hPorcen, mPorcen, cPorcen, iPorcen;
            hPorcen = (double)h / total * 100;
            mPorcen = (double)m / total * 100;
            cPorcen = (double)c / total * 100;
            iPorcen = (double)i / total * 100;

            Console.WriteLine($"\nTotal: {total}");
            Console.WriteLine($"Homens: {h}, {hPorcen.ToString("F2")}%");
            Console.WriteLine($"Mulheres: {m}, {mPorcen.ToString("F2")}%");
            Console.WriteLine($"Crianças: {c}, {cPorcen.ToString("F2")}%");
            Console.WriteLine($"Idosos: {i}, {iPorcen.ToString("F2")}% \n");

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
            segundo = nDigitado;

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