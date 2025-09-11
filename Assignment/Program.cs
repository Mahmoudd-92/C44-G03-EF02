using Assignment.Contexts;
using Assignment.Models;
using Microsoft.EntityFrameworkCore;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region CRUD Operations
            using ITiDbContext Context = new ITiDbContext();

            #region Student Table
            #region Add
            //Student Student = new Student()
            //{
            //    FName = "Ahmed",
            //    LName = "Mohamed",
            //    Address = "99 Amr Gammal",
            //    Age = 30,
            //};
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //Context.Add(Student);
            //Context.SaveChanges();
            //Console.WriteLine($"Id after saving is: {Student.Id}, And the name is: {Student.FName}"); 
            #endregion

            #region Delete
            //var Student = Context.Student.FirstOrDefault(Student => Student.Id == 6);

            //if (Student != null)
            //{
            //    Context.Remove(Student);
            //    Console.WriteLine(Context.Entry(Student).State);
            //    Context.SaveChanges();
            //    Console.WriteLine(Context.Entry(Student).State);
            //} 
            #endregion
            #endregion

            #region Course Table

            #region Add
            //Course Course = new Course()
            //{
            //    Name = "C++",
            //    Description = "Fundamentals",
            //    Duration = 20,
            //};
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //Context.Add(Course);
            //Context.SaveChanges();
            //Console.WriteLine($"Course Id: {Course.Id}, And Tt's name is: {Course.Name}");
            #endregion

            #region Update
            //var Course = Context.Courses.FirstOrDefault(Course => Course.Id == 3);

            //if (Course != null)
            //{
            //    Console.WriteLine(Course.Name);
            //    Course.Name = "Python";
            //    Console.WriteLine(Course.Name);
            //    Context.SaveChanges();
            //}
            #endregion

            #endregion

            #region Topics Table

            #region ADD
            //Topic Topics = new Topic()
            //{
            //    Name = "Programing",
            //};
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //Context.Add(Topics);
            //Context.SaveChanges();
            //Console.WriteLine($"Topic Id: {Topics.Id}, And Tt's name is: {Topics.Name}"); 
            #endregion

            #region Retrieve
            //var Topics = Context.Topic.FirstOrDefault(Topic => Topic.Id == 1);
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;

            //if (Topics != null)
            //{
            //    Console.WriteLine(Topics.Name);
            //}
            #endregion

            #endregion

            #region Instructor Table

            #region Add
            //Instructor Instructor = new Instructor()
            //{
            //    Name = "Mohamed",
            //    Bouns = 3000,
            //    Salary= 10000,
            //    Adress = "100 Alaa ali",
            //    HourRate = 180,
            //};
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //Context.Add(Instructor);
            //Context.SaveChanges();
            //Console.WriteLine($"Id after saving is: {Instructor.Id}, And the name is: {Instructor.Name}");
            #endregion

            #region Delete
            //var Instructor = Context.Instructor.FirstOrDefault(Instructor => Instructor.Id == 2);

            //if (Instructor != null)
            //{
            //    Context.Remove(Instructor);
            //    Console.WriteLine(Context.Entry(Instructor).State);
            //    Context.SaveChanges();
            //    Console.WriteLine(Context.Entry(Instructor).State);
            //}
            #endregion

            #endregion

            #region Department Table

            #region Add
            //Department Department = new Department()
            //{
            //    Name = "Front-End",
            //    HiringDate = DateTime.Now,
            //};
            //Context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.TrackAll;
            //Context.Add(Department);
            //Context.SaveChanges();
            //Console.WriteLine($"Department Id: {Department.ID}, And Tt's name is: {Department.Name}");
            #endregion

            #region Update
            //var Department = Context.Department.FirstOrDefault(Department => Department.Name == "Front-End");

            //if (Department != null)
            //{
            //    Console.WriteLine(Department.Name);
            //    Department.Name = "Ui/UX";
            //    Console.WriteLine(Department.Name);
            //    Context.SaveChanges();
            //}
            #endregion

            #endregion

            #endregion


        }
    }
}
