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

        }
        public static void MostrarMensajeBienvenida()
        {
            const string MsgWelcome = "=============================================\r\n         Bienvenid@ a Héroes vs Monstruo\r\n=============================================";                       
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(MsgWelcome);
            Console.ResetColor();
        }

    }
}
