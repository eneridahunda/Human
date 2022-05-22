
using System;

namespace Human
{
    class Person
    {

        static void Main(string[] args)
        {
            int age;
            string fName;
            string lName;
            double height;
            double weight;

            Person person = new Person();

            Console.WriteLine(person.age);
            Console.WriteLine(person.fName);
            Console.WriteLine(person.lName);
            Console.WriteLine(person.height);
            Console.WriteLine(person.weight);

            Person.age = 20;
            Person.fName = "Anna";
            Person.lName = "Smith";
            Person.height = 178;
            Person.weight = 60;
        }


        public int minLength = 2;
        public int maxLength = 10;
        public int minLengthL = 3;
        public int maxLengthL = 15;
    }

 }