﻿using DataAccess;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfAppClient
{
    /// <summary>
    /// Interaction logic for EmployeesForm.xaml
    /// </summary>
    public partial class EmployeesForm : Window
    {
        public EmployeesForm()
        {
            InitializeComponent();
            var seeder = new Seeder();
            employeeView.ItemsSource = seeder.GetEmployeeTestData();
        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);

            Application.Current.Shutdown();
        }
    }
}
