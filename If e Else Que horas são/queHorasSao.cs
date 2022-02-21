using System;

namespace If_e_Else_Que_horas_são
{
    class queHorasSao // explicação professor sobre if e else, peguei o exemplo e fiz. Melhor opção é fazer somente com o if
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Qual a hora atual?");

            float horario = float.Parse(Console.ReadLine());

            if  (horario >= 6 && horario < 12){
                Console.WriteLine("bom dia");
            }
            if(horario >= 12 && horario < 18)
            {
                Console.WriteLine("boa tarde");
            }
            if (horario >= 18)
            {
                Console.WriteLine("boa noite");
            }
                
        }
    }
}
