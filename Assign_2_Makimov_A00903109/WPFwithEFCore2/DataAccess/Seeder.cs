using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess
{
    //Question 3. 
    //2) Create a class and name it Seeder.cs. Use this class to seed 20 records in Employee table.
    public class Seeder
    {
        private List<Employee> EmpTestList = new List<Employee>
        {
            new Employee
            {
                LastName = "Shu",
                FirstName = "Yaoping",
                Title = "Mr.",
                BirthDate = new DateTime(1989, 1, 18),
                HireDate = new DateTime(2017, 10, 10),
                Address = "309-1894 Main street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V4T 4E8",
                Country = "Canada",
                HomePhone = "4085671254",
                Notes = "Can type very fast",
                Salary = 50000
            },
            new Employee
            {
                LastName = "Velasces",
                FirstName = "Juan",
                Title = "Mr.",
                BirthDate = new DateTime(1981, 12, 15),
                HireDate = new DateTime(2014, 9, 20),
                Address = "77-776 Nutka street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V8N 8B9",
                Country = "Canada",
                HomePhone = "847563623",
                Notes = "Likes to nap at the desk",
                Salary = 80000
            },
            new Employee
            {
                LastName = "Shulgin",
                FirstName = "Ivan",
                Title = "Mr.",
                BirthDate = new DateTime(1983, 9, 27),
                HireDate = new DateTime(206, 1, 20),
                Address = "666-456 Granville street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V7B 2E9",
                Country = "Canada",
                HomePhone = "423423423423",
                Notes = "Keeps a hamster in the drawer",
                Salary = 70000
            },
            new Employee
            {
                LastName = "Casella",
                FirstName = "Patricia",
                Title = "Ms.",
                BirthDate = new DateTime(1991, 9, 22),
                HireDate = new DateTime(2015, 7, 1),
                Address = "98-89A 1st Avenue",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V3B 1R8",
                Country = "Canada",
                HomePhone = "98345345345",
                Notes = "High attention to detail",
                Salary = 40000
            },
            new Employee
            {
                LastName = "Babalushi",
                FirstName = "Tony",
                Title = "Mr.",
                BirthDate = new DateTime(1978, 7, 7),
                HireDate = new DateTime(2011, 12, 3),
                Address = "444-899 Pepperoni street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "VPF 2B8",
                Country = "Canada",
                HomePhone = "92834234234",
                Notes = "Looks like a big deal",
                Salary = 90000
            },
            new Employee
            {
                LastName = "Keigo",
                FirstName = "Hegashino",
                Title = "Mr.",
                BirthDate = new DateTime(1993, 4, 25),
                HireDate = new DateTime(2018, 11, 4),
                Address = "509-131 2314 W 9th Avenue",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V6T 3E6",
                Country = "Canada",
                HomePhone = "45645645663",
                Notes = "Likes to work overtime",
                Salary = 60000
            },
            new Employee
            {
                LastName = "Hota",
                FirstName = "Miyouri",
                Title = "Ms.",
                BirthDate = new DateTime(1994, 11, 21),
                HireDate = new DateTime(2018, 4, 15),
                Address = "309-1894 Boundary road",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V7M 4E8",
                Country = "Canada",
                HomePhone = "234534543",
                Notes = "Bilingual",
                Salary = 700000
            },
            new Employee
            {
                LastName = "Shibalovska",
                FirstName = "Olga",
                Title = "Mrs.",
                BirthDate = new DateTime(1983, 12, 11),
                HireDate = new DateTime(2015, 10, 10),
                Address = "556-8093 Bute street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V5G 6E3",
                Country = "Canada",
                HomePhone = "23423552435",
                Notes = "Bakes cakes",
                Salary = 60000
            },
            new Employee
            {
                LastName = "Mehmed-Oglu",
                FirstName = "Firat",
                Title = "Mr.",
                BirthDate = new DateTime(1985, 6, 13),
                HireDate = new DateTime(2018, 3, 10),
                Address = "1212-476 Chilco street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V6B 3T4",
                Country = "Canada",
                HomePhone = "23423423423",
                Notes = "Plays harmonica",
                Salary = 45000
            },
            new Employee
            {
                LastName = "Kiribuchi",
                FirstName = "Koburagi",
                Title = "Mr.",
                BirthDate = new DateTime(1975, 10, 26),
                HireDate = new DateTime(2009, 5, 24),
                Address = "678-503 Beach avenue",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V8G 6EV",
                Country = "Canada",
                HomePhone = "2345553453",
                Notes = "Knows aikido",
                Salary = 100000
            },
            new Employee
            {
                LastName = "Otkean",
                FirstName = "Carley",
                Title = "Ms.",
                BirthDate = new DateTime(1989, 2, 5),
                HireDate = new DateTime(2013, 4, 1),
                Address = "871-1563 West 10th avenue",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V5M 1E4",
                Country = "Canada",
                HomePhone = "3453453345",
                Notes = "IQ = 300",
                Salary = 65000
            },
            new Employee
            {
                LastName = "Thompson",
                FirstName = "Wendy",
                Title = "Mrs.",
                BirthDate = new DateTime(1975, 6, 4),
                HireDate = new DateTime(2008, 9, 11),
                Address = "723-5345 Main street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V4T 4R8",
                Country = "Canada",
                HomePhone = "2342345235",
                Notes = "Bossy and keeps people under control",
                Salary = 50000
            },
            new Employee
            {
                LastName = "Ditmar",
                FirstName = "Martin",
                Title = "Mr.",
                BirthDate = new DateTime(1972, 11, 27),
                HireDate = new DateTime(1993, 1, 1),
                Address = "4124-563 Granville street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V5N 3E8",
                Country = "Canada",
                HomePhone = "234234234",
                Notes = "is a CTO",
                Salary = 70000
            },
            new Employee
            {
                LastName = "Lloyd",
                FirstName = "Adam",
                Title = "Mr.",
                BirthDate = new DateTime(1988, 5, 6),
                HireDate = new DateTime(2017, 7, 1),
                Address = "234-724 Dumb street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V7C 8T4",
                Country = "Canada",
                HomePhone = "23423423423",
                Notes = "Makes videogames",
                Salary = 55000
            },
            new Employee
            {
                LastName = "Parhar",
                FirstName = "Parminder",
                Title = "Mr.",
                BirthDate = new DateTime(1962, 6, 12),
                HireDate = new DateTime(1991, 1, 1),
                Address = "666-432 Drake street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V6B 4M6",
                Country = "Canada",
                HomePhone = "234234323",
                Notes = "",
                Salary = 80000
            },
            new Employee
            {
                LastName = "Bridge",
                FirstName = "Brook-Lyn",
                Title = "Ms.",
                BirthDate = new DateTime(1995, 11, 21),
                HireDate = new DateTime(2018, 10, 10),
                Address = "234-5434 Nicola street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V7A 4E8",
                Country = "Canada",
                HomePhone = "2342343432",
                Notes = "",
                Salary = 35000
            },
            new Employee
            {
                LastName = "Park",
                FirstName = "Stanley",
                Title = "Mr.",
                BirthDate = new DateTime(1987, 1, 5),
                HireDate = new DateTime(2016, 5, 2),
                Address = "4545-234 Chilco street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V6S 8Y3",
                Country = "Canada",
                HomePhone = "234234234",
                Notes = "Likes to walk in Stanley Park",
                Salary = 75000
            },
            new Employee
            {
                LastName = "Kwong",
                FirstName = "Tae-Hoon",
                Title = "Mr.",
                BirthDate = new DateTime(1986, 5, 30),
                HireDate = new DateTime(2017, 7, 20),
                Address = "4543-745 Broadway street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V8M 3O9",
                Country = "Canada",
                HomePhone = "3453454345",
                Notes = "Best student int the class",
                Salary = 60000
            },
            new Employee
            {
                LastName = "Kirova",
                FirstName = "Bianca",
                Title = "Ms.",
                BirthDate = new DateTime(1997, 5, 20),
                HireDate = new DateTime(2018, 5, 1),
                Address = "8678-457 Gillford street",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V6G 4E3",
                Country = "Canada",
                HomePhone = "234234234234",
                Notes = "Miss Universe",
                Salary = 60000
            },
            new Employee
            {
                LastName = "Kukushechna",
                FirstName = "Koktawa",
                Title = "Ms.",
                BirthDate = new DateTime(1984, 1, 30),
                HireDate = new DateTime(2018, 8, 14),
                Address = "4234-456 2nd avenue",
                City = "Vancouver",
                Region = "BC",
                PostalCode = "V5N 6Y3",
                Country = "Canada",
                HomePhone = "23423423457",
                Notes = "Highest score in Pokemon Go",
                Salary = 60000
            }
        };
        public List<Employee> GetEmployeeTestData()
        {
            return EmpTestList;
        }

    }
}
