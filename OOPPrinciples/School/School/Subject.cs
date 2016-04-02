using System.Collections.Generic;

namespace School
{
    public class Subject
    {
        private string name;
        private int hoursLectures;
        private int hoursExercise;


        public Subject(string name, int hoursLectures, int hoursExercise)
        {
            this.Name = name;
            this.HoursLectures = hoursLectures;
            this.HoursExercise = hoursExercise;        
        }

        public int HoursExercise
        {
            get { return hoursExercise; }
            set { hoursExercise = value; }
        }
        
        public int HoursLectures
        {
            get { return hoursLectures; }
            set { hoursLectures = value; }
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, HoursOfLectures{1}, HoursOfExercise{2}", this.Name, this.hoursLectures, this.HoursExercise);
        }
    }
}