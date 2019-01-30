using DataAccess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace WpfAppClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //var context = new DataAccess.AdventureWorksLTContext();
            //var query = from c in context.Customer where c.CustomerId == 5 select c;
            //this.DataContext = query.FirstOrDefault();

            //Question 3. 1),2)
            //var seeder = new Seeder();
            //var data = seeder.GetEmployeeTestData();
            //CreateEmployeeTestData(data);

            //Question 4. Display Data Visually using Windows Presentation Foundation (WPF).
            this.Hide();
            EmployeesForm empForm = new EmployeesForm();
            empForm.Show();
        }

        Customer customer = new Customer
        {
            NameStyle = true,
            Title = "Mr.",
            FirstName = "Lemur",
            LastName = "Maximov",
            CompanyName = "Lucid Dreams",
            SalesPerson = "adventure-works\\linda1",
            EmailAddress = "gegapers@gmail.com",
            Phone = "7788355731",
            PasswordHash = "12345679",
            PasswordSalt = "97654321",
            Rowguid = Guid.NewGuid(),
            ModifiedDate = DateTime.Now
        };

        //Create
        private static void InsertCustomers(List<Customer> customers)
        {
            using (var context = new DataAccess.AdventureWorksLTContext())
            {
                foreach(var customer in customers)
                {
                    context.Set<Customer>().Add(customer);
                }
                context.SaveChanges();
            }
        }
        private static void InsertCustomer(Customer customer)
        {
            using (var context = new DataAccess.AdventureWorksLTContext())
            {
                context.Set<Customer>().Add(customer);
                context.SaveChanges();
            }
        }

        //Retrieve
        private static List<Customer> GetCustomers()
        {
            using (var context = new DataAccess.AdventureWorksLTContext())
            {
                var customers = context.Customer.ToList();
                return customers;
            }
        }
        private static Customer GetCustomerById(int id)
        {
            using (var context = new DataAccess.AdventureWorksLTContext())
            {
                var customer = context.Customer
                    .Where(c => c.CustomerId == id)
                    .SingleOrDefault();
                return customer;
            }
        }

        //Update
       // UpdateCustomers??? Do we really need to update many customers at the same time? What are the requirements for that?
        private static void UpdateCustomerById(Customer newCust)
        {
            using (var context = new DataAccess.AdventureWorksLTContext())
            {
                var custInDb = context.Customer.Single(c => c.CustomerId == newCust.CustomerId);
                custInDb.CustomerId = newCust.CustomerId;
                custInDb.NameStyle = newCust.NameStyle;
                custInDb.Title = newCust.Title;
                custInDb.FirstName = newCust.FirstName;
                custInDb.LastName = newCust.LastName;
                custInDb.CompanyName = newCust.CompanyName;
                custInDb.SalesPerson = newCust.SalesPerson;
                custInDb.EmailAddress = newCust.EmailAddress;
                custInDb.Phone = newCust.Phone;
                custInDb.PasswordHash = newCust.PasswordHash;
                custInDb.PasswordSalt = newCust.PasswordSalt;
                custInDb.Rowguid = newCust.Rowguid;
                custInDb.ModifiedDate = newCust.ModifiedDate;
                context.SaveChanges();
            }
        }

        //Delete
        // DeleteCustomers??? Do we really need to delete many customers at the same time? What are the requirements for that?
        // Do we delete them by id range or what would be the parameters?
        private static void DeleteCustomerById(int id)
        {
            using (var context = new DataAccess.AdventureWorksLTContext())
            {
                var customer = context.Customer
                    //.Include(c => c.SalesOrderHeader)
                    //.Include(c => c.CustomerAddress)
                    .SingleOrDefault(c => c.CustomerId == id);
                context.Set<Customer>().Remove(customer);
                context.SaveChanges();
            }
        }

        //Question 3.
        //1) Write a method to create test data for Employees table (seeding data).
        private static void CreateEmployeeTestData(List<Employee> employees)
        {
            using (var context = new DataAccess.AdventureWorksLTContext())
            {
                foreach (var employee in employees)
                {
                    context.Set<Employee>().Add(employee);
                }
                context.SaveChanges();
            }
        }

    }
}
