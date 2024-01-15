using System;
namespace HeroisVSMonstres
{
    public class V2
    {
        public static void Main()
        {
            const string MsgContinue = "Pulsa cualquier tecla para continuar...";

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
            switch (level)
            {
                case 1:
                    Console.Clear ();
                    int [] archerEasy = AñadirValoresArqueraNivelFacil();
                    int[] barbarianEasy = AñadirValoresBarbaroNivelFacil();
                    int[] magicianEasy = AñadirValoresMagaNivelFacil();
                    int[] druidEasy = AñadirValoresDruidaNivelFacil();
                    int[] monsterEasy = AñadirValoresMonstruoNivelFacil();
                    Console.WriteLine(MsgContinue);
                    Console.ReadKey();
                    break;
                case 2:
                    int[] archerDifficult = AñadirValoresArqueraNivelDificil();
                    int[] barbarianDifficult = AñadirValoresBarbaroNivelDificil();
                    int[] magicianDifficult = AñadirValoresMagaNivelDificil();
                    int[] druidDifficult = AñadirValoresDruidaNivelDificil();
                    int[] monsterDifficult = AñadirValoresMonstruoNivelDificil();
                    Console.WriteLine(MsgContinue);
                    Console.ReadKey();
                    break;
            }
        }
        public static int[] AñadirValoresArqueraNivelFacil()
        {
            const string MsgArcher = "           _____   ____  _    _ ______ _____            \r\n     /\\   |  __ \\ / __ \\| |  | |  ____|  __ \\     /\\    \r\n    /  \\  | |__) | |  | | |  | | |__  | |__) |   /  \\   \r\n   / /\\ \\ |  _  /| |  | | |  | |  __| |  _  /   / /\\ \\  \r\n  / ____ \\| | \\ \\| |__| | |__| | |____| | \\ \\  / ____ \\ \r\n /_/    \\_\\_|  \\_\\\\___\\_\\\\____/|______|_|  \\_\\/_/    \\_\\\r\n                                                        \r\n                                                        ";
            int [] archer = new int [3] {2000, 300, 35 };
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine (MsgArcher);
            Console.WriteLine($"Vida: {archer[0]}");
            Console.WriteLine($"Ataque: {archer[1]}");
            Console.WriteLine($"Reducción: {archer[2]}%");
            Console.WriteLine();
            Console.ForegroundColor= ConsoleColor.White;
            return archer;                
        }
        public static int[] AñadirValoresBarbaroNivelFacil()
        {
            const string MsgBarbarian = "  ____    __   _____  ____          _____   ____  \r\n |  _ \\  /_/  |  __ \\|  _ \\   /\\   |  __ \\ / __ \\ \r\n | |_) | / \\  | |__) | |_) | /  \\  | |__) | |  | |\r\n |  _ < / _ \\ |  _  /|  _ < / /\\ \\ |  _  /| |  | |\r\n | |_) / ___ \\| | \\ \\| |_) / ____ \\| | \\ \\| |__| |\r\n |____/_/   \\_\\_|  \\_\\____/_/    \\_\\_|  \\_\\\\____/ \r\n                                                  \r\n                                                  ";
            int[] barbarian = new int[3] { 3750, 250, 45 };
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(MsgBarbarian);
            Console.WriteLine($"Vida: {barbarian[0]}");
            Console.WriteLine($"Ataque: {barbarian[1]}");
            Console.WriteLine($"Reducción: {barbarian[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            return barbarian;
        }
        public static int[] AñadirValoresMagaNivelFacil()
        {
            const string MsgMagician = " __  __          _____          \r\n |  \\/  |   /\\   / ____|   /\\    \r\n | \\  / |  /  \\ | |  __   /  \\   \r\n | |\\/| | / /\\ \\| | |_ | / /\\ \\  \r\n | |  | |/ ____ \\ |__| |/ ____ \\ \r\n |_|  |_/_/    \\_\\_____/_/    \\_\\\r\n                                 \r\n                                 ";
            int[] magician = new int[3] { 1500, 400, 35 };
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(MsgMagician);
            Console.WriteLine($"Vida: {magician[0]}");
            Console.WriteLine($"Ataque: {magician[1]}");
            Console.WriteLine($"Reducción: {magician[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return magician;
        }
        public static int[] AñadirValoresDruidaNivelFacil()
        {
            const string MsgDruid = "  _____  _____  _    _ _____ _____          \r\n |  __ \\|  __ \\| |  | |_   _|  __ \\   /\\    \r\n | |  | | |__) | |  | | | | | |  | | /  \\   \r\n | |  | |  _  /| |  | | | | | |  | |/ /\\ \\  \r\n | |__| | | \\ \\| |__| |_| |_| |__| / ____ \\ \r\n |_____/|_|  \\_\\\\____/|_____|_____/_/    \\_\\\r\n                                            \r\n                                            ";            
            int[] druid = new int[3] { 2500, 120, 40 };
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(MsgDruid);
            Console.WriteLine($"Vida: {druid[0]}");
            Console.WriteLine($"Ataque: {druid[1]}");
            Console.WriteLine($"Reducción: {druid[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return druid;
        }
        public static int[] AñadirValoresMonstruoNivelFacil()
        {
            const string MsgMonster = "  __  __  ____  _   _  _____ _______ _____  _    _  ____  \r\n |  \\/  |/ __ \\| \\ | |/ ____|__   __|  __ \\| |  | |/ __ \\ \r\n | \\  / | |  | |  \\| | (___    | |  | |__) | |  | | |  | |\r\n | |\\/| | |  | | . ` |\\___ \\   | |  |  _  /| |  | | |  | |\r\n | |  | | |__| | |\\  |____) |  | |  | | \\ \\| |__| | |__| |\r\n |_|  |_|\\____/|_| \\_|_____/   |_|  |_|  \\_\\\\____/ \\____/ \r\n                                                          \r\n                                                          ";
            int[] monster = new int[3] { 7000, 300, 20 };
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(MsgMonster);
            Console.WriteLine($"Vida: {monster[0]}");
            Console.WriteLine($"Ataque: {monster[1]}");
            Console.WriteLine($"Reducción: {monster[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return monster;
        }
        public static int[] AñadirValoresArqueraNivelDificil()
        {
            const string MsgArcher = "           _____   ____  _    _ ______ _____            \r\n     /\\   |  __ \\ / __ \\| |  | |  ____|  __ \\     /\\    \r\n    /  \\  | |__) | |  | | |  | | |__  | |__) |   /  \\   \r\n   / /\\ \\ |  _  /| |  | | |  | |  __| |  _  /   / /\\ \\  \r\n  / ____ \\| | \\ \\| |__| | |__| | |____| | \\ \\  / ____ \\ \r\n /_/    \\_\\_|  \\_\\\\___\\_\\\\____/|______|_|  \\_\\/_/    \\_\\\r\n                                                        \r\n                                                        ";
            int[] archer = new int[3] { 1500, 200, 25 };
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(MsgArcher);
            Console.WriteLine($"Vida: {archer[0]}");
            Console.WriteLine($"Ataque: {archer[1]}");
            Console.WriteLine($"Reducción: {archer[2]}%");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            return archer;
        }
        public static int[] AñadirValoresBarbaroNivelDificil()
        {
            const string MsgBarbarian = "  ____    __   _____  ____          _____   ____  \r\n |  _ \\  /_/  |  __ \\|  _ \\   /\\   |  __ \\ / __ \\ \r\n | |_) | / \\  | |__) | |_) | /  \\  | |__) | |  | |\r\n |  _ < / _ \\ |  _  /|  _ < / /\\ \\ |  _  /| |  | |\r\n | |_) / ___ \\| | \\ \\| |_) / ____ \\| | \\ \\| |__| |\r\n |____/_/   \\_\\_|  \\_\\____/_/    \\_\\_|  \\_\\\\____/ \r\n                                                  \r\n                                                  ";
            int[] barbarian = new int[3] { 3000, 150, 35 };
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(MsgBarbarian);
            Console.WriteLine($"Vida: {barbarian[0]}");
            Console.WriteLine($"Ataque: {barbarian[1]}");
            Console.WriteLine($"Reducción: {barbarian[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            return barbarian;
        }
        public static int[] AñadirValoresMagaNivelDificil()
        {
            const string MsgMagician = " __  __          _____          \r\n |  \\/  |   /\\   / ____|   /\\    \r\n | \\  / |  /  \\ | |  __   /  \\   \r\n | |\\/| | / /\\ \\| | |_ | / /\\ \\  \r\n | |  | |/ ____ \\ |__| |/ ____ \\ \r\n |_|  |_/_/    \\_\\_____/_/    \\_\\\r\n                                 \r\n                                 ";
            int[] magician = new int[3] { 1100, 300, 20 };
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(MsgMagician);
            Console.WriteLine($"Vida: {magician[0]}");
            Console.WriteLine($"Ataque: {magician[1]}");
            Console.WriteLine($"Reducción: {magician[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return magician;
        }
        public static int[] AñadirValoresDruidaNivelDificil()
        {
            const string MsgDruid = "  _____  _____  _    _ _____ _____          \r\n |  __ \\|  __ \\| |  | |_   _|  __ \\   /\\    \r\n | |  | | |__) | |  | | | | | |  | | /  \\   \r\n | |  | |  _  /| |  | | | | | |  | |/ /\\ \\  \r\n | |__| | | \\ \\| |__| |_| |_| |__| / ____ \\ \r\n |_____/|_|  \\_\\\\____/|_____|_____/_/    \\_\\\r\n                                            \r\n                                            ";
            int[] druid = new int[3] { 2000, 70, 25 };
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(MsgDruid);
            Console.WriteLine($"Vida: {druid[0]}");
            Console.WriteLine($"Ataque: {druid[1]}");
            Console.WriteLine($"Reducción: {druid[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return druid;
        }
        public static int[] AñadirValoresMonstruoNivelDificil()
        {
            const string MsgMonster = "  __  __  ____  _   _  _____ _______ _____  _    _  ____  \r\n |  \\/  |/ __ \\| \\ | |/ ____|__   __|  __ \\| |  | |/ __ \\ \r\n | \\  / | |  | |  \\| | (___    | |  | |__) | |  | | |  | |\r\n | |\\/| | |  | | . ` |\\___ \\   | |  |  _  /| |  | | |  | |\r\n | |  | | |__| | |\\  |____) |  | |  | | \\ \\| |__| | |__| |\r\n |_|  |_|\\____/|_| \\_|_____/   |_|  |_|  \\_\\\\____/ \\____/ \r\n                                                          \r\n                                                          ";
            int[] monster = new int[3] { 10000, 400, 30 };
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(MsgMonster);
            Console.WriteLine($"Vida: {monster[0]}");
            Console.WriteLine($"Ataque: {monster[1]}");
            Console.WriteLine($"Reducción: {monster[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            return monster;
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
