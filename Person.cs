using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        private string fname;
        private string lname;
        private double salary;
        private double rate;
        private int hours;
        private string department;

        public void menu()
        {
            Person[] personArray = new Person[10];
            string choice;

            for(int i = 0; i < 10; i++)
            {
                personArray[i] = new Person();
            }

            personArray = initArray(personArray);

            do
            {
                Console.Write("\nWritten by Vincent Chui" +
                    "\nCIS 23 BCC Fall 2015" +
                    "\n\nAdd Person" +
                    "\nDelete Person" +
                    "\nPrint Person" +
                    "\nPrint Contents" +
                    "\nQuit");
                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "add person":
                        addPerson();
                        break;
                    case "print person":
                        printPerson(personArray);
                        break;
                    case "print contents":
                        printArray(personArray);
                        break;
                    case "quit":
                        break;
                    default:
                        Console.WriteLine("\nINVALID INPUT");
                        break;
                }
            } while (choice != "quit");
        }

        public void printArray(Person[] personArray)
        {
            Console.WriteLine("\nPRINTING ENTIRE CONTENT");

            for(int i = 0; i < personArray.Length; i++)
            {
                ToString(personArray[i]);
            }
        }

        public Person[] initArray(Person[] personArray)
        {
            personArray[0].fname = "John";
            personArray[0].lname = "Smith";
            personArray[0].hours = 8;
            personArray[0].rate = 15;
            personArray[0].salary = ((hours * 15) * rate) * 12;
            personArray[0].department = "Sales";
            

            return personArray;
        }
        public void printPerson(Person[] personArray)
        {
            string fname, lname;
            Person[] printArray = new Person[10];

            Console.Write("\nWhat is the first name? ");
            fname = Console.ReadLine();

            Console.Write("\nWhat is the last name? ");
            lname = Console.ReadLine();

            for(int i = 0; i < personArray.Length; i++)
            {
                if((fname == personArray[i].fname) && 
                    (lname == personArray[i].lname))
                {
                    ToString(personArray[i]);
                }
            }
        }

        public void ToString(Person person)
        {
            Console.WriteLine("\nNAME: " + fname + lname +
                "\nSALARY: " + salary +
                "\nRATE: " + rate +
                "\nHOURS: " + hours +
                "\nDEPARTMENT: " + department);
        }
        
        public void addPerson()
        {
            Console.Write("\nWhat is the first name? ");
            fname = Console.ReadLine();

            Console.Write("\nWhat is the last name? ");
            lname = Console.ReadLine();

            Console.Write("\nWhat is the salary amount? ");
            salary = Convert.ToDouble(Console.Read());

            Console.Write("\nWhat is the hourly rate? ");
            rate = Convert.ToDouble(Console.Read());

            Console.Write("\nWhat is the amount of hours? ");
            hours = Console.Read();

            Console.Write("\nWhat is the department? ");
            department = Console.ReadLine();
        }
    }
}
