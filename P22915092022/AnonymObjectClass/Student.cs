using System;
using System.Collections.Generic;
using System.Text;

namespace AnonymObjectClass
{
    //Custom Type
    //OOP - Inheritance
    class Student : Human
    {
        //Memmber
        //Field

        public Address Address;

        //Constructor
        //Methoddur
        //Return Type Olmur
        //Method Signature ve Method Overloadin Sertlerni Oduyur
        //Hec Bir Yerden Cagirmaq Olmur Yalniz Class Obyekt (Instance) Yaradilan Zaman Ise Dusur
        public Student()
        {

        }
        public Student(string name) : this()
        {
            Name = name;
        }

        public Student(string name, string surname) : this(name)
        {
            SurName = surname;
        }

        public Student(string name, string surname, byte age) : this(name, surname)
        {
            Age = age;
        }

        //Method
        public void ShowInfo()
        {
            Console.WriteLine($"{Name} {SurName} {Age}");
        }

        public string FullName()
        {
            return $"{Name} {SurName}";
        }

        
    }
}
