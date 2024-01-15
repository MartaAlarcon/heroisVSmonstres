using System;
using System.Reflection.PortableExecutable;

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
                Console.Clear();
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
                case 3:
                    int [] archerCustomized = AñadirValoresAqueraNivelPersonalizado();
                    int[] barbarianCustomized = AñadirValoresBarbaroNivelPersonalizado();
                    int[] magicianCustomized = AñadirValoresMagaNivelPersonalizado();
                    int[] druidCustomized = AñadirValoresDruidaNivelPersonalizado();
                    int[] monsterCustomized = AñadirValoresMonstruoNivelPersonalizado();
                    Console.WriteLine(MsgContinue);
                    Console.ReadKey();
                    break;
            }
        }
        public static int[] AñadirValoresAqueraNivelPersonalizado()
        {
            const string MsgArcher = "           _____   ____  _    _ ______ _____            \r\n     /\\   |  __ \\ / __ \\| |  | |  ____|  __ \\     /\\    \r\n    /  \\  | |__) | |  | | |  | | |__  | |__) |   /  \\   \r\n   / /\\ \\ |  _  /| |  | | |  | |  __| |  _  /   / /\\ \\  \r\n  / ____ \\| | \\ \\| |__| | |__| | |____| | \\ \\  / ____ \\ \r\n /_/    \\_\\_|  \\_\\\\___\\_\\\\____/|______|_|  \\_\\/_/    \\_\\\r\n                                                        \r\n                                                        ";
            const string MsgLife = "Introduce la vida dentro del rango [1500, 2000]";
            const string MsgAttack = "Introduce el ataque dentro del rango [200, 300]";
            const string MsgReduction = "Introduce la reducción de daño dentro del rango [25, 35]%";
            const string MsgOutOfAttempts = "Se atribuye el valor más bajo por quedarte sin intentos";
            const int MaxAttemptsLife = 3, MinLife = 1500, MaxLife = 2000, MaxAttemptsAttack = 3, MinAttack = 200, MaxAttack = 300, MaxAttemptsReduction = 3, MinReduction = 25, MaxReduction = 35;
            int[] archer = new int[3];
            int life, attack, reduction, attemptsLife = 0, attemptsAttack = 0, attemptsReduction = 0 ;
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(MsgArcher);
            do
            {
                Console.WriteLine(MsgLife);
                life = Convert.ToInt32(Console.ReadLine());
                if (life >= MinLife && life <= MaxLife)
                {
                    archer[0] = life;
                    attemptsLife = MaxAttemptsLife + 1;
                }
                attemptsLife++;
            } while (attemptsLife < MaxAttemptsLife);
            if (attemptsLife == MaxAttemptsLife)
            {
                Console.WriteLine(MsgOutOfAttempts);
                archer[0] = MinLife;
            }
            do
            {
                Console.WriteLine(MsgAttack);
                attack = Convert.ToInt32(Console.ReadLine());
                if (attack >= MinAttack && attack <= MaxAttack)
                {
                    archer[1] = attack;
                    attemptsAttack = MaxAttemptsAttack + 1;
                }
                attemptsAttack++;
            } while (attemptsAttack < MaxAttemptsAttack);
            if (attemptsAttack == MaxAttemptsAttack)
            {
                Console.WriteLine(MsgOutOfAttempts);
                archer[1] = MinAttack;
            }
            do
            {
                Console.WriteLine(MsgReduction);
                reduction = Convert.ToInt32(Console.ReadLine());
                if (reduction >= MinReduction && reduction <= MaxReduction)
                {
                    archer[2] = reduction;
                    attemptsReduction = MaxAttemptsReduction + 1;
                }
                attemptsReduction++;
            } while (attemptsReduction < MaxAttemptsReduction);
            if (attemptsReduction == MaxAttemptsReduction)
            {
                Console.WriteLine(MsgOutOfAttempts);
                archer[2] = MinReduction;
            }
            Console.WriteLine();
            Console.WriteLine($"Vida: {archer[0]}");
            Console.WriteLine($"Ataque: {archer[1]}");
            Console.WriteLine($"Reducción: {archer[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            return archer;
        }
        public static int[] AñadirValoresBarbaroNivelPersonalizado()
        {
            const string MsgBarbarian = "  ____    __   _____  ____          _____   ____  \r\n |  _ \\  /_/  |  __ \\|  _ \\   /\\   |  __ \\ / __ \\ \r\n | |_) | / \\  | |__) | |_) | /  \\  | |__) | |  | |\r\n |  _ < / _ \\ |  _  /|  _ < / /\\ \\ |  _  /| |  | |\r\n | |_) / ___ \\| | \\ \\| |_) / ____ \\| | \\ \\| |__| |\r\n |____/_/   \\_\\_|  \\_\\____/_/    \\_\\_|  \\_\\\\____/ \r\n                                                  \r\n                                                  ";
            const string MsgLife = "Introduce la vida dentro del rango [3000, 3750]";
            const string MsgAttack = "Introduce el ataque dentro del rango [150, 250]";
            const string MsgReduction = "Introduce la reducción de daño dentro del rango [35, 45]%";
            const string MsgOutOfAttempts = "Se atribuye el valor más bajo por quedarte sin intentos";
            const int MaxAttemptsLife = 3, MinLife = 3000, MaxLife = 3750, MaxAttemptsAttack = 3, MinAttack = 150, MaxAttack = 250, MaxAttemptsReduction = 3, MinReduction = 35, MaxReduction = 45;
            int[] barbarian = new int[3];
            int life, attack, reduction, attemptsLife = 0, attemptsAttack = 0, attemptsReduction = 0;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(MsgBarbarian);
            do
            {
                Console.WriteLine(MsgLife);
                life = Convert.ToInt32(Console.ReadLine());
                if (life >= MinLife && life <= MaxLife)
                {
                    barbarian[0] = life;
                    attemptsLife = MaxAttemptsLife + 1;
                }
                attemptsLife++;
            } while (attemptsLife < MaxAttemptsLife);
            if (attemptsLife == MaxAttemptsLife)
            {
                Console.WriteLine(MsgOutOfAttempts);
                barbarian[0] = MinLife;
            }
            do
            {
                Console.WriteLine(MsgAttack);
                attack = Convert.ToInt32(Console.ReadLine());
                if (attack >= MinAttack && attack <= MaxAttack)
                {
                    barbarian[1] = attack;
                    attemptsAttack = MaxAttemptsAttack + 1;
                }
                attemptsAttack++;
            } while (attemptsAttack < MaxAttemptsAttack);
            if (attemptsAttack == MaxAttemptsAttack)
            {
                Console.WriteLine(MsgOutOfAttempts);
                barbarian[1] = MinAttack;
            }
            do
            {
                Console.WriteLine(MsgReduction);
                reduction = Convert.ToInt32(Console.ReadLine());
                if (reduction >= MinReduction && reduction <= MaxReduction)
                {
                    barbarian[2] = reduction;
                    attemptsReduction = MaxAttemptsReduction + 1;
                }
                attemptsReduction++;
            } while (attemptsReduction < MaxAttemptsReduction);
            if (attemptsReduction == MaxAttemptsReduction)
            {
                Console.WriteLine(MsgOutOfAttempts);
                barbarian[2] = MinReduction;
            }
            Console.WriteLine();
            Console.WriteLine($"Vida: {barbarian[0]}");
            Console.WriteLine($"Ataque: {barbarian[1]}");
            Console.WriteLine($"Reducción: {barbarian[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            return barbarian;
        }
        public static int[] AñadirValoresMagaNivelPersonalizado()
        {
            const string MsgMagician = " __  __          _____          \r\n |  \\/  |   /\\   / ____|   /\\    \r\n | \\  / |  /  \\ | |  __   /  \\   \r\n | |\\/| | / /\\ \\| | |_ | / /\\ \\  \r\n | |  | |/ ____ \\ |__| |/ ____ \\ \r\n |_|  |_/_/    \\_\\_____/_/    \\_\\\r\n                                 \r\n                                 ";
            const string MsgLife = "Introduce la vida dentro del rango [1100, 1500]";
            const string MsgAttack = "Introduce el ataque dentro del rango [300, 400]";
            const string MsgReduction = "Introduce la reducción de daño dentro del rango [20, 35]%";
            const string MsgOutOfAttempts = "Se atribuye el valor más bajo por quedarte sin intentos";
            const int MaxAttemptsLife = 3, MinLife = 1100, MaxLife = 1500, MaxAttemptsAttack = 3, MinAttack = 300, MaxAttack = 400, MaxAttemptsReduction = 3, MinReduction = 20, MaxReduction = 35;
            int[] magician = new int[3];
            int life, attack, reduction, attemptsLife = 0, attemptsAttack = 0, attemptsReduction = 0;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(MsgMagician);
            do
            {
                Console.WriteLine(MsgLife);
                life = Convert.ToInt32(Console.ReadLine());
                if (life >= MinLife && life <= MaxLife)
                {
                    magician[0] = life;
                    attemptsLife = MaxAttemptsLife + 1;
                }
                attemptsLife++;
            } while (attemptsLife < MaxAttemptsLife);
            if (attemptsLife == MaxAttemptsLife)
            {
                Console.WriteLine(MsgOutOfAttempts);
                magician[0] = MinLife;
            }
            do
            {
                Console.WriteLine(MsgAttack);
                attack = Convert.ToInt32(Console.ReadLine());
                if (attack >= MinAttack && attack <= MaxAttack)
                {
                    magician[1] = attack;
                    attemptsAttack = MaxAttemptsAttack + 1;
                }
                attemptsAttack++;
            } while (attemptsAttack < MaxAttemptsAttack);
            if (attemptsAttack == MaxAttemptsAttack)
            {
                Console.WriteLine(MsgOutOfAttempts);
                magician[1] = MinAttack;
            }
            do
            {
                Console.WriteLine(MsgReduction);
                reduction = Convert.ToInt32(Console.ReadLine());
                if (reduction >= MinReduction && reduction <= MaxReduction)
                {
                    magician[2] = reduction;
                    attemptsReduction = MaxAttemptsReduction + 1;
                }
                attemptsReduction++;
            } while (attemptsReduction < MaxAttemptsReduction);
            if (attemptsReduction == MaxAttemptsReduction)
            {
                Console.WriteLine(MsgOutOfAttempts);
                magician[2] = MinReduction;
            }
            Console.WriteLine();
            Console.WriteLine($"Vida: {magician[0]}");
            Console.WriteLine($"Ataque: {magician[1]}");
            Console.WriteLine($"Reducción: {magician[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            return magician;
        }
        public static int[] AñadirValoresDruidaNivelPersonalizado()
        {
            const string MsgDruid = "  _____  _____  _    _ _____ _____          \r\n |  __ \\|  __ \\| |  | |_   _|  __ \\   /\\    \r\n | |  | | |__) | |  | | | | | |  | | /  \\   \r\n | |  | |  _  /| |  | | | | | |  | |/ /\\ \\  \r\n | |__| | | \\ \\| |__| |_| |_| |__| / ____ \\ \r\n |_____/|_|  \\_\\\\____/|_____|_____/_/    \\_\\\r\n                                            \r\n                                            ";
            const string MsgLife = "Introduce la vida dentro del rango [2000, 2500]";
            const string MsgAttack = "Introduce el ataque dentro del rango [70, 150]";
            const string MsgReduction = "Introduce la reducción de daño dentro del rango [25, 40]%";
            const string MsgOutOfAttempts = "Se atribuye el valor más bajo por quedarte sin intentos";
            const int MaxAttemptsLife = 3, MinLife = 2000, MaxLife = 2500, MaxAttemptsAttack = 3, MinAttack = 70, MaxAttack = 150, MaxAttemptsReduction = 3, MinReduction = 25, MaxReduction = 40;
            int[] druid = new int[3];
            int life, attack, reduction, attemptsLife = 0, attemptsAttack = 0, attemptsReduction = 0;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(MsgDruid);
            do
            {
                Console.WriteLine(MsgLife);
                life = Convert.ToInt32(Console.ReadLine());
                if (life >= MinLife && life <= MaxLife)
                {
                    druid[0] = life;
                    attemptsLife = MaxAttemptsLife + 1;
                }
                attemptsLife++;
            } while (attemptsLife < MaxAttemptsLife);
            if (attemptsLife == MaxAttemptsLife)
            {
                Console.WriteLine(MsgOutOfAttempts);
                druid[0] = MinLife;
            }
            do
            {
                Console.WriteLine(MsgAttack);
                attack = Convert.ToInt32(Console.ReadLine());
                if (attack >= MinAttack && attack <= MaxAttack)
                {
                    druid[1] = attack;
                    attemptsAttack = MaxAttemptsAttack + 1;
                }
                attemptsAttack++;
            } while (attemptsAttack < MaxAttemptsAttack);
            if (attemptsAttack == MaxAttemptsAttack)
            {
                Console.WriteLine(MsgOutOfAttempts);
                druid[1] = MinAttack;
            }
            do
            {
                Console.WriteLine(MsgReduction);
                reduction = Convert.ToInt32(Console.ReadLine());
                if (reduction >= MinReduction && reduction <= MaxReduction)
                {
                    druid[2] = reduction;
                    attemptsReduction = MaxAttemptsReduction + 1;
                }
                attemptsReduction++;
            } while (attemptsReduction < MaxAttemptsReduction);
            if (attemptsReduction == MaxAttemptsReduction)
            {
                Console.WriteLine(MsgOutOfAttempts);
                druid[2] = MinReduction;
            }
            Console.WriteLine();
            Console.WriteLine($"Vida: {druid[0]}");
            Console.WriteLine($"Ataque: {druid[1]}");
            Console.WriteLine($"Reducción: {druid[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            return druid;
        }
        public static int[] AñadirValoresMonstruoNivelPersonalizado()
        {
            const string MsgMonster = "  __  __  ____  _   _  _____ _______ _____  _    _  ____  \r\n |  \\/  |/ __ \\| \\ | |/ ____|__   __|  __ \\| |  | |/ __ \\ \r\n | \\  / | |  | |  \\| | (___    | |  | |__) | |  | | |  | |\r\n | |\\/| | |  | | . ` |\\___ \\   | |  |  _  /| |  | | |  | |\r\n | |  | | |__| | |\\  |____) |  | |  | | \\ \\| |__| | |__| |\r\n |_|  |_|\\____/|_| \\_|_____/   |_|  |_|  \\_\\\\____/ \\____/ \r\n                                                          \r\n                                                          ";
            const string MsgLife = "Introduce la vida dentro del rango [7000, 10000]";
            const string MsgAttack = "Introduce el ataque dentro del rango [300, 400]";
            const string MsgReduction = "Introduce la reducción de daño dentro del rango [20, 30]%";
            const string MsgOutOfAttempts = "Se atribuye el valor más bajo por quedarte sin intentos";
            const int MaxAttemptsLife = 3, MinLife = 7000, MaxLife = 10000, MaxAttemptsAttack = 3, MinAttack = 300, MaxAttack = 400, MaxAttemptsReduction = 3, MinReduction = 20, MaxReduction = 30;
            int[] monster = new int[3];
            int life, attack, reduction, attemptsLife = 0, attemptsAttack = 0, attemptsReduction = 0;
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine(MsgMonster);
            do
            {
                Console.WriteLine(MsgLife);
                life = Convert.ToInt32(Console.ReadLine());
                if (life >= MinLife && life <= MaxLife)
                {
                    monster[0] = life;
                    attemptsLife = MaxAttemptsLife + 1;
                }
                attemptsLife++;
            } while (attemptsLife < MaxAttemptsLife);
            if (attemptsLife == MaxAttemptsLife)
            {
                Console.WriteLine(MsgOutOfAttempts);
                monster[0] = MinLife;
            }
            do
            {
                Console.WriteLine(MsgAttack);
                attack = Convert.ToInt32(Console.ReadLine());
                if (attack >= MinAttack && attack <= MaxAttack)
                {
                    monster[1] = attack;
                    attemptsAttack = MaxAttemptsAttack + 1;
                }
                attemptsAttack++;
            } while (attemptsAttack < MaxAttemptsAttack);
            if (attemptsAttack == MaxAttemptsAttack)
            {
                Console.WriteLine(MsgOutOfAttempts);
                monster[1] = MinAttack;
            }
            do
            {
                Console.WriteLine(MsgReduction);
                reduction = Convert.ToInt32(Console.ReadLine());
                if (reduction >= MinReduction && reduction <= MaxReduction)
                {
                    monster[2] = reduction;
                    attemptsReduction = MaxAttemptsReduction + 1;
                }
                attemptsReduction++;
            } while (attemptsReduction < MaxAttemptsReduction);
            if (attemptsReduction == MaxAttemptsReduction)
            {
                Console.WriteLine(MsgOutOfAttempts);
                monster[2] = MinReduction;
            }
            Console.WriteLine();
            Console.WriteLine($"Vida: {monster[0]}");
            Console.WriteLine($"Ataque: {monster[1]}");
            Console.WriteLine($"Reducción: {monster[2]}%");
            Console.ForegroundColor = ConsoleColor.White;
            return monster;
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
