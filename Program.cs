using System;

namespace exercicio_1_fixação
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("qual o ano em que você nasceu :");
            int ano = int.Parse(Console.ReadLine());
                int idade = (2020 - ano);

            if(idade >=18){
                Console.WriteLine("Parabens Vote Consciente!!");
            }
            else {
                Console.WriteLine("Sinto muito, Você ainda não tem idade para votar!");
            }

        }
    }
}
