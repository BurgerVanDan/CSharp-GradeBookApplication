using System;
using System.Collections.Generic;
using System.Text;

namespace GradeBook
{
    class StudentComparerByGrade : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.AverageGrade < y.AverageGrade)
            {
                return 1;
            }
            if (x.AverageGrade > y.AverageGrade)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
