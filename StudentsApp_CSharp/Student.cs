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
        public Student(byte year, byte[] notes, string cnp, string name, byte age)
            :base(cnp, name, age)
        {
            this.year = year;
            this.notes = notes;
        }

        //the function returns the year of study
        public byte studyYear
        {
            get { return year; }
        }

        //the function returns the cnp of the student
        public string CnpStudent
        {
            get { return cnp; }
        }

        //the function returns the name of the student
        public string studentName
        {
            get { return m_name; } 
        }

        //the function returns the age of the student
        public byte AgeStudent
        {
            get { return m_age; }
        }

        //the function calculates the average of the notes
        public float Average()
        {
            float average = 0;
            foreach(byte element in notes)
            {
                average = average + element;
            }
            return average / 5;
        }

        //the get_Average_Notes function returns the average of the student's 5 notes
        public float get_Average_Notes
        {
            get { return Average(); }
        }

        //the function displays the information about the student
        public string studentDisplay()
        {
            return m_name + ", " + m_age + " years, year " + year + ", the average " + Average();
        }

         
    }
}
