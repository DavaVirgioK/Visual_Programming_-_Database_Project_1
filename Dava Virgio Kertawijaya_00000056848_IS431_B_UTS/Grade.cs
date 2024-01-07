using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dava_Virgio_Kertawijaya_00000056848_IS431_B_UTS
{
    internal class Grade
    {
        public string hitungGrade(int nilai, int total)
        {
            double average = total / nilai;
            if (average >= 84 && average <= 100)
            {
                String grade = "A";
                return grade;
            }
            else if (average >= 74 && average < 84)
            {
                String grade = "B";
                return grade;
            }
            else if (average >= 64 && average < 74)
            {
                String grade = "C";
                return grade;
            }
            else if (average >= 0 && average < 64)
            {
                String grade = "D";
                return grade;
            }
            else
            {
                String grade = "-";
                return grade;
            }
        }
    }
}
