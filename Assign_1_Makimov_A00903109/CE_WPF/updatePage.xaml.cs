using System;
using System.Linq;
using System.Windows;

namespace CE_WPF
{
    /// <summary>
    /// Interaction logic for updatePage.xaml
    /// </summary>
    public partial class updatePage : Window
    {
        CEDataEntities _db = new CEDataEntities();
        int enrollId;

        public updatePage(int enrollId)
        {
            InitializeComponent();
            this.enrollId = enrollId;
        }

        private void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            var enrollment = _db.Enrollments.Single(enr => enr.Id == enrollId);
            enrollment.Grade = Int32.Parse(gradeTextBox.Text);

            var course = _db.Courses.Single(c => c.Id == enrollment.CourseId);
            course.Credits = Int32.Parse(creditsTextBox.Text);
            course.Title = titleTextBox.Text;

            var student = _db.Students.Single(s => s.Id == enrollment.StudentId);
            student.FirstMidName = firstMidNameTextBox.Text;
            student.LastName = lastNameTextBox.Text;

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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource studentViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("studentViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // studentViewSource.Source = [generic data source]
            System.Windows.Data.CollectionViewSource coursViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("coursViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // coursViewSource.Source = [generic data source]
        }
    }
}
