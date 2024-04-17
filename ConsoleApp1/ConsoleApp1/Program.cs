using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, media, frequencia;
            string nome;


            for (int i = 0; i <= 5; i++) { 


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("\n Digite sua frequência: ");
            frequencia = Convert.ToDouble(Console.ReadLine());

            if (frequencia >= 75)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Você possui a frequência necessária! Continue...");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("Digite seu nome: ");
                nome = Console.ReadLine();

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Digite a primeira nota: ");
                nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a segunda nota: ");
                nota2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Digite a terceira nota: ");
                nota3 = Convert.ToDouble(Console.ReadLine());

                media = Convert.ToDouble((nota1 + nota2 + nota3) / 3);
                media = Math.Round(media, 2);

                if (media >= 9)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Parabéns " + nome + ", você foi aprovado!! Vc é um Gênio, " + media + " foi sua média!!");
                }
                else if (media >= 6 && media < 9)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("Parabéns " + nome + ", você foi Aprovado!! " + media + " foi sua média!!");
                }

                else if (media >= 4 && media < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(nome + ", você foi reprovado!! " + media + " foi sua média!! Fará a recuperação");
                }

                else if (media < 4 && media < 6)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write( nome + ", você foi reprovado!! " + media + " foi sua média!! \n");
                }

            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Reprovado por falta de frequência.");
            }

            }


            Console.ReadKey();

        }
    }
}
