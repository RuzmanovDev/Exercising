namespace School
{
    public class Student
    {
        private string numberInClass;
        private string name;

        public Student(string numberInClass, string name)
        {
            this.NumberInClass = numberInClass;
            this.Name = name;
        }

        public string NumberInClass
        {
            get
            {
                return this.numberInClass;
            }
            set
            {
                this.numberInClass = value;
            }
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("number in class{0}, name:{1}", this.NumberInClass, this.Name);
        }
    }
}
