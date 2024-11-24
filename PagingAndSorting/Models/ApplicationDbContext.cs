using Microsoft.EntityFrameworkCore;
using PagingAndSorting.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PagingAndSorting.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext()
        {
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<EmployeeMaster> Employees { get; set; }
    }
}