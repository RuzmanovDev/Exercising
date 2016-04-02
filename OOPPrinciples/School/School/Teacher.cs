using System.Collections.Generic;
using System.Text;

namespace School
{
    public class Teacher
    {
        private string name;
        private List<Subject> subjects;

        public Teacher(string name, List<Subject> subjects)
        {
            this.Name = name;
            this.Subjects = subjects;
        }



        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<Subject> Subjects
        {
            get
            {
                return subjects;
            }
            set { subjects = value; }
        }

        public override string ToString()
        {
            return string.Format("name: {0},{1}", this.Name,SujectsToString());
        }

        public string SujectsToString()
        {
            StringBuilder outputString = new StringBuilder();

            foreach (var discipline in this.Subjects)
            {
                outputString.Append(discipline.ToString() + " ");
            }

            return outputString.ToString().Trim();

        }
    }
}
