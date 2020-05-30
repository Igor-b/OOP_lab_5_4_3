using System;
using System.IO;

namespace OOP_lab_5_4_3
{
    class Input
    {
        public static void Read()
        {
            ReadBase();
            ReadKey();
        }

        public static void ReadBase()
        {
            StreamReader file = new StreamReader("base.txt");

            string[] tempStr = file.ReadToEnd().Split("\r\n", StringSplitOptions.RemoveEmptyEntries);

            Work.InitialiseBase(tempStr.Length / 5);

            for (int i = 0; i < tempStr.Length; i += 5)
            {
                Program.meetings[i / 5] = new Meeting(tempStr[i], tempStr[i + 1], DateTime.Parse(tempStr[i + 2]), tempStr[i + 3], int.Parse(tempStr[i + 4]));
            }

            file.Close();
        }

        private static void ReadKey()
        {
            
        Start:

            Console.WriteLine("Додавання записiв: +");
            Console.WriteLine("Редагування записiв: E");
            Console.WriteLine("Знищення записiв: -");
            Console.WriteLine("Виведення записiв: Enter");
            Console.WriteLine("Середня кiлькiсть учаникiв на засiданнi: A");
            Console.WriteLine("Засiдання з найбiльшою кiлькiстю учасникiв: M");
            Console.WriteLine("Довжина назви: L");
            Console.WriteLine("Вихiд: Esc");

            ConsoleKey key = Console.ReadKey().Key;

            switch (key)
            {
                case ConsoleKey.OemPlus:
                    Work.Add();
                    goto Start;

                case ConsoleKey.E:
                    Work.Edit();
                    goto Start;

                case ConsoleKey.A:
                    Work.Average();
                    goto Start;

                case ConsoleKey.L:
                    Work.Length();
                    goto Start;

                case ConsoleKey.M:
                    Work.Max();
                    goto Start;

                case ConsoleKey.OemMinus:
                    Work.Remove();
                    goto Start;

                case ConsoleKey.Enter:
                    Output.Write();
                    goto Start;

                case ConsoleKey.Escape:
                    return;

                default:
                    Console.WriteLine();
                    goto Start;
            }
        }
    }
}
