using GradeBook.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook : BaseGradeBook
    {
        public RankedGradeBook(string name)
            :base(name)
        {
            Type = GradeBookType.Ranked;
        }

        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException("You need at least 5 students to complete ranked grading");
            }

            var threshold = (int)Math.Ceiling(Students.Count * 0.2);
            //LINQ - I do not understand the threshold or the linq below
            var grade = Students.OrderByDescending(e => e.AverageGrade).Select(e => e.AverageGrade).ToList();

            if(grade[threshold - 1] <= averageGrade)
            {
                return 'A';
            }
            else if(grade[(threshold * 2) - 1] <= averageGrade)
            {
                return 'B';
            }
            else if (grade[(threshold * 2) - 1] <= averageGrade)
            {
                return 'C';
            }
            else if (grade[(threshold * 2) - 1] <= averageGrade)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
        }
    }
}
