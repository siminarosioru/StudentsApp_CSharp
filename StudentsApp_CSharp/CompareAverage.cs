using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp_CSharp
{
    //created the CompareAverage function with the two objects
    class CompareAverage :IComparer<Student> 
    {
        public int Compare(Student x, Student y)
        {
            if (x.Average() > y.Average())
                return 1;
            else if (x.Average() == y.Average())
                return 0;
            else
                return -1;
        }
    }
}
