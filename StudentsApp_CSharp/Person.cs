using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsApp_CSharp
{
    class Person
    {
        //declared variables
        protected string cnp;
        protected string m_name;
        protected byte m_age;

        //constructor
        public Person(string cnp, string name, byte age)
        {
            this.cnp = cnp;
            this.m_name = name;
            this.m_age = age;
        }
    }
}
