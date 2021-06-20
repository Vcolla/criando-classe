using System;

namespace Desafio_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string equipes,pits;
 

           Equipes_Formula1 Redbull = new Equipes_Formula1();
            Equipes_Formula1 Ferrari = new Equipes_Formula1();
            Equipes_Formula1 Mercedes = new Equipes_Formula1();

            Pilotos Maxverstapen = new Pilotos();
            Pilotos Lewis = new Pilotos();
            Pilotos Vettel = new Pilotos();

            Maxverstapen.pais = "Holandes";
            Maxverstapen.idade = 23;
            Maxverstapen.vitorias = 13;
            Maxverstapen.campeoes = 0;
            Maxverstapen.equipe = "Red Bull";

            Lewis.pais = "Ingles";
            Lewis.idade = 36;
            Lewis.vitorias = 98;
            Lewis.campeoes = 7;
            Lewis.equipe = "Mercedes";

            Vettel.pais = "Alemão";
            Vettel.idade = 33;
            Vettel.vitorias = 53;
            Vettel.campeoes = 7;
            Vettel.equipe = "Aston Martin";


            Redbull.ano = 2005;
            Redbull.Motor = "Honda";
            Redbull.piloto1 = "Max Verstapen";
            Redbull.piloto2 = "Sergio Perez";
            Redbull.Vitorias = 66;


            Ferrari.ano = 1939;
            Ferrari.Motor = "Ferrari";
            Ferrari.piloto1 = "Charles Leclerc";
            Ferrari.piloto2 = "Carlos Sainz Jr.";
            Ferrari.Vitorias = 238;

            Mercedes.ano = 2009;
            Mercedes.Motor = "Mercedes";
            Mercedes.piloto1 = "Lewis Hamilton";
            Mercedes.piloto2 = "Valteri Bottas";
            Mercedes.Vitorias = 118;



            Console.Write("Qual Equipe gostaria de ter infomação:");
            equipes = Convert.ToString(Console.ReadLine());

            Console.Write("Qual Piloto gostaria de ter infomação:");
            pits = Convert.ToString(Console.ReadLine());

            Console.WriteLine("################ EQUIPE #################");

            if (equipes == ("Redbull") || equipes == ("redbull"))
            {
                Console.WriteLine("Ano de entrada:" + Redbull.ano);
                Console.WriteLine("Motor Atual:" + Redbull.Motor);
                Console.WriteLine("Primeiro Piloto:" + Redbull.piloto1);
                Console.WriteLine("Segundo Piloto:" + Redbull.piloto2);
                Console.WriteLine("Vitorias:" + Redbull.Vitorias);
            }
            else if ((equipes == ("Ferrari") || equipes == ("ferrari")))
            {
                Console.WriteLine("Ano de entrada:" + Ferrari.ano);
                Console.WriteLine("Motor Atual:" + Ferrari.Motor);
                Console.WriteLine("Primeiro Piloto:" + Ferrari.piloto1);
                Console.WriteLine("Segundo Piloto:" + Ferrari.piloto2);
                Console.WriteLine("Vitorias:" + Ferrari.Vitorias);
            }
             else if (equipes == ("Mercedes") || equipes == ("mercedes"))
            {
                Console.WriteLine("Ano de entrada:" + Mercedes.ano);
                Console.WriteLine("Motor Atual:" + Mercedes.Motor);
                Console.WriteLine("Primeiro Piloto:" + Mercedes.piloto1);
                Console.WriteLine("Segundo Piloto:" + Mercedes.piloto2);
                Console.WriteLine("Vitorias:" + Mercedes.Vitorias);
            }


            Console.WriteLine("################ PILOTO #################");

            if (pits == "vettel"|| pits == "Vettel")
            {
                Console.WriteLine("País de Origem: " + Vettel.pais);
                Console.WriteLine("Idade: " + Vettel.idade);
                Console.WriteLine("Titulos Mundiais: " + Vettel.campeoes);
                Console.WriteLine("Segundo Piloto:" + Vettel.equipe);
                Console.WriteLine("Vitorias:" + Vettel.vitorias);
            }

             else if (pits == "hamilton" || pits == "Hamilton")
            {
                Console.WriteLine("País de Origem: " + Lewis.pais);
                Console.WriteLine("Idade: " + Lewis.idade);
                Console.WriteLine("Titulos Mundiais: " + Lewis.campeoes);
                Console.WriteLine("Segundo Piloto:" + Lewis.equipe);
                Console.WriteLine("Vitorias:" + Lewis.vitorias);
            }
            else if (pits == "max" || pits == "Max")
            {
                Console.WriteLine("País de Origem: " + Maxverstapen.pais);
                Console.WriteLine("Idade: " + Maxverstapen.idade);
                Console.WriteLine("Titulos Mundiais: " + Maxverstapen.campeoes);
                Console.WriteLine("Segundo Piloto:" + Maxverstapen.equipe);
                Console.WriteLine("Vitorias:" + Maxverstapen.vitorias);
            }









        }
    }
}
