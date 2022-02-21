using System;

namespace If_e_Else_Horario_Jogo
{
    class horarioJogo// exercicio 04 Udemy apostila 2
    {
        static void Main(string[] args)
        {
            int horaInicial, horaFinal, calculoHora;
            Console.WriteLine("Digite a hora inicial da partida:");
            horaInicial = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a hora final da partida:");
            horaFinal = int.Parse(Console.ReadLine());

            calculoHora=(horaFinal - horaInicial);

            if (calculoHora <= 24)
            {
                Console.WriteLine("O jogo durou " + calculoHora + " horas");
            }

        }
    }
}
