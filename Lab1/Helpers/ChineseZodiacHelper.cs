using KMA.CSharp2024.Lab1.Models.Enums;

namespace KMA.CSharp2024.Lab1.Helpers
{
    internal static class ChineseZodiacHelper
    {
        public static ChineseZodiacSign GetChineseZodiacSign(DateTime birthDate)
        {
            if (birthDate.Year < 4) throw new ArgumentException("Error: Birth date year < 4 AD");
            const int startYear = 4;
            int offset = (birthDate.Year - startYear) % 12;
            return (ChineseZodiacSign)offset;
        }
    }
}
