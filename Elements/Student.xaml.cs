using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Constructors_Шаповалова.Elements
{
    public partial class Student : UserControl
    {
        public event Action<Classes.Student> EditRequested;

        private Classes.Student _currentStudent;

        public Student(Classes.Student student)
        {
            InitializeComponent();

            _currentStudent = student;

            tb_fio.Content = student.GetFIO();
            tb_scholarship.Content = student.Scholarship ? "Стипендия: получает" : "Стипендия: не получает";
            tb_course.Content = $"Курс: {student.Course}";

            try
            {
                var imagePath = student.GetImage();
                tb_image.Source = new System.Windows.Media.Imaging.BitmapImage(new Uri(imagePath, UriKind.RelativeOrAbsolute));
            }
            catch { }
        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
            EditRequested?.Invoke(_currentStudent);
        }
    }
}
