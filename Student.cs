using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Student
    {
        private string fname;

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        private string lname;
        
        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }
        private List<string> classesTaken;
        
        public List<string> ClassesTaken
        {
            get
            {
                return classesTaken;
            }
            set
            {
                classesTaken = value;
            }
        }

        private List<char> grades;
        
        public List<char> Grades
        {
            get
            {
                return grades;
            }
            set
            {
                grades = value;
            }
        }
    }
}
