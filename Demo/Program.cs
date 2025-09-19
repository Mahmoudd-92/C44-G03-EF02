using Demo.Contexts;
using Demo.Data;
using Demo.Models;
using Microsoft.EntityFrameworkCore;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Introduction
            //Entity FrameWork --> ORM
            //ORM --> Object Relational Mapper
            //DBContext,Entities

            // 2 Approaches:
            //   - DB First
            //   - Code First

            // ADO.Net Vs Dabber (Mini ORM) 
            #endregion

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

            #region Data Seeding
            #region Data Seeding Method #2
            //List<Department> departments = new List<Department>()
            //{
            //    new Department { Name = "HR2", DateOfCreation = DateTime.Now },
            //    new Department { Name = "PR2", DateOfCreation = DateTime.Now },
            //    new Department { Name = "Sales2", DateOfCreation = DateTime.Now }
            //};

            //Context.AddRange(departments);

            //Context.SaveChanges(); 
            #endregion

            #region Data Seeding Method #3 => The Best Method
            //bool flag = CompanyDbContextSeed.DataSeeding(Context);
            //Console.WriteLine(flag);
            #endregion

            #endregion

            #region Introduction to Loading
            //var employee = Context.Employees.FirstOrDefault(x => x.Id == 11);

            //if (employee is not null)
            //{
            //    Console.WriteLine($"Id = {employee.Id}, Name = {employee.Name}, DeptName = {employee.Department?.Name}");

            //    var department = Context.Department.FirstOrDefault(x => x.DeptId == employee.DepartmentID);

            //    if (department is not null)
            //    {
            //        Console.WriteLine($"DeptName = {department?.Name}");
            //    }
            //}
            #endregion

            #region Eagger Loading
            ////include(navigational prop)

            //var employee = Context.Employees.Include(x => x.Department).FirstOrDefault(x => x.Id == 11);

            //if (employee is not null)
            //{
            //    Console.WriteLine($"Id = {employee.Id}, Name = {employee.Name}, DeptName = {employee.Department?.Name}");
            //}

            ////ThenInclude() --> we use it after the include to access it's prop
            //var employee = Context.Employees.Include(x => x.Department).ThenInclude(x => x.Employees).FirstOrDefault(x => x.Id == 11);

            //if (employee is not null)
            //{
            //    Console.WriteLine($"Id = {employee.Id}, Name = {employee.Name}, DeptName = {employee.Department?.Name}");
            //}
            #endregion

            #region Explicit Loading
            //// entry() => Main entity / reference() => It's navigational prop / load() => to load it with the main entity 
            //var employee = Context.Employees.FirstOrDefault(x => x.Id == 11);

            //if (employee is not null)
            //{
            //    Context.Entry(employee).Reference(x => x.Department).Load();
            //    Console.WriteLine($"Id = {employee.Id}, Name = {employee.Name}, DeptName = {employee.Department?.Name}");
            //}

            //// collection() => to access a list
            //var department = Context.Department.FirstOrDefault(x => x.DeptId == 10);
            //Context.Entry(department).Collection(x => x.Employees).Load();

            #endregion

            #region Lazy Loading
            //// 1- Download lazy loading proxies package.
            //// 2- In the context in OnConfiguring (UseLazyLoadingProxies()) => bool default true.
            //// 3- make all navigational props virtual.

            //var employee = Context.Employees.FirstOrDefault(x => x.Id == 11);

            //if (employee is not null)
            //{
            //    Console.WriteLine($"Id = {employee.Id}, Name = {employee.Name}, DeptName = {employee.Department?.Name}");
            //}
            #endregion

            #region Joins 

            #region Inner Join
            #region Query Syntax
            //var query = (from employee in Context.Employees.AsNoTracking()
            //             join department in Context.Department.AsNoTracking()
            //             on employee.DepartmentID equals department.DeptId
            //             where department.Name == "HR"
            //             select new
            //             {
            //                 EmployeeName = employee.Name,
            //                 DepartmentName = department.Name
            //             }).ToList();
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.EmployeeName} => {item.DepartmentName}");
            //}
            #endregion

            #region Fluent Syntax
            //var query = Context.Employees.Join(Context.Department,
            //                                   employee => employee.DepartmentID,
            //                                   department => department.DeptId,
            //                                   (employee, department) => new
            //                                   {
            //                                       EmployeeName = employee.Name,
            //                                       DepartmentName = department.Name
            //                                   });
            //foreach (var item in query)
            //{
            //    Console.WriteLine($"{item.EmployeeName} => {item.DepartmentName}");
            //}
            #endregion 
            #endregion

            #endregion
        }
    }
}
