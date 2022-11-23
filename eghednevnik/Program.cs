// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information
using System.Xml.Schema;

namespace Daily
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int position = 1;
            List<string> aB = new List<string>() { " 10.04.1980", "  день рождения отца", "  Футбол", "  Прогулка", "  Учёба" };
            List<string> aC = new List<string>() { " 12.04.2022", "  Сходить погулять", "  Сходить в парикмахерскую" };
            List<string> aD = new List<string>() { " 11.05.2009", "  Сходить в парк" };
            List<string> aMain = aB;


            Menu(aMain);

            Console.SetCursorPosition(0, 1);
            Console.WriteLine("=>");

            while (true)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    if (aMain == aB) { aMain = aD; }
                    else if (aMain == aD) { aMain = aC; }
                    else if (aMain == aC) { aMain = aB; }
                    position = 1;
                }
                else if (key.Key == ConsoleKey.RightArrow)
                {
                    if (aMain == aB)
                    { aMain = aC; }
                    else if (aMain == aC) { aMain = aD; }
                    else if (aMain == aD) { aMain = aB; }
                    position = 1;
                }
                if (key.Key == ConsoleKey.Enter)
                {
                    Zamet(aMain, position);
                }
                Console.Clear();
                Menu(aMain);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("=>");
            }




            static void Menu(List<string> aaL)
            {
                Console.WriteLine("Выбрана дата" + aaL[0]);

                for (int i = 1; i < aaL.Count; i++)
                {
                    Console.WriteLine(aaL[i]);
                }

            }

            static void Zamet(List<string> aaL, int pos)
            {
                Console.Clear();
                Console.WriteLine("Подробная информация:");
                Console.WriteLine("---------------------");
                Console.WriteLine(aaL[0]);
                Console.WriteLine(aaL[pos]);
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();


            }





        }
    }
}
