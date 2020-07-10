using System;

namespace Controle_de_quartos
{
    public static class Program
    {
        static void Main(string[] args)
        {
            Quartos[] vect = new Quartos[10];

            Console.Write("Quantos quartos você deseja? ");
            int qteQuartos = int.Parse(Console.ReadLine());





            for (int i = 1; i <= qteQuartos; ++i)
            {
                Console.WriteLine("Aluguel #" + i);

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Email: ");
                string email = Console.ReadLine();

                Console.Write("Numero do quarto: ");
                int quarto = int.Parse(Console.ReadLine());

                vect[quarto] = new Quartos(nome, email);


            }

            Console.WriteLine();
            Console.WriteLine("Quartos ocupados:");
            for (int i = 0; i < 10; i++)
            {
                if (vect[i] != null)
                {
                    Console.WriteLine(i + ": " + vect[i]);


                }
            }
        }
    }
}
