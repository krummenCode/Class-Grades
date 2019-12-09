using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassGrades
{
    public class Grade
    {
        public string LetterGrade { get; set; }

        public Grade() { }


        // Set LetterGrade to percent range
        public string ConvertToLetterGrade(double igradePercentage)
        {
            if (igradePercentage >= 90)
            {
                LetterGrade = "A";
            }

            if (igradePercentage >= 80 && igradePercentage < 90)
            {
                LetterGrade = "B";
            }

            if (igradePercentage >= 70 && igradePercentage < 80)
            {
                LetterGrade = "C";
            }

            if (igradePercentage >= 60 && igradePercentage < 70)
            {
                LetterGrade = "D";
            }
            if (igradePercentage < 60)
            {
                LetterGrade = "F";
            }
            return LetterGrade;
        }
    }
}
