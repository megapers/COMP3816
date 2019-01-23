using System;
using System.Collections;
using System.Data;
using System.Linq;
using System.Windows;
using System.Windows.Controls;

namespace CE_WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CEDataEntities _db = new CEDataEntities();
        public static DataGrid dataGrid;


        public MainWindow()
        {
            InitializeComponent();
            Load();

        }
        private void Load()
        {
            var enrollList = _db.Enrollments
                .Select(e => new
                {
                    id = e.Id,
                    title = e.Cours.Title,
                    fName = e.Student.FirstMidName,
                    lName = e.Student.LastName,
                    grade = e.Grade,
                    date = e.Student.EnrollmentDate
                }).ToList();
            MyDataGrid.ItemsSource = enrollList;
            dataGrid = MyDataGrid;
        }

        private void insertBtn_click(object sender, RoutedEventArgs e)
        {
            InsertPage Ipage = new InsertPage();
            Ipage.ShowDialog();
        }

        private void udateBtn_click(object sender, RoutedEventArgs e)
        {
            var obj = ((FrameworkElement)sender).DataContext;
            var id = obj.GetType().GetProperty("id").GetValue(obj, null);
            var numId = Convert.ToInt32(id);
            updatePage Upage = new updatePage(numId);
            Upage.ShowDialog();
        }

        private void deleteBtn_click(object sender, RoutedEventArgs e)
        {
            var obj = ((FrameworkElement)sender).DataContext;
            var id = obj.GetType().GetProperty("id").GetValue(obj, null);
            var numId = Convert.ToInt32(id);
            var enrollment = _db.Enrollments.Single(enr => enr.Id == numId);
            _db.Enrollments.Remove(enrollment);
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
            dataGrid.ItemsSource = enrollList;

        }

    }
}
