using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab_5_4_3
{
    public class Conference
    {
        private string _name;
        private string _place;

        public string Name
        {
            get => _name;
            set => _name = value;
        }

        public string Place
        {
            get => _place;
            set => _place = value;
        }

        public Conference()
        {
            _name = "Не вказано";
            _place = "Не вказано";
        }

        public virtual string UkrainianI(string str)
        {
            char[] ch = str.ToCharArray();

            for (int i = 0; i < ch.Length; ++i)
            {
                if (ch[i] == 'і')
                {
                    ch[i] = 'i';
                }

                if (ch[i] == 'І')
                {
                    ch[i] = 'I';
                }
            }

            return new string(ch);
        }

        public virtual int Length()
        {
            return _name.Length;
        }

        public Conference(string name, string place)
        {
            _name = UkrainianI(name);
            _place = UkrainianI(place);
        }
    }
}
