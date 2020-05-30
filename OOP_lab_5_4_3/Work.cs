using System;
using System.IO;

namespace OOP_lab_5_4_3
{
    class Work
    {
        public static void Add()
        {
            StreamWriter file = new StreamWriter("base.txt", true);

            Console.WriteLine("\nВведiть новi данi");

            Console.Write("Назва: ");

            file.WriteLine(Console.ReadLine());

            Console.Write("Мiсце проведення: ");

            file.WriteLine(Console.ReadLine());

        Retry:
            Console.Write("Дата: ");

            try
            {
                file.WriteLine(DateTime.Parse(Console.ReadLine()));
            }
            catch (SystemException)
            {
                Console.WriteLine("Неправильно вказана дата!");

                goto Retry;
            }

            Console.Write("Тема: ");

            file.WriteLine(Console.ReadLine());

            Console.Write("Кiлькiсть учасникiв: ");

            file.WriteLine(Console.ReadLine());

            file.Close();

            Input.ReadBase();
        }

        public static void Remove()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для видалення: ");

            bool[] remove = new bool[Program.meetings.Length];

            for (int i = 0; i < remove.Length; ++i)
            {
                remove[i] = false;
            }

            try
            {
                remove[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                if (!remove[i])
                {
                    file.WriteLine(Program.meetings[i].Name);
                    file.WriteLine(Program.meetings[i].Place);
                    file.WriteLine(Program.meetings[i].Date.ToShortDateString());
                    file.WriteLine(Program.meetings[i].Theme);
                    file.WriteLine(Program.meetings[i].ParticipantsCount);
                }
            }

            Console.Write("Видалено.\n");

            file.Close();

            Input.ReadBase();
        }

        public static void Edit()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для редагування: ");

            bool[] edit = new bool[Program.meetings.Length];

            for (int i = 0; i < edit.Length; ++i)
            {
                edit[i] = false;
            }

            try
            {
                edit[int.Parse(Console.ReadLine()) - 1] = true;
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }

            StreamWriter file = new StreamWriter("base.txt");

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                if (edit[i])
                {
                    Console.WriteLine("\nВведiть новi данi");

                    Console.Write("Назва: ");

                    file.WriteLine(Console.ReadLine());

                    Console.Write("Мiсце проведення: ");

                    file.WriteLine(Console.ReadLine());

                Retry:
                    Console.Write("Дата: ");

                    try
                    {
                        file.WriteLine(DateTime.Parse(Console.ReadLine()));
                    }
                    catch (SystemException)
                    {
                        Console.WriteLine("Неправильно вказана дата!");

                        goto Retry;
                    }

                    Console.Write("Тема: ");

                    file.WriteLine(Console.ReadLine());

                    Console.Write("Кiлькiсть учасникiв: ");

                    file.WriteLine(Console.ReadLine());
                }
                else
                {
                    file.WriteLine(Program.meetings[i].Name);
                    file.WriteLine(Program.meetings[i].Place);
                    file.WriteLine(Program.meetings[i].Date.ToShortDateString());
                    file.WriteLine(Program.meetings[i].Theme);
                    file.WriteLine(Program.meetings[i].ParticipantsCount);
                }
            }

            Console.Write("Змiни внесено.\n");

            file.Close();

            Input.ReadBase();
        }

        public static void InitialiseBase(int n)
        {
            Program.meetings = new Meeting[n];
        }

        public static void Average()
        {
            Console.Write("\nСередня кiлькiсть учасникiв на засiданнi: ");

            double sum = 0;

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                sum += Program.meetings[i].ParticipantsCount;
            }

            Console.WriteLine(sum / Program.meetings.Length);
        }

        public static void Max()
        {
            Console.WriteLine("\nЗасiдання з найбiльшою кiлькiстю учасникiв:");

            Console.WriteLine(Output.Format, "Назва", "Мiсце проведення", "Дата", "Тема", "Кiлькiсть учасникiв");

            int max = 0;

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                if (Program.meetings[i].ParticipantsCount >= max)
                {
                    max = Program.meetings[i].ParticipantsCount;
                }
            }

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                if (Program.meetings[i].ParticipantsCount == max)
                {
                    Console.WriteLine(Output.Format, Program.meetings[i].Name, Program.meetings[i].Place, Program.meetings[i].Date.ToShortDateString(), Program.meetings[i].Theme, Program.meetings[i].ParticipantsCount);
                }
            }
        }

        public static void Length()
        {
            Console.WriteLine();

            Output.Write();

            Console.Write("Порядковий номер запису для визначення довжини назви засiдання: ");

            try
            {
                Console.WriteLine("Довжина назви засiдання: {0}", Program.meetings[int.Parse(Console.ReadLine())].Length());
            }
            catch (SystemException)
            {
                Console.WriteLine("Такого запису не iснує!");
                return;
            }
        }
    }
}
