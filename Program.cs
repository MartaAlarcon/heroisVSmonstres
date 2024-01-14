using System;
namespace HeroisVSMonstres
{
    public class V2
    {
        public static void Main()
        {
            Console.Clear();
            if (!MostrarMensajeBienvenida()) { return; }
            int level = EscogerDificultad();
            if (level == 1 || level == 2 || level == 3 || level == 4) 
            {
                string userInput = IntroducirNombrePersonajes();
                string[] names = userInput.Split(' ');
                string archerName = names[0];
                string barbarianName = names[1];
                string magicianName = names[2];
                string druidName = names[3];
            }
            else { return; }
        }
        public static bool MostrarMensajeBienvenida()
        {
            const string MsgWelcome = "=============================================\r\n         Bienvenid@ a Héroes vs Monstruo\r\n=============================================";
            const string ChooseOption = "1 - Iniciar partida    2 - Salir ";
            const string MsgOutOfAttempts = "No has sido capaz de elegir entre 2 números, adiós!";

            const int MaxAttempts = 3, OptionOne = 1, OptionTwo = 2;
            int option, attempts = 0;
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(MsgWelcome); Console.WriteLine();
            do
            {
                Console.WriteLine(ChooseOption);
                option = Convert.ToInt32(Console.ReadLine());
                attempts++;
                if (option == OptionOne)
                {
                    return true;
                }
                if (option == OptionTwo)
                {
                    return false;
                }
            } while (attempts < MaxAttempts && (option != OptionOne || option != OptionTwo));
            if (attempts == MaxAttempts) 
            { 
                Console.WriteLine(MsgOutOfAttempts);
            }
            return false;
        }
        public static int EscogerDificultad()
        {
            const string MsgDifficulty = "Escoge la dificultad:\r\n    1 - Fácil\r\n    2 - Difícil\r\n    3 - Personalizado\r\n    4 - Random";
            const string MsgOutOfAttempts = "No has sido capaz de elegir entre 4 números, adiós!";
            const int MaxAttempts = 3, levelOne = 1, levelTwo = 2, levelThree = 3, levelFour = 4;
            int attempts = 0, level;
            Console.ForegroundColor = ConsoleColor.Yellow; 
            do
            {
                Console.WriteLine(MsgDifficulty);
                level = Convert.ToInt32(Console.ReadLine());
                attempts++;
                switch (level)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                        return level;
                }
            }while (attempts < MaxAttempts);
            if (attempts == MaxAttempts) 
            { 
                Console.WriteLine(MsgOutOfAttempts);
            }
            return level;
            
        }
        public static string IntroducirNombrePersonajes()
        {
            const string MsgNames = "| Introduce el nombre a los 4 personajes, separándolos por un espacio: |";        
            Console.Clear();
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine(MsgNames);
            Console.ForegroundColor = ConsoleColor.White;
            string userInput = Console.ReadLine();            
            return (userInput);
        }
    }
}
