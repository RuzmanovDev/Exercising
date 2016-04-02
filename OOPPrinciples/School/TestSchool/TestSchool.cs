namespace TestSchool
{
    using School;
    using System;
    using System.Collections.Generic;
    using School;

    class TestSchool
    {
        static void Main(string[] args)
        {
            SchoolClass stream108 = new SchoolClass("stream108");

            stream108.AddStudent(new Student("28", "Stoyan"));
            stream108.AddStudent(new Student("28", "Pesho"));


            //  stream108.TextId = "";
            var students = stream108.ListOfStudents;

            foreach (var st in students)
            {
                Console.WriteLine(st);
            }
        }
    }
}
