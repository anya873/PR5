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
        public void CreateStudent(int Step, int Count)
        {
            for(int iStudent=Step; iStudent<Step+Count;  iStudent++) 
                if(currentDisplayList.Count>iStudent)
                    parent.Children.Add(new Elements.Student(currentDisplayList[iStudent]));
            this.Step += Count;
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

        private void MySearch_Loaded(object sender, RoutedEventArgs e)
        {
            parent.Children.Clear();
            Step = 0;
            if (string.IsNullOrWhiteSpace(searchText))
            {
                currentDisplayList = AllStudent;
            }
            else
            {
                currentDisplayList = AllStudent.Where(s=>s.GetFIO().Contains(searchText, System.StringComparison.OrdinalIgnoreCase)).ToList();
                CreateStudent(Step,Count);
            }
        }
    }
}
