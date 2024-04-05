using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp_CSharp
{
    class CompareAverage :IComparer<Student> 
    {
        //created the CompareAverage function with the two objects
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
