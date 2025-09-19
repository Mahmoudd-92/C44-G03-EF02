using Demo.Contexts;
using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Demo.Data
{
    public static class CompanyDbContextSeed
    {
        // Data Seeding Method #3 => The Best Method
        public static bool DataSeeding(CompanyDbContext dbContext)
        {
			try
			{
				if (!dbContext.Employees.Any())
				{
					var EmployeeData = File.ReadAllText("Files\\employees.json");
					var Employees = JsonSerializer.Deserialize<List<Employee>>(EmployeeData);

					if (Employees?.Count > 0)
					{
						dbContext.Employees.AddRange(Employees);
						dbContext.SaveChanges();
					}
				}
				return true;
			}
			catch
			{
				return false;
			}
        }
    }
}
