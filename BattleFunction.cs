using System.Diagnostics;

namespace BattleFunction
{
    public class MyBattle
    {
        public static void StartBattle(int monsterLife, int archerLife, int barbarianLife, int magicianLife, int druidLife, int monsterAttack, int archerAttack, int barbarianAttack, int magicianAttack, int druidAttack, int monsterReduction, int archerReduction, int barbarianReduction, int magicianReduction, int druidReduction, string archerName, string barbarianName, string magicianName, string druidName)
        {
            const string MSG = " 1-Atacar, 2-Defender, 3-Habilidad especial";
            const int ZERO = 0, Players = 4, ActiveArcher = 10, ActiveBarbarian = 20, ActiveMagician = 30, ActiveDruid = 40;
            const int MaxAttempts = 3;
            int option, attempts = 0, archerHability = 0, barbarianHability = 0, magicianHability = 0, druidHability = 0 ;
            bool archerDefense, barbarianDefense, magicianDefense, druidDefense;
            Console.ReadKey();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
                while (monsterLife >= ZERO && (archerLife > ZERO || barbarianLife > ZERO || magicianLife > ZERO || druidLife > ZERO))
                {
                    archerDefense = false;barbarianDefense=false;magicianDefense = false;druidDefense = false;
                    for (int i = 0; i < Players; i++)
                    {
                        archerHability = ZERO; barbarianHability = ZERO; magicianHability = ZERO; druidHability = ZERO;
                        int random = AtacarRandom();
                        switch (random)
                        {
                            case 1:
                            if (magicianLife > 0)
                            {
                                do
                                {
                                    Console.WriteLine(archerName + MSG);
                                    option = Convert.ToInt32(Console.ReadLine());
                                    attempts++;
                                    if (option == 1)
                                    {
                                        monsterLife = AtacarPersonaje(monsterLife, monsterReduction, archerAttack, archerName, archerHability);
                                        break;
                                    }
                                    else if (option == 2)
                                    {
                                        archerDefense = true;
                                        break;
                                    }
                                    else
                                    {
                                        archerHability = ActiveArcher;
                                        break;
                                    }

                                } while (attempts < MaxAttempts && option != 1 || option != 2 || option != 3);
                                if (attempts == MaxAttempts)
                                {
                                    break;
                                }
                                break;
                            }
                            break;
                                
                            case 2:
                            if (barbarianLife > 0)
                            {
                                do
                                {
                                    Console.WriteLine(barbarianName + MSG);
                                    option = Convert.ToInt32(Console.ReadLine());
                                    attempts++;
                                    if (option == 1)
                                    {
                                        monsterLife = AtacarPersonaje(monsterLife, monsterReduction, barbarianAttack, barbarianName, barbarianHability);
                                        break;
                                    }
                                    else if (option == 2)
                                    {
                                        barbarianDefense = true;
                                        break;
                                    }
                                    else
                                    {
                                        barbarianHability = ActiveBarbarian;
                                        break;
                                    }
                                } while (attempts < MaxAttempts && option != 1 || option != 2 || option != 3);
                                if (attempts == MaxAttempts)
                                {
                                    break;
                                }
                                break;
                            }
                            break;
                        case 3:
                                if (magicianLife > ZERO)
                            {
                                do
                                {
                                    Console.WriteLine(magicianName + MSG);
                                    option = Convert.ToInt32(Console.ReadLine());
                                    attempts++;
                                    if (option == 1)
                                    {
                                        monsterLife = AtacarPersonaje(monsterLife, monsterReduction, magicianAttack, magicianName, magicianHability);
                                        break;
                                    }
                                    else if (option == 2)
                                    {
                                        magicianDefense = true;
                                        break;
                                    }
                                    else
                                    {
                                        magicianHability = ActiveMagician;
                                        break;
                                    }

                                } while (attempts < MaxAttempts && option != 1 || option != 2 || option != 3);
                                if (attempts == MaxAttempts)
                                {
                                    break;
                                }
                                break;
                            }
                            break;
                                
                                
                            case 4:
                            if (druidLife > ZERO)
                            {
                                do
                                {
                                    Console.WriteLine(druidName + MSG);
                                    option = Convert.ToInt32(Console.ReadLine());
                                    attempts++;
                                    if (option == 1)
                                    {
                                        monsterLife = AtacarPersonaje(monsterLife, monsterReduction, druidAttack, druidName, druidHability);
                                        break;
                                    }
                                    else if (option == 2)
                                    {
                                        druidDefense = true;
                                        break;
                                    }
                                    else
                                    {
                                        druidHability = ActiveDruid;
                                        break;
                                    }
                                } while (attempts < MaxAttempts && option != 1 || option != 2 || option != 3);
                                if (attempts == MaxAttempts)
                                {
                                    break;
                                }
                                break;
                            }
                            break;
                        }

                    
                    }
                archerLife = AtacarMonstruo(archerDefense, archerLife, archerReduction, monsterAttack, archerName, archerHability);
                barbarianLife = AtacarMonstruo(barbarianDefense, barbarianLife, barbarianReduction, monsterAttack, barbarianName, barbarianHability);
                magicianLife = AtacarMonstruo(magicianDefense, magicianLife, magicianReduction, monsterAttack, magicianName, magicianHability);
                druidLife = AtacarMonstruo(druidDefense, druidLife, druidReduction, monsterAttack, druidName, druidHability);
                OrdenarVidas(archerLife, barbarianLife, magicianLife, druidLife, archerName, barbarianName, magicianName, druidName);

                if (druidHability == ActiveDruid)
                {
                    archerLife = archerLife + 500;
                    barbarianLife = barbarianLife + 500;
                    magicianLife = magicianLife + 500;
                    druidLife = druidLife + 500;
                }


            }
            StopBattle(monsterLife);
        }
        public static int AtacarMonstruo(bool defense, int life,  int reduction, int attack, string name, int hability)
        {
            Console.WriteLine();
            if (hability == 10) //Activa la habilidad de la arquera
            {
                Console.WriteLine("El monstruo no puede atacar porque ha sido noqueado");
                return life;
            }
            else if (hability == 20) //Activa la habilidad del bárbaro
            {
                Console.WriteLine($"{name} se defiende por completo");
                return life;
            }
            {
                if (defense == true)
                {
                    Console.WriteLine($"El monstruo ataca y hace {attack} puntos de daño");
                    reduction = reduction * 2; // se añade el doble de reducción de daño porque así se ha escogido
                    int finalDamage = attack * reduction / 100;
                    life -= (attack - finalDamage);
                    Console.WriteLine($"{name} usa su habilidad de defensa y recibe solo {finalDamage} puntos de daño");
                    Console.WriteLine($"Vida restante de {name}: {life}");
                    return life;
                }
                else
                {
                    Console.WriteLine($"El monstruo ataca y hace {attack} puntos de daño");
                    int finalDamage = attack * reduction / 100;
                    life -= (attack - finalDamage);
                    Console.WriteLine($"{name} se defiende y recibe solo {finalDamage} puntos de daño");
                    Console.WriteLine($"Vida restante de {name}: {life}");
                    return life;
                }
            }
            

        }
        public static int AtacarPersonaje(int monsterLife, int monsterReduction, int attack, string name, int hability) 
        {
            Console.WriteLine();
            if (hability == 30) //Activa la habilidad de la maga
            {
                Console.WriteLine($"{name} ataca y hace {attack * 3} puntos de daño");
                int finalDamage = (attack*3) * monsterReduction / 100;
                monsterLife -= (attack - finalDamage);
                Console.WriteLine($"El monstruo se defiende y recibe solo {finalDamage} puntos de daño");
                Console.WriteLine($"Vida restante del monstruo: {monsterLife}");
                return monsterLife;
            }
            else
            {
                Console.WriteLine($"{name} ataca y hace {attack} puntos de daño");
                int finalDamage = attack * monsterReduction / 100;
                monsterLife -= (attack - finalDamage);
                Console.WriteLine($"El monstruo se defiende y recibe solo {finalDamage} puntos de daño");
                Console.WriteLine($"Vida restante del monstruo: {monsterLife}");
                return monsterLife;
            }
            
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
        public static void StopBattle(int monsterLife)
        {
            if (monsterLife <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Han ganado los héroes");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ha ganado el monstruo");
                Console.ReadKey();
            }
        }
        public static int AtacarRandom()
        {
            Random random = new Random();
            return random.Next(1, 4);
        }
    }
}