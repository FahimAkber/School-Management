using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace School_Management.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<StudentModel> Students { get; set; }
        public DbSet<TeacherModel> Teachers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=school.db");
    }
}