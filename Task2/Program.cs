using System;
using System.Collections.Generic;
namespace CookiesTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int RandomNumber()  
            {  
                Random rnd = new Random();
                return rnd.Next(1000,9999);
            }

        Person a = new Person("Luke","McDonalds",19/09/1997,195, RandomNumber());
        Person b = new Person("Anakin","SkyWalker",13/01/1863,185, RandomNumber());
        Person c = new Person("Jevon","Jeeves",01/12/2012,143, RandomNumber());
        Subject first = new Subject("Science",9);

        a.GetFullName();
        Person.GetHeightDifference(a,b);
        a.AddSubject();
        a.PrintSubjects();

        }
    }
    class Person
    {
        private string FirstName;

        private string Surname;
        private int DOB;

        private int Height;

        private int ID;

          public List<string> subjectList { get; set; }
       

         public Person(string pFirstName, string pSurname, int pDOB, int pHeight, int pID) 
         {
            FirstName = pFirstName;
            Surname = pSurname;
            DOB = pDOB;
            Height = pHeight;
            ID = pID;
         }
            public void GetFullName(){
            Console.WriteLine("My name is " + FirstName + Surname);
        }
            public static void GetHeightDifference(Person p1, Person p2){
                Console.WriteLine($"Difference between {p1.FirstName} and {p2.FirstName} is {Math.Abs(p1.Height - p2.Height)}");
            }
            public static void AddSubject(){
                    Console.WriteLine("Enter a subject");
                    string Subject = Console.ReadLine();
                subjectList.Add(Subject);
            }
                public static void PrintSubjects(){
                Console.WriteLine(subjectList);
            }
    }
    class Subject
    {
        private string Name;

        private int YearOfDelivery;

         public Subject(string sName, int sYear) 
         {
             Name = sName;
             YearOfDelivery = sYear;
         }
    }
}
