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
            int level = EscogerDificultad();
            string userInput = IntroducirNombrePersonajes();
            string[] names = userInput.Split(' ');
            string archerName = names[0];
            string barbarianName = names[1];
            string magicianName = names[2];
            string druidName = names[3];

        }
        public static void MostrarMensajeBienvenida()
        {
            const string MsgWelcome = "=============================================\r\n         Bienvenid@ a Héroes vs Monstruo\r\n=============================================";                       
            Console.ForegroundColor = ConsoleColor.Green; Console.WriteLine(MsgWelcome);
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
                        return level;   
                    case 2:
                        return level;
                    case 3:
                        return level;
                    case 4:
                        return level;
                }
            }while (attempts < MaxAttempts && (level != levelOne || level != levelTwo || level != levelThree || level != levelFour));
            if (attempts == MaxAttempts) 
            { 
                Console.WriteLine(MsgOutOfAttempts);
            }
            return 0;
            
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
