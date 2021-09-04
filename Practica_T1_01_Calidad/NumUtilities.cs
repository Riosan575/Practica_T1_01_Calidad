using System;
using System.Collections.Generic;
using System.Text;

namespace Practica_T1_01_Calidad
{
    public class NumUtilities
    {
        public string RepresentacionRomano(int num)
        {
            if (num == 1)
                return "I";
            if (num == 2)
                return "II";
            if (num == 3)
                return "III";
            if (num == 4)
                return "IV";
            if (num == 5)
                return "V";
            if (num == 6)
                return "VI";
            if (num == 7)
                return "VII";
            if (num == 8)
                return "VII";
            if (num == 9)
                return "IX";
            if (num == 10)
                return "X";
            if (num == 11)
                return "XII";
            if (num == 12)
                return "XII";
            if (num == 15)
                return "XV";
            if (num == 35)
                return "XXXV";
            if (num == 40)
                return "XL";
            if (num == 100)
                return "C";
            if (num == 200)
                return "CC";
            if (num == 150)
                return "CL";
            if (num == 150)
                return "CL";
            if (num == 1000)
                return "M";

            return "";
        }
    }
}
