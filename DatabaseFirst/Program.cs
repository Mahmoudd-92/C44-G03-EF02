using DatabaseFirst.Contexts;
using Microsoft.EntityFrameworkCore;
using ITIContext context = new ITIContext();

#region Excuting Raw SQL Queries
////FromSqlRaw => for static use no dynamic variables
////FromSqlInterpolated => for dynamic variables to protect from SQL Injection

//var student = context.Students.FromSqlRaw("select * from student where St_Age > 1").ToList();
//int age = 1;
//var student = context.Students.FromSqlInterpolated($"select * from student where St_Age > {age}").ToList();
//foreach (var item in student)
//{
//    Console.WriteLine($"{item.St_Id} - {item.St_Fname} => {item.St_Age}");
//} 
#endregion

#region Update DB
////ExecuteSqlRaw => for static use no dynamic variables
////ExecuteSqlInterpolated => for dynamic variables to protect from SQL Injection

//context.Database.ExecuteSqlRaw("update student set St_Age = 31 where st_id = 1 ");
//int id = 1;
//context.Database.ExecuteSqlInterpolated($"update student set St_Age = 21 where st_id = {id} "); 
#endregion

#region Stored Procedure
//var result = context.Procedures.Sp_AssignStud2CourAsync(1, 100, 150);
#endregion

#region Views
//var result = context.StudCourseGrades.Where(x => x.Grade > 100).ToList();
//foreach (var item in result)
//{
//    Console.WriteLine($"{item.St_Fname},{item.Crs_Name}, {item.Crs_Id}");
//    Console.WriteLine("================");
//}
#endregion