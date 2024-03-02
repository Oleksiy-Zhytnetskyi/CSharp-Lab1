using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.CSharp2024.Lab1.Models
{
    internal class User
    {
        private DateTime _birthDate;

        public DateTime BirthDate
        {
            get { return _birthDate; }
            set { _birthDate = value; }
        }

        public User(int day = 1, int month = 1, int year = 2000)
        {
            _birthDate = new DateTime(year, month, day);
        }

        public User(DateTime birthDate)
        {
            _birthDate = birthDate;
        }
    }
}
