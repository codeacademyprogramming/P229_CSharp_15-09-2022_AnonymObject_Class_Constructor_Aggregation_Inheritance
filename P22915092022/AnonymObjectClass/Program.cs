using System;

namespace AnonymObjectClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Hamid";
            //string surname = "";

            //Anonym Object
            //var stu1 = new
            //{
            //    name = "Hamd",
            //    surname = "Mammadov",
            //    age = 32
            //};

            //Console.WriteLine($"{stu1.name} {stu1.surname}");

            //Student stu1 = new Student("Hamid","Mammadov");
            //stu1.Name = "Hamid";
            //stu1.SurName = "Mammadov";
            //stu1.Age = 32;

            //Console.WriteLine($"{stu1.Name} {stu1.SurName} {stu1.Age}");
            //stu1.ShowInfo();
            //stu1.Age = 33;
            //Console.WriteLine(stu1.FullName());
            //Console.WriteLine($"{stu1.Name} {stu1.SurName} {stu1.Age}");

            //Student stu2 = new Student("Vusal","Zeynalov");

            //stu2.Name = "Vusal";
            //stu2.SurName = "Zeynalov";
            //stu2.Age = 19;

            //stu2.ShowInfo();
            //Console.WriteLine(stu2.FullName());



            //Student student1 = new Student("Hamid");
            //Student student2 = new Student("Hamid", "Mammadov");
            //Student student3 = new Student("Hamid","Mammadov",32);



            //Aggregation
            //int[] arr = new int[0];
            //Address address = new Address();
            //address.Country = "Azerbaijan";
            //address.City = "Baku";
            //address.PostalCode = "AZ1111";
            //string name = "Hamid";

            //Student student1 = new Student();
            //student1.Address = address;
            //student1.Name = name;
            //student1.Address = new Address();
            //student1.Address.Country = "Azerbaijan";
            //student1.Address.City = "Baku";
            //student1.Address.PostalCode = "AZ1111";

            //student1.Address.Country = "Turkiye";

            //Console.WriteLine(student1.Address.Country);

            //Company company = new Company();
            //company.Address = address;

            //company.Address = new Address();
            //company.Address.Country = "America";

            //Console.WriteLine(company.Address.Country);

            //OOP - Inheritance
            Human human = new Human();
            human.Name = "Test";

            Student student = new Student();
            student.Name = "Student";

            Console.WriteLine(human.Name);
            Console.WriteLine(student.Name);

            Developer developer = new Developer();
        }
    }

    //class Student
    //{
    //    public string Name;
    //    public string SurName;
    //    public byte Age;
    //}
}
