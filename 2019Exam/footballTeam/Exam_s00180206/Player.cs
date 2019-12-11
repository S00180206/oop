using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_s00180206
{
    public class Player
    {
        //variables 
        public enum Position {Goalkeeper, Defender, Midfielder, Forwards};

        public string FirstName { get; set; }

        public string SurName { get; set; }

        public Position PreferredPosition { get; set; }

        public DateTime DOB { get; set; }

        private int _age;

        public int Age
        {
            get
            {
                _age = DateTime.Now.Year - DOB.Year;
                if (DOB.DayOfYear > DateTime.Now.DayOfYear)
                    _age--;
                return _age;
            }
        }

        public Player(string firstName, string surName,Position preferredPossition, DateTime dob, int age)
        {
            FirstName = firstName;
            SurName = surName;
            PreferredPosition = preferredPossition;
            DOB = dob;
            _age = age;

        }
        public override string ToString()
        {
            return $"{FirstName}{SurName} {Age}{PreferredPosition}";
        }


    }
}
