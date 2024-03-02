using KMA.CSharp2024.Lab1.Helpers;
using KMA.CSharp2024.Lab1.Models;
using KMA.CSharp2024.Lab1.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace KMA.CSharp2024.Lab1.ViewModels
{
    internal class LandingViewModel : INotifyPropertyChanged
    {
        private readonly User _user = new User();

        public DateTime BirthDate
        {
            get { return _user.BirthDate; }
            set 
            { 
                // TODO: Add validation!
                _user.BirthDate = value;
                OnPropertyChanged(nameof(Age));
                OnPropertyChanged(nameof(WesternZodiacSign));
                OnPropertyChanged(nameof(ChineseZodiacSign));
            }
        }

        public string Age
        {
            get 
            { 
                return $"Your age is {GetAge()}."; 
            }
        }

        public string WesternZodiacSign
        {
            get 
            { 
                return $"Your Western zodiac sign is {GetWesternZodiacSign()}."; 
            }
        }

        public string ChineseZodiacSign
        {
            get 
            { 
                return $"Your Chinese zodiac sign is {GetChineseZodiacSign()}."; 
            }
        }

        private int GetAge()
        {
            return DateTime.Today.Year - _user.BirthDate.Year;
        }

        private string GetWesternZodiacSign()
        {
            return WesternZodiacHelper.GetWesternZodiacSign(_user.BirthDate).ToString();
        }

        private string GetChineseZodiacSign()
        {
            return ChineseZodiacHelper.GetChineseZodiacSign(_user.BirthDate).ToString();
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
