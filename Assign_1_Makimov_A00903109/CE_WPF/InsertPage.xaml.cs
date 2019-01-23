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
using System.Windows.Shapes;

namespace CE_WPF
{
    /// <summary>
    /// Interaction logic for InsertPage.xaml
    /// </summary>
    public partial class InsertPage : Window
    {
         CEDataEntities _db = new CEDataEntities();
        public InsertPage()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource studentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // studentViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource coursViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("coursViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // coursViewSource.Source = [generic data source]
        }

        private void insertBtn_click(object sender, RoutedEventArgs e)
        {
            var newStudent = new Student()
            {
                FirstMidName = firstMidNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                EnrollmentDate = DateTime.Now
            };

            var newCourse = new Cours
            {
                Title = titleTextBox.Text,
                Credits = Int32.Parse(creditsTextBox.Text)
            };

            var newEnrollment = new Enrollment()
            {
                Student = newStudent,
                Cours = newCourse,
                Grade = Int32.Parse(gradeTextBox.Text)

            };

            _db.Students.Add(newStudent);
            _db.Courses.Add(newCourse);
            _db.Enrollments.Add(newEnrollment);
            _db.SaveChanges();

            var enrollList = _db.Enrollments
               .Select(x => new
               {
                   id = x.Id,
                   title = x.Cours.Title,
                   fName = x.Student.FirstMidName,
                   lName = x.Student.LastName,
                   grade = x.Grade,
                   date = x.Student.EnrollmentDate
               }).ToList();

            MainWindow.dataGrid.ItemsSource = enrollList;

            this.Hide();
        }
    }
}
