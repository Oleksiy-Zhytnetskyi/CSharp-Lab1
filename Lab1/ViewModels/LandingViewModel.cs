using KMA.CSharp2024.Lab1.Helpers;
using KMA.CSharp2024.Lab1.Models;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace KMA.CSharp2024.Lab1.ViewModels
{
    internal class LandingViewModel : INotifyPropertyChanged
    {
        private const int AGE_THRESHOLD = 135;
        private readonly User _user = new User();

        public DateTime BirthDate
        {
            get { return _user.BirthDate; }
            set 
            {
                if (!BirthDateIsValid(value))
                {
                    MessageBox.Show("Invalid birth date entered. Please try again.", 
                        "Error: Invalid Birth Date", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }
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
                string result = $"Your age is {GetAge()}.";
                if (TodayIsBirthday())
                {
                    result += " Happy Birthday!";
                }
                return result;
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

        private bool BirthDateIsValid(DateTime birthDate)
        {
            return !(birthDate > DateTime.Today || GetAge(birthDate) > AGE_THRESHOLD);
        }

        private bool TodayIsBirthday()
        {
            return BirthDate.Day == DateTime.Today.Day && BirthDate.Month == DateTime.Today.Month;
        }

        private int GetAge()
        {
            return GetAge(BirthDate);
        }

        private static int GetAge(DateTime startDate)
        {
            int age = DateTime.Today.Year - startDate.Year;
            if (startDate.Date > DateTime.Today.AddYears(-age))
                --age;
            return age;
        }

        private string GetWesternZodiacSign()
        {
            return WesternZodiacHelper.GetWesternZodiacSign(BirthDate).ToString();
        }

        private string GetChineseZodiacSign()
        {
            try
            {
                return ChineseZodiacHelper.GetChineseZodiacSign(BirthDate).ToString();
            }
            catch (ArgumentException)
            {
                return "N/A";
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
