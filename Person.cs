using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {

        public void menu()
        {
            string choice, choice2, personType;
            int indexE = 0;
            int indexS = 0;

            Employee[] e = new Employee[10];

            Student[] s = new Student[10];

            for(int i = 0; i < e.Length; i++)
            {
                e[i] = new Employee();
            }

            e = initEmployee(e);

            indexE = 4;

            for (int i = 0; i < s.Length; i++)
            {
                s[i] = new Student();
            }

            s = initStudent(s);

            indexS = 4;

            Console.WriteLine("\nWritten by Vincent Chui" +
                "\nCIS 23" +
                "\nLab 2" +
                "\nFall 2015");
            do
            {
                Console.Write("\nAdd" +
                    "\nSearch" +
                    "\nPrint" +
                    "\nEnter choice: ");
                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "add":
                        do
                        {
                            Console.Write("\nEmployee or Student? ");
                            personType = Console.ReadLine().ToLower();

                            if((personType != "employee") || (personType != "student"))
                            {
                                Console.WriteLine("\nPlease input employee or student");
                            }

                        } while ((personType != "employee") || (personType != "student"));

                        if (personType == "employee")
                        {
                            addE(e[indexE]);
                        }
                        else
                        {
                            addS(s[indexS]);
                        }
                        break;
                    case "search":
                        do {
                            Console.Write("\nemployee or student: ");
                            choice2 = Console.ReadLine().ToLower();

                            if (choice2 == "employee")
                            {
                                searchE(e);
                            }
                            else if (choice2 == "student")
                            {
                                searchS(s);
                            }
                            else
                            {
                                Console.WriteLine("\nINVALID INPUT");
                            }
                        } while((choice2 != "employee") || (choice2 != "student"));
                        break;
                    case "print":

                        break;
                    case "quit":
                        break;
                    default:
                        Console.WriteLine("\nINVALID INPUT");
                        break;
                }
            } while (choice != "quit");
        }

        public void searchS(Student[] s)
        {
            string searchF, searchL;

            Console.Write("\nWhat is the first name? ");
            searchF = Console.ReadLine();

            Console.Write("\nWhat is the last name? ");
            searchL = Console.ReadLine();

            for(int i = 0; i < s.Length; i++)
            {
                if((searchF == s[i].Fname) && (searchL == s[i].Lname))
                {
                    printStudent(s[i]);
                }
            }
        }

        public void searchE(Employee[] e)
        {
            string searchF, searchL;

            Console.Write("\nWhat is the first name? ");
            searchF = Console.ReadLine();

            Console.Write("\nWhat is the last name? ");
            searchL = Console.ReadLine();

            for (int i = 0; i < e.Length; i++)
            {
                if ((searchF == e[i].Fname) && (searchL == e[i].Lname))
                {
                    printEmployee(e[i]);
                }
            }
        }

        public double averageRate(Employee e)
        {
            double averageRate = 0;

            return averageRate;
        }
        public Employee[] initEmployee(Employee[] e)
        {
            int lastId = 0001;

            e[0].Fname = "Vincent";
            e[0].Lname = "Xu";
            e[0].Department = "Technology";
            e[0].Salary = 80000.00;
            e[0].UID = lastId;

            lastId++;

            e[1].Fname = "Joe";
            e[1].Lname = "Smith";
            e[1].Department = "Management";
            e[1].Salary = 100000.00;
            e[1].UID = lastId;

            lastId++;

            e[2].Fname = "John";
            e[2].Lname = "Doe";
            e[2].Department = "Finance";
            e[2].Salary = 80000.00;
            e[2].UID = lastId;

            lastId++;

            e[3].Fname = "William";
            e[3].Lname = "Gopher";
            e[3].Department = "Maintence";
            e[3].Rate = 25;
            e[3].Hours = 8;
            e[3].UID = lastId;

            lastId++;

            e[4].Fname = "Micheal";
            e[4].Lname = "Johnson";
            e[4].Department = "Sales";
            e[4].Salary = 70000;
            e[4].UID = lastId;

            return e;          
        }

        public Student[] initStudent(Student[] s)
        {

            return s;
        }

        public Employee addE(Employee e)
        {
            string choice;

            Console.Write("\nSalary or Hourly employee? ");
            choice = Console.ReadLine().ToLower();

            if (choice == "salary")
            {
                Console.Write("What is the first name? ");
                e.Fname = Console.ReadLine();

                Console.Write("What is the last name? ");
                e.Lname = Console.ReadLine();

                Console.Write("What is the salary amount? ");
                e.Salary = Console.Read();
            }
            else if(choice == "hourly")
            {
                Console.Write("\nWhat is the first name? ");
                e.Fname = Console.ReadLine();

                Console.Write("\nWhat is the last name? ");
                e.Lname = Console.ReadLine();

                Console.Write("\nWhat is the rate? ");
                e.Rate = Convert.ToDouble(Console.ReadLine());


            }
            return e;  
        }

        public Student addS(Student s)
        {
            int count = 0;
            string className;

            Console.Write("\nWhat is the first name? ");
            s.Fname = Console.ReadLine();

            Console.Write("\nWhat is the last name? ");
            s.Lname = Console.ReadLine();

            Console.Write("\nHow many class were taken? ");
            count = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i < count; i++)
            {
                Console.Write("\nWhat is the name of the class? ");
                className = Console.ReadLine();
                s.ClassesTaken.Add(className);

                Console.Write("\nWhat was the grade for " + className);
                s.Grades.Add(Convert.ToChar(Console.ReadLine()));
            }
            return s;
        }

        public void printEmployee(Employee e)
        {
            if ((e.Hours == 0) || (e.Rate == 0))
            {
                Console.WriteLine("\nNAME: " + e.Fname + " " + e.Lname +
                    "\nDEPARTMENT: " + e.Department +
                    "\nSALARY: " + e.Salary +
                    "\nID: " + e.UID);
            }
            else
            {
                Console.WriteLine("\nNAME: " + e.Fname + " " + e.Lname +
                    "\nDEPARTMENT: " + e.Department +
                    "\nHOURS: " + e.Hours +
                    "\nRATE: " + e.Rate +
                    "\nID: " + e.UID);
            }
        }

        public void printStudent(Student s)
        {
            Console.WriteLine("\nNAME: " + s.Fname + " " + s.Lname);

            Console.WriteLine("\nCLASSES: ");

            foreach(object i in s.ClassesTaken)
            {
                Console.Write(s.ClassesTaken);
            }

            Console.WriteLine("\nGRADES: ");

            foreach(object i in s.Grades)
            {
                Console.Write(s.Grades);
            }
        }
    }
}
