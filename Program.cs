using System;
using System.Reflection.Emit;
using System.Reflection.PortableExecutable;

namespace HeroisVSMonstres
{
    public class V2
    {
        public static void Main()
        {
            const string MsgContinue = "Pulsa cualquier tecla para continuar...";
            const string MsgDifficulty = "Escoge la dificultad:\r\n    1 - Fácil\r\n    2 - Difícil\r\n    3 - Personalizado\r\n    4 - Random";
            const string MsgOutOfAttempts = "Te has quedado sin intentos";
            const string MsgArcherLife = "Introduce la vida dentro del rango [1500, 2000]";
            const string MsgArcherAttack = "Introduce el ataque dentro del rango [200, 300]";
            const string MsgArcherReduction = "Introduce la reducción de daño dentro del rango [25, 35]%";
            const string MsgArcher = "           _____   ____  _    _ ______ _____            \r\n     /\\   |  __ \\ / __ \\| |  | |  ____|  __ \\     /\\    \r\n    /  \\  | |__) | |  | | |  | | |__  | |__) |   /  \\   \r\n   / /\\ \\ |  _  /| |  | | |  | |  __| |  _  /   / /\\ \\  \r\n  / ____ \\| | \\ \\| |__| | |__| | |____| | \\ \\  / ____ \\ \r\n /_/    \\_\\_|  \\_\\\\___\\_\\\\____/|______|_|  \\_\\/_/    \\_\\\r\n                                                        \r\n                                                        ";
            const string MsgBarbarian = "  ____    __   _____  ____          _____   ____  \r\n |  _ \\  /_/  |  __ \\|  _ \\   /\\   |  __ \\ / __ \\ \r\n | |_) | / \\  | |__) | |_) | /  \\  | |__) | |  | |\r\n |  _ < / _ \\ |  _  /|  _ < / /\\ \\ |  _  /| |  | |\r\n | |_) / ___ \\| | \\ \\| |_) / ____ \\| | \\ \\| |__| |\r\n |____/_/   \\_\\_|  \\_\\____/_/    \\_\\_|  \\_\\\\____/ \r\n                                                  \r\n                                                  ";
            const string MsgBarbarianLife = "Introduce la vida dentro del rango [3000, 3750]";
            const string MsgBarbarianAttack = "Introduce el ataque dentro del rango [150, 250]";
            const string MsgBarbarianReduction = "Introduce la reducción de daño dentro del rango [35, 45]%";
            const string MsgMagician = " __  __          _____          \r\n |  \\/  |   /\\   / ____|   /\\    \r\n | \\  / |  /  \\ | |  __   /  \\   \r\n | |\\/| | / /\\ \\| | |_ | / /\\ \\  \r\n | |  | |/ ____ \\ |__| |/ ____ \\ \r\n |_|  |_/_/    \\_\\_____/_/    \\_\\\r\n                                 \r\n                                 ";
            const string MsgMagicianLife = "Introduce la vida dentro del rango [1100, 1500]";
            const string MsgMagicianAttack = "Introduce el ataque dentro del rango [300, 400]";
            const string MsgMagicianReduction = "Introduce la reducción de daño dentro del rango [20, 35]%";
            const string MsgDruid = "  _____  _____  _    _ _____ _____          \r\n |  __ \\|  __ \\| |  | |_   _|  __ \\   /\\    \r\n | |  | | |__) | |  | | | | | |  | | /  \\   \r\n | |  | |  _  /| |  | | | | | |  | |/ /\\ \\  \r\n | |__| | | \\ \\| |__| |_| |_| |__| / ____ \\ \r\n |_____/|_|  \\_\\\\____/|_____|_____/_/    \\_\\\r\n                                            \r\n                                            ";
            const string MsgDruidLife = "Introduce la vida dentro del rango [2000, 2500]";
            const string MsgDruidAttack = "Introduce el ataque dentro del rango [70, 150]";
            const string MsgDruidReduction = "Introduce la reducción de daño dentro del rango [25, 40]%";
            const string MsgMonster = "  __  __  ____  _   _  _____ _______ _____  _    _  ____  \r\n |  \\/  |/ __ \\| \\ | |/ ____|__   __|  __ \\| |  | |/ __ \\ \r\n | \\  / | |  | |  \\| | (___    | |  | |__) | |  | | |  | |\r\n | |\\/| | |  | | . ` |\\___ \\   | |  |  _  /| |  | | |  | |\r\n | |  | | |__| | |\\  |____) |  | |  | | \\ \\| |__| | |__| |\r\n |_|  |_|\\____/|_| \\_|_____/   |_|  |_|  \\_\\\\____/ \\____/ \r\n                                                          \r\n                                                          ";
            const string MsgMonsterLife = "Introduce la vida dentro del rango [7000, 10000]";
            const string MsgMonsterAttack = "Introduce el ataque dentro del rango [300, 400]";
            const string MsgMonsterReduction = "Introduce la reducción de daño dentro del rango [20, 30]%";
            const int MaxAttempts = 3, levelOne = 1, levelFour = 4, MinArcherLife = 1500, MaxArcherLife = 2000, MinArcherAttack = 200, MaxArcherAttack = 300, MinArcherReduction = 25, MaxArcherReduction = 35,
            MinBarbarianLife = 3000, MaxBarbarianLife = 3750, MinBarbarianAttack = 150, MaxBarbarianAttack = 250, MinBarbarianReduction = 35, MaxBarbarianReduction = 45,
            MinMagicianLife = 1100, MaxMagicianLife = 1500,  MinMagicianAttack = 300, MaxMagicianAttack = 400, MinMagicianReduction = 20, MaxMagicianReduction = 35, 
            MinDruidLife = 2000, MaxDruidLife = 2500, MinDruidAttack = 70, MaxDruidAttack = 150, MinDruidReduction = 25, MaxDruidReduction = 40,
            MinMonsterLife = 7000, MaxMonsterLife = 10000, MinMonsterAttack = 300, MaxMonsterAttack = 400, MinMonsterReduction = 20, MaxMonsterReduction = 30;

            int attempts = 0, level, auxEnd = 123456789, archerLife, archerAttack, archerReduction, barbarianLife, barbarianAttack, barbarianReduction, magicianLife, magicianAttack, magicianReduction, druidLife, druidAttack, druidReduction, monsterLife, monsterAttack, monsterReduction;

            do
            {
                Console.Clear();
                if (!MostrarMensajeBienvenida()) { return; }
                do
                {
                    Console.WriteLine(MsgDifficulty);
                    level = Convert.ToInt32(Console.ReadLine());
                    attempts++;
                } while (!EscogerDificultad(level, levelOne, levelFour) && attempts < MaxAttempts);
                if (attempts == MaxAttempts)
                {
                    Console.WriteLine(MsgOutOfAttempts);
                    auxEnd = 987654321;
                }
                Console.Clear();
            
            string userInput = IntroducirNombrePersonajes();
            string[] names = userInput.Split(' ');
            string archerName = names[0];
            string barbarianName = names[1];
            string magicianName = names[2];
            string druidName = names[3];
            Console.Clear();
            switch (level)
            {
                case 1:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    archerLife = MaxArcherLife; archerAttack = MaxArcherAttack; archerReduction = MaxArcherReduction;
                    Console.WriteLine(MsgArcher);
                    MostrarValores(archerLife, archerAttack, archerReduction);

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    barbarianLife = MaxBarbarianLife; barbarianAttack = MaxBarbarianAttack; barbarianReduction = MaxBarbarianReduction;
                    Console.WriteLine(MsgBarbarian);
                    MostrarValores(barbarianLife, barbarianAttack, barbarianReduction);

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    magicianLife = MaxMagicianLife; magicianAttack = MaxMagicianAttack; magicianReduction = MaxMagicianReduction;
                    Console.WriteLine(MsgMagician);
                    MostrarValores(magicianLife, magicianAttack, magicianReduction);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    druidLife = MaxDruidLife; druidAttack = MaxDruidAttack; druidReduction = MaxDruidReduction;
                    Console.WriteLine(MsgDruid);
                    MostrarValores(druidLife, druidAttack, druidReduction);

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    monsterLife = MinMonsterLife; monsterAttack = MinMonsterAttack; monsterReduction = MinMonsterReduction;
                    Console.WriteLine(MsgMonster);
                    MostrarValores(monsterLife, monsterAttack, monsterReduction);
                    break;
                case 2:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    archerLife = MinArcherLife; archerAttack = MinArcherAttack; archerReduction = MinArcherReduction;
                    Console.WriteLine(MsgArcher);
                    MostrarValores(archerLife, archerAttack, archerReduction);

                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    barbarianLife = MinBarbarianLife; barbarianAttack = MinBarbarianAttack; barbarianReduction = MinBarbarianReduction;
                    Console.WriteLine(MsgBarbarian);
                    MostrarValores(barbarianLife, barbarianAttack, barbarianReduction);

                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    magicianLife = MinMagicianLife; magicianAttack = MinMagicianAttack; magicianReduction = MinMagicianReduction;
                    Console.WriteLine(MsgMagician);
                    MostrarValores(magicianLife, magicianAttack, magicianReduction);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    druidLife = MinDruidLife; druidAttack = MinDruidAttack; druidReduction = MinDruidReduction;
                    Console.WriteLine(MsgDruid);
                    MostrarValores(druidLife, druidAttack, druidReduction);

                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    monsterLife = MaxMonsterLife; monsterAttack = MaxMonsterAttack; monsterReduction = MaxMonsterReduction;
                    Console.WriteLine(MsgMonster);
                    MostrarValores(monsterLife, monsterAttack, monsterReduction);

                    break;
                case 3:
                    Console.Clear(); //ARQUERA 
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(MsgArcher);
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgArcherLife);
                        archerLife = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(archerLife, MaxArcherLife, MinArcherLife) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); archerLife = MinArcherLife; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgArcherAttack);
                        archerAttack = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(archerAttack, MaxArcherAttack, MinArcherAttack) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); archerAttack = MinArcherAttack; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgArcherReduction);
                        archerReduction = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(archerReduction, MaxArcherReduction, MinArcherReduction) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); archerReduction = MinArcherReduction; }

                    Console.Clear(); //BÁRBARO
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(MsgBarbarian);
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgBarbarianLife);
                        barbarianLife = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(barbarianLife, MaxBarbarianLife, MinBarbarianLife) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); barbarianLife = MinBarbarianLife; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgBarbarianAttack);
                        barbarianAttack = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(barbarianAttack, MaxBarbarianAttack, MinBarbarianAttack) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); barbarianAttack = MinBarbarianAttack; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgBarbarianReduction);
                        barbarianReduction = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(barbarianReduction, MaxBarbarianReduction, MinBarbarianReduction) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); barbarianReduction = MinBarbarianReduction; }

                    Console.Clear(); //MAGA
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(MsgMagician);
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgMagicianLife);
                        magicianLife = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(magicianLife, MaxMagicianLife, MinMagicianLife) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); magicianLife = MinMagicianLife; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgMagicianAttack);
                        magicianAttack = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(magicianAttack, MaxMagicianAttack, MinMagicianAttack) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); magicianAttack = MinMagicianAttack; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgMagicianReduction);
                        magicianReduction = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(magicianReduction, MaxMagicianReduction, MinMagicianReduction) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); magicianReduction = MinMagicianReduction; }

                    Console.Clear(); //DRUIDA
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(MsgDruid);
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgDruidLife);
                        druidLife = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(druidLife, MaxDruidLife, MinDruidLife) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); druidLife = MinDruidLife; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgDruidAttack);
                        druidAttack = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(druidAttack, MaxDruidAttack, MinDruidAttack) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); druidAttack = MinDruidAttack; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgDruidReduction);
                        druidReduction = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(druidReduction, MaxDruidReduction, MinDruidReduction) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); druidReduction = MinDruidReduction; }

                    Console.Clear(); //MONSTRUO
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(MsgMonster);
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgMonsterLife);
                        monsterLife = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(monsterLife, MaxMonsterLife, MinMonsterLife) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); monsterLife = MinMonsterLife; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgMonsterAttack);
                        monsterAttack = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(monsterAttack, MaxMonsterAttack, MinMonsterAttack) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); monsterAttack = MinMonsterAttack; }
                    attempts = 0;
                    do
                    {
                        Console.WriteLine(MsgMonsterReduction);
                        monsterReduction = Convert.ToInt32(Console.ReadLine());
                        attempts++;
                    } while (!AñadirValoresPersonalizados(monsterReduction, MaxMonsterReduction, MinMonsterReduction) && attempts < MaxAttempts);
                    if (attempts == 3) { Console.WriteLine($"{MsgOutOfAttempts}, se te atribuye el valor más bajo"); monsterReduction = MinMonsterReduction; }

                    break;
                case 4:
                    Console.Clear();
                    archerLife = AñadirValoresRandom(MinArcherLife, MaxArcherLife);
                    archerAttack = AñadirValoresRandom(MinArcherAttack, MaxArcherAttack);
                    archerReduction = AñadirValoresRandom(MinArcherReduction, MaxArcherReduction);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine(MsgArcher);
                    MostrarValores(archerLife, archerAttack, archerReduction);

                    barbarianLife = AñadirValoresRandom(MinBarbarianLife, MaxBarbarianLife);
                    barbarianAttack = AñadirValoresRandom(MinBarbarianAttack, MaxBarbarianAttack);
                    barbarianReduction = AñadirValoresRandom(MinBarbarianReduction, MaxBarbarianReduction);
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine(MsgBarbarian);
                    MostrarValores(barbarianLife, barbarianAttack, barbarianReduction);

                    magicianLife = AñadirValoresRandom(MinMagicianLife, MaxMagicianLife);
                    magicianAttack = AñadirValoresRandom(MinMagicianAttack, MaxMagicianAttack);
                    magicianReduction = AñadirValoresRandom(MinMagicianReduction, MaxMagicianReduction);
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                    Console.WriteLine(MsgMagician);
                    MostrarValores(magicianLife, magicianAttack, magicianReduction);

                    druidLife = AñadirValoresRandom(MinDruidLife, MaxDruidLife);
                    druidAttack = AñadirValoresRandom(MinDruidAttack, MaxDruidAttack);
                    druidReduction = AñadirValoresRandom(MinDruidReduction, MaxDruidReduction);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(MsgDruid);
                    MostrarValores(druidLife, druidAttack, druidReduction);

                    monsterLife = AñadirValoresRandom(MinMonsterLife, MaxMonsterLife);
                    monsterAttack = AñadirValoresRandom(MinMonsterAttack, MaxMonsterAttack);
                    monsterReduction = AñadirValoresRandom(MinMonsterReduction, MaxMonsterReduction);
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    Console.WriteLine(MsgMonster);
                    MostrarValores(monsterLife, monsterAttack, monsterReduction);

                    Console.WriteLine(MsgContinue);
                    Console.ReadKey();
                    break;

            }
           
            } while (auxEnd == 123456789);
        }
        public static void OrdenarVidas(int archerLife, int barbarianLife, int magicianLife, int druidLife, string archerName, string barbarianName, string magicianName, string druidName)
        {
            string[] heroesNames = { archerName, barbarianName, magicianName, druidName };
            int[] heroes = { archerLife, barbarianLife, magicianLife, druidLife };
            int n = heroes.Length;


            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (heroes[j] < heroes[j + 1])
                    {
                        int tempLife = heroes[j];
                        heroes[j] = heroes[j + 1];
                        heroes[j + 1] = tempLife;

                        string tempName = heroesNames[j];
                        heroesNames[j] = heroesNames[j + 1];
                        heroesNames[j + 1] = tempName;
                    }
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"{heroesNames[i]}: {heroes[i]}");
            }
        }
        public static int AñadirValoresRandom(int Min, int Max) 
        { 
            Random rand = new Random();
            int result = rand.Next(Min, Max);
            return result; 
        }
        public static bool AñadirValoresPersonalizados(int life, int Max,  int Min)
        {
            if (life < Min || life > Max)
            {
                return false;
            }
            else { return true; }
        }
        public static void MostrarValores (int life, int attack, int reduction)
        {
            Console.WriteLine($"Vida: {life}");
            Console.WriteLine($"Ataque: {attack}");
            Console.WriteLine($"Reducción: {reduction}");
        }
        public static bool EscogerDificultad(int level, int levelOne, int levelFour)
        {
            if (level < levelOne || level > levelFour)
            {
                return false;
            }
            else { return true; }

        }
        public static string IntroducirNombrePersonajes()
        {
            const string MsgNames = "| Introduce el nombre a los 4 personajes, separándolos por un espacio: |";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(MsgNames);
            Console.ForegroundColor = ConsoleColor.White;
            string userInput = Console.ReadLine();
            return (userInput);
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

    }
}

