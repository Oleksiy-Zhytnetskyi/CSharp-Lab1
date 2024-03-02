using KMA.CSharp2024.Lab1.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMA.CSharp2024.Lab1.Helpers
{
    internal static class ChineseZodiacHelper
    {
        public static ChineseZodiacSign GetChineseZodiacSign(DateTime birthDate)
        {
            int offset = birthDate.Year % 12;
            return (ChineseZodiacSign)offset;
        }
    }
}
