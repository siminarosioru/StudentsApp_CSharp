using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp_CSharp
{
    class CompareName:IComparer<Student>
    {
        //created the Compare function with the two objects
        public int Compare(Student x, Student y)
        {
            return string.Compare(x.studentName, y.studentName);
        }
    }
}
