using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Project_EmployeeManangementSystem.Models;

namespace EmployeeManagementSystem.Data
{
    public class EmployeeManagementSystemDbContext : DbContext
    {
        public EmployeeManagementSystemDbContext (DbContextOptions<EmployeeManagementSystemDbContext> options)
            : base(options)
        {
        }

        public DbSet<Project_EmployeeManangementSystem.Models.EmpProfile> EmpProfile { get; set; } = default!;
    }
}
