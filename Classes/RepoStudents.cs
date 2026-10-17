using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors_Шаповалова.Classes
{
    public class RepoStudents
    {
        public static List<Student> AllStudent()
        {
            List<Student> allStudent = new List<Student>();
            allStudent.Add(new Student("Болотов", "Евгений", "Олегович"));
            allStudent.Add(new Student("Грогорьев", "Роман", "Владимирович"));
            allStudent.Add(new Student("Гудков", "Георгий", "Константинович", false, 3, "/Constructors_Шаповалова;component/Images/5_2.png"));
            allStudent.Add(new Student("Исыпова", "Алёна", "Александровна", true));
            allStudent.Add(new Student("Иутин", "Павел", "Алексеевич", false, 3, "/Constructors_Шаповалова;component/Images/5_3.png"));
            allStudent.Add(new Student("Ишимов", "Виктор", "Алексеевич"));
            allStudent.Add(new Student("Калюжный", "Артём", "Евгеньевич"));
            allStudent.Add(new Student("Кусакина", "Полина", "Олеговна", true));
            allStudent.Add(new Student("Ленченков", "Александр", "Дмитриевич"));
            allStudent.Add(new Student("Лесникова", "Мария", "Михайловна", true));
            allStudent.Add(new Student("Лихачева", "Татьяна", "Яковлева"));
            allStudent.Add(new Student("Мокрушина", "Надежда", "Владимировна", true));
            allStudent.Add(new Student("Мугатагаров", "Даниил", "Ринатович"));
            allStudent.Add(new Student("Нарижный", "Данил", "Владленович"));
            allStudent.Add(new Student("Никонов", "Арсений", "Дмитриевич", false, 3, "/Constructors_Шаповалова;component/Images/5_1.png"));
            allStudent.Add(new Student("Оборин", "Даниил", "Артёмович"));
            allStudent.Add(new Student("Посадских", "Дарья", "Андреевна"));
            allStudent.Add(new Student("Сторожев", "Денис", "Романович", true));
            allStudent.Add(new Student("Суслов", "Егор", "Владимирович"));
            allStudent.Add(new Student("Халилов", "Дамир", "Ринатович"));
            allStudent.Add(new Student("Шестаков", "Дмитрий", "Андреевич"));
            return allStudent;
        }
    }
}
