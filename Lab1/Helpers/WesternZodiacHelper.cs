using KMA.CSharp2024.Lab1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.CSharp2024.Lab1.Helpers
{
    internal static class WesternZodiacHelper
    {
        public static WesternZodiacSign GetWesternZodiacSign(DateTime birthDate)
        {
            Month month = (Month)birthDate.Month;
            int day = birthDate.Day;

            switch (month)
            {
                case Month.January:
                    return day <= 19 ? WesternZodiacSign.Capricorn : WesternZodiacSign.Aquarius;
                case Month.February:
                    return day <= 18 ? WesternZodiacSign.Aquarius : WesternZodiacSign.Pisces;
                case Month.March:
                    return day <= 20 ? WesternZodiacSign.Pisces : WesternZodiacSign.Aries;
                case Month.April:
                    return day <= 19 ? WesternZodiacSign.Aries : WesternZodiacSign.Taurus;
                case Month.May:
                    return day <= 20 ? WesternZodiacSign.Taurus : WesternZodiacSign.Gemini;
                case Month.June:
                    return day <= 20 ? WesternZodiacSign.Gemini : WesternZodiacSign.Cancer;
                case Month.July:
                    return day <= 22 ? WesternZodiacSign.Cancer : WesternZodiacSign.Leo;
                case Month.August:
                    return day <= 22 ? WesternZodiacSign.Leo : WesternZodiacSign.Virgo;
                case Month.September:
                    return day <= 22 ? WesternZodiacSign.Virgo : WesternZodiacSign.Libra;
                case Month.October:
                    return day <= 23 ? WesternZodiacSign.Libra : WesternZodiacSign.Scorpio;
                case Month.November:
                    return day <= 21 ? WesternZodiacSign.Scorpio : WesternZodiacSign.Sagittarius;
                case Month.December:
                    return day <= 21 ? WesternZodiacSign.Sagittarius : WesternZodiacSign.Capricorn;
                default:
                    throw new ArgumentException("Error calculating Western zodiac sign: Invalid month");
            }
        }
    }
}
