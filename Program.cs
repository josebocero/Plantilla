using System;
using static System.Console;

namespace PlantillaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Clear();
            
            WindowHeight = 30;
            WindowWidth = 90;
            string miNombre = "";
            string dev = "";

            DateTime hoy = DateTime.Now;
            try{
                miNombre = args[0];

            }catch(Exception){
                miNombre = "";
            }

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            SetCursorPosition(0,0);
            Write("╔");//alt + 201
            for(int i=0;i<88;i++){
                Write("═");//alt + 205
            }
            WriteLine("╗");//alt + 187
            Write("║ ");//alt + 186
            ForegroundColor = ConsoleColor.DarkCyan;
            Write("Fecha: ");
            ForegroundColor = ConsoleColor.White;
            Write($"{hoy.ToString("dd/MM/yyyy")}");
            SetCursorPosition(75,1);
            ForegroundColor = ConsoleColor.DarkCyan;
            Write("Hora: ");
            ForegroundColor = ConsoleColor.White;
            Write($"{hoy.ToString("HH:mm:ss")}");
            SetCursorPosition(89,1);
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("║");//alt + 186
            Write($"║ ");//alt + 186
            ForegroundColor = ConsoleColor.DarkCyan;
            Write("Nombre: ");
            ForegroundColor = ConsoleColor.White;
            Write($"{miNombre}");
            SetCursorPosition(89,2);
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("║");//alt + 186
            Write("║ ");//alt + 186
            ForegroundColor = ConsoleColor.DarkCyan;
            Write("Developer: ");
            ForegroundColor = ConsoleColor.White;
            Write($"{dev}");
            SetCursorPosition(89,3);
            ForegroundColor = ConsoleColor.DarkYellow;
            WriteLine("║");//alt + 186
            Write("╠");//alt + 204
            for(int i=0;i<88;i++){
                Write("═");//alt + 205
            }
            WriteLine("╣");//alt + 185
            ForegroundColor = ConsoleColor.DarkGreen;
            for(int i=0;i<24;i++){
                Write("║");//alt + 186
                SetCursorPosition(89,5+i);
                WriteLine("║");//alt + 186
            }
            Write("╚");//alt + 200
            for(int i=0;i<88;i++){
                Write("═");//alt +205
            }
            Write("╝");//alt + 188
            ReadKey();
            Clear();
        }
    }
}
