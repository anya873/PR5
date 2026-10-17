using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Шаповалова.Classes
{
    public class Student
    {
        public string Firstname = "";
        public string Lastname = "";
        public string Surname = "";
        public bool Scholarship = false;
        public int Course = 4;
        public string image = "/Constructors_Шаповалова;component/Images/ic_user.png";
        public Student(string Firstname, string Lastname, string Surname)
        {
            this.Firstname = Firstname;
            this.Lastname = Lastname;
            this.Surname = Surname;
        }
        public Student(string Firstname, string Lastname, string Surname, bool Scholaship):this(Firstname,Lastname, Surname)
        {
            this.Scholarship = Scholaship;
        }
        public Student(string Firstname, string Lastname, string Surname, bool Scholaship, int Course) : this(Firstname, Lastname, Surname, Scholaship)
        {
            this.Course = Course;
        }
        public Student(string Firstname, string Lastname, string Surname, bool Scholaship, int Course, string image) : this(Firstname, Lastname, Surname, Scholaship, Course)
        {
            this.image = image;
        }
        public string GetFIO()
        {
            return $"{Lastname} {Firstname} {Surname}";
        }
        public string GetImage()
        {
            return $"{image}";
        }
    }
}
