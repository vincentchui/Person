using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Employee
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

        private string department;

        public string Department
        {
            get
            {
                return department;
            }
            set
            {
                department = value;
            }
        }

        private double salary;

        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                salary = value;
            }
        }

        private double hours;

        public double Hours
        {
            get
            {
                return hours;
            }
            set
            {
                hours = value;
            }
        }

        private double rate;

        public double Rate
        {
            get
            {
                return rate;
            }
            set
            {
                rate = value;
            }
        }

        private int uID;

        public int UID
        {
            get
            {
                return uID;
            }
            set
            {
                uID = value;
            }
        }
    }
}

