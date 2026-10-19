using System.Windows;

namespace Constructors_Шаповалова
{
    public partial class EditWindow : Window
    {
        private Classes.Student _student;

        public EditWindow(Classes.Student student)
        {
            InitializeComponent();
            _student = student;

            tb_lastname.Text = _student.Lastname;
            tb_firstname.Text = _student.Firstname;
            tb_surname.Text = _student.Surname;
            tb_course.Text = _student.Course.ToString();
            cb_scholarship.IsChecked = _student.Scholarship;
        }

        private void BtnSave_Click(object sender, RoutedEventArgs e)
        {
            _student.Lastname = tb_lastname.Text;
            _student.Firstname = tb_firstname.Text;
            _student.Surname = tb_surname.Text;

            if (int.TryParse(tb_course.Text, out int course))
                _student.Course = course;

            _student.Scholarship = cb_scholarship.IsChecked ?? false;

            DialogResult = true;
        }
    }
}