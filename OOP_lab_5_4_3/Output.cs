using System;

namespace OOP_lab_5_4_3
{
    class Output
    {
        public const string Format = "{0, -20} {1, -15} {2, -15} {3, -30} {4, -20}";

        public static void Write()
        {
            Console.WriteLine(Format, "Назва", "Мiсце проведення", "Дата", "Тема", "Кiлькiсть учасникiв");

            for (int i = 0; i < Program.meetings.Length; ++i)
            {
                Console.WriteLine(Format, Program.meetings[i].Name, Program.meetings[i].Place, Program.meetings[i].Date.ToShortDateString(), Program.meetings[i].Theme, Program.meetings[i].ParticipantsCount);
            }
        }
    }
}
