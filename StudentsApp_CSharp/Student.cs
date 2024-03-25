using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp_CSharp
{
    //the Student class inherits the Person class
    class Student :Person
    {
        private byte year;
        //variable for the notes vector
        private byte[] notes = new byte[5];

        //constructor
        public Student(byte year, byte[] notes, string name, byte age)
            :base(name, age)
        {
            this.year = year;
            this.notes = notes;
        }

        
    }
}
