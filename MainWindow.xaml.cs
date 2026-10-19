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

namespace Constructors_Шаповалова
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Classes.Student> AllStudent = Classes.RepoStudents.AllStudent();
        private List<Classes.Student> currentDisplayList;
        public int Count = 10;
        public int Step = 0;
        public MainWindow()
        {
            InitializeComponent();
            currentDisplayList = AllStudent;
            CreateStudent(Step, Count);
        }
        public void CreateStudent(int startIndex, int count)
        {
            for (int iStudent = startIndex; iStudent < startIndex + count; iStudent++)
            {
                if (currentDisplayList.Count > iStudent)
                {
                    var studentControl = new Elements.Student(currentDisplayList[iStudent]);

                    studentControl.EditRequested += StudentControl_EditRequested;

                    parent.Children.Add(studentControl);
                }
            }
            this.Step += count;
        }
        private void StudentControl_EditRequested(Classes.Student student)
        {
            var editWin = new EditWindow(student);

            if (editWin.ShowDialog() == true)
            {
                RefreshDisplayList();
            }
        }

        private void RefreshDisplayList()
        {
            parent.Children.Clear();
            Step = 0;
            CreateStudent(Step, Count);
        }
        private void ScrollViewer_ScrollChanged(object sender, ScrollChangedEventArgs e)
        {
            ScrollViewer scroll = sender as ScrollViewer;
            double ParentHeight = parent.ActualHeight;
            double WindowHeight = scroll.ActualHeight - 20;
            double DeltaHeight = ParentHeight - WindowHeight;
            if(DeltaHeight - scroll.VerticalOffset < 140)
            {
                CreateStudent(Step, Count);
            }
        }

        private void Search_SearchRequest(string searchText)
        {
            parent.Children.Clear();
            Step = 0;

            if (string.IsNullOrWhiteSpace(searchText))
            {
                currentDisplayList = AllStudent;
            }
            else
            {
                currentDisplayList = AllStudent
                    .Where(s => s.GetFIO().IndexOf(searchText, System.StringComparison.OrdinalIgnoreCase) >= 0)
                    .ToList();
            }

            CreateStudent(Step, Count);
        }
    }
}
