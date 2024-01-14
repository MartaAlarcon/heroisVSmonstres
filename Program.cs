using System;
namespace HeroisVSMonstres
{
    public class V2
    {
        public static void Main()
        {
            Console.Clear();
            MostrarMensajeBienvenida();
            Console.ReadKey();
            EscogerDificultad();

        }
        public static void MostrarMensajeBienvenida()
        {
            const string MsgWelcome = "=============================================\r\n         Bienvenid@ a Héroes vs Monstruo\r\n=============================================";                       
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(MsgWelcome);
            Console.ResetColor();
        }
        public static void EscogerDificultad()
        {
            const string MsgDifficulty = "Escoge la dificultad:\r\n    1 - Fácil\r\n    2 - Difícil\r\n    3 - Personalizado\r\n    4 - Random";
            const string MsgOutOfAttempts = "No has sido capaz de elegir entre 4 números, adiós!";
            int level, attempts = 0;
            const int MaxAttempts = 3, levelOne = 1, levelTwo = 2, levelThree = 3, levelFour = 4;

            Console.ForegroundColor = ConsoleColor.Blue; 
            do
            {
                Console.WriteLine(MsgDifficulty);
                level = Convert.ToInt32(Console.ReadLine());
                attempts++;
                switch (level)
                {
                    case levelOne:
                        attempts = MaxAttempts + levelOne;
                        break;
                    case levelTwo:
                        attempts = MaxAttempts + levelTwo;
                        break;
                    case levelThree:
                        attempts = MaxAttempts + levelThree;
                        break;
                    case levelFour:
                        attempts = MaxAttempts + levelFour;
                        break;
                }
            }while (attempts < MaxAttempts && (level != levelOne || level != levelTwo || level != levelThree || level != levelFour));
            if (attempts == MaxAttempts) { Console.WriteLine(MsgOutOfAttempts); }

        }
    }
}
