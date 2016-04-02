
using System;
using System.Collections.Generic;

namespace School
{
    public class SchoolClass
    {
        private string textId;

        private List<Student> listOfStudents;


        public SchoolClass(string textId)
        {
            this.TextId = textId;

            this.ListOfStudents = new List<Student>();
        }

        public List<Student> ListOfStudents
        {
            get
            {
                return listOfStudents;
            }
            set { listOfStudents = value; }
        }

        public string TextId
        {
            get { return textId; }
            set { textId = value; }
        }

        public void AddStudent(Student student)
        {
            if (student == null)
            {
                throw new NullReferenceException();
            }
            if (this.ListOfStudents.Contains(student))
            {
                throw new ArgumentException("The class has a student with the same number!");
            }
            ListOfStudents.Add(student);
        }

    }
}
