using Demo.Contexts;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Entity FrameWork --> ORM
            //ORM --> Object Relational Mapper
            //DBContext,Entities

            // 2 Approaches:
            //   - DB First
            //   - Code First

            // ADO.Net Vs Dabber (Mini ORM)

            #region CRUD Operations

            using CompanyDbContext Context = new CompanyDbContext();

            #region Added
            //Employee employee = new Employee()
            //{
            //    Name = "Ahmed",
            //    address = "Cairo",
            //    Age = 25,
            //    Email = "ahmed@email.com",
            //    password = "ahmed",
            //    Test = 10
            //};
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;

            //Console.WriteLine(Context.Entry(employee).State); //Detached ==> not being tracked by the context

            //Context.Add(employee);
            ////Context.Add<Employee>(employee);
            ////Context.Employees.Add(employee);
            ////Context.Set <Employee>().Add(employee);
            ////Context.Entry<Employee>(employee).State = EntityState.Added;

            //Console.WriteLine(Context.Entry(employee).State); //Added ==> tracked by the context but does not yet exist in the database.
            //Console.WriteLine($"Id before saving is: {employee.Id}");

            //Context.SaveChanges(); //Saves all changes made in this context to DB

            //Console.WriteLine(Context.Entry(employee).State); //Unchanged ==> tracked by the context and exists in the database.
            //                                                  // Its property values have not changed from the values in the database.
            //Console.WriteLine($"Id after saving is: {employee.Id}");
            #endregion

            #region Retrieve
            //var employee = Context.Employees.Where(employee => employee.Id == 3).FirstOrDefault();
            //var employee = Context.Employees.FirstOrDefault(employee => employee.Id == 3);
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //var employee = Context.Employees.AsNoTracking().FirstOrDefault(employee => employee.Id == 3);

            //if (employee != null)
            //{
            //    Console.WriteLine(Context.Entry(employee).State); //Detached ==> not being tracked by the context
            //    Console.WriteLine(employee.Name);
            //}

            //var employee = Context.Employees.FirstOrDefault(employee => employee.Id == 3);
            //employee.Name = "Mahmoud";
            //if (employee != null)
            //{
            //    Console.WriteLine(Context.Entry(employee).State); //Modified ==> tracked by the context but does not yet exist in the database.
            //    Console.WriteLine(employee.Name);
            //}
            #endregion

            #region Update
            //var employee = Context.Employees.FirstOrDefault(employee => employee.Id == 3);

            //if (employee != null)
            //{
            //    Console.WriteLine(Context.Entry(employee).State); //Unchanged
            //    Console.WriteLine(employee.Name);
            //    employee.Name = "Mahmoud";      

            //    Console.WriteLine(Context.Entry(employee).State); //Modified
            //    Console.WriteLine(employee.Name);

            //    Context.SaveChanges();
            //    Console.WriteLine(Context.Entry(employee).State); //Unchanged
            //}

            //var employee = Context.Employees.AsNoTracking().FirstOrDefault(employee => employee.Id == 3);

            //if (employee != null)
            //{
            //    Console.WriteLine(Context.Entry(employee).State); //Detached
            //    Console.WriteLine(employee.Name);
            //    employee.Name = "Ali";

            //    Console.WriteLine(Context.Entry(employee).State); //Detached
            //    Console.WriteLine(employee.Name); //Ali

            //    Context.SaveChanges();
            //    Console.WriteLine(Context.Entry(employee).State); //Detached
            //} // No changes will be applied in the DB as we used the AsNoTracking(); 
            //  // we use this func when we want to do some operation without changing the OG DB and it helpes with performance.
            #endregion

            #region Delete
            //var employee = Context.Employees.FirstOrDefault(employee => employee.Id == 3);

            //if (employee != null)
            //{
            //    Console.WriteLine(Context.Entry(employee).State); //Unchanged

            //    Context.Remove(employee);
            //    //Context.Remove<Employee>(employee);
            //    //Context.Employees.Remove(employee);
            //    //Context.Set<Employee>().Remove(employee);
            //    //Context.Entry<Employee>(employee).State = EntityState.Deleted;

            //    Console.WriteLine(Context.Entry(employee).State); //Deleted==> tracked by the context and exists in the database.
            //                                                      //           It has been marked for deletion from the database.

            //    Context.SaveChanges();
            //    Console.WriteLine(Context.Entry(employee).State); //Detached
            //}
            #endregion 
            #endregion

        }
    }
}
