using Demo.Contexts;
using Inheritance_Mapping.Models;

namespace Inheritance_Mapping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Inheritance Mapping Types

            #region TPCT-Table Bare Concreate Type
            // -We only make a DbSet for Child's classes only when we migrate there will be 2 tables
            //  for (Part-Time/Full-Time) and both of them has all the props from the parent class (Employee)
            #endregion

            #region TPH-Table Bare Hierarchy
            // We mae Dbsets for both Parent/ childes
            // when we migrate there will Only one table (Parent Name => Employees) with new column (Discriminator)

            // If we want a physical representation to the Discriminator column we can  create a prop for it in the parent class

            //We can rename the column name and it's value's throw context
            #endregion

            #region TPT-Table Bare Type
            // We mae Dbsets for both Parent/ childes
            // when we migrate there will be three tables (1 Parent, 2 childes)
            #endregion
            #endregion

            using EmployeeDbContext Context = new EmployeeDbContext();
            FullTimeEmployee fullTimeEmployee = new FullTimeEmployee()
            {
                name = "John",
                Salary = 5000,
                StartDate = DateTime.Now,
                Address = "543 mhm street",
                age = 30,
            };

            PartTimeEmployee PartTimeEmployee = new PartTimeEmployee()
            {
                name = "smith",
                HourRate = 50,
                HoursWorked = 40,
                Address = "543 mhm street",
                age = 35,
            };

            //Context.Employees.Add(fullTimeEmployee);
            //Context.Employees.Add(PartTimeEmployee);
            ////Context.FullTimeEmployees.Add(fullTimeEmployee);
            ////Context.PartTimeEmployees.Add(PartTimeEmployee);
            //Context.SaveChanges();

            #region Quires on Inheritance Mapping
            #region TBCT
            //var FulltimeEmp = Context.FullTimeEmployees.FirstOrDefault();
            //if (FulltimeEmp != null)
            //{
            //    Console.WriteLine($"{FulltimeEmp.id}, {FulltimeEmp.name} , {FulltimeEmp.Salary}");
            //}

            //var PartTimeEmp = Context.PartTimeEmployees.FirstOrDefault();
            //if (PartTimeEmp != null)
            //{
            //    Console.WriteLine($"{PartTimeEmp.id}, {PartTimeEmp.name} , {PartTimeEmp.HourRate}");
            //}
            #endregion

            #region TBH
            //var employees = from emp in Context.Employees.OfType<PartTimeEmployee>()
            //                select emp;
            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.id}, {employee.name} , {employee.HourRate}");
            //}
            #endregion

            #region TBT
            //var employees = from emp in Context.FullTimeEmployees
            //                select emp;

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.id}, {employee.name}");
            //}
            #endregion

            #endregion


        }
    }
}
