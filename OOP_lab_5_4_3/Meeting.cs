using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_5_4_3
{
    public class Meeting : Conference
    {
        private DateTime _date;
        private string _theme;
        private int _participantsCount;

        public DateTime Date
        {
            get => _date;
            set => _date = value;
        }

        public string Theme
        {
            get => _theme;
            set => _theme = value;
        }

        public int ParticipantsCount
        {
            get => _participantsCount;
            set => _participantsCount = value;
        }

        public Meeting()
        {
            base.Name = "Не вказано";
            base.Place = "Не вказано";

            _date = DateTime.Parse("01.01.01");
            _theme = "Не вказано";
            _participantsCount = 0;
        }

        public Meeting(string name, string place, DateTime date, string theme, int participantsCount)
        {
            base.Name = UkrainianI(name);
            base.Place = UkrainianI(place);

            _date = date;
            _theme = UkrainianI(theme);
            _participantsCount = participantsCount;
        }
    }
}
