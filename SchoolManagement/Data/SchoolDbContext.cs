using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using SchoolManagement.Models;

namespace SchoolManagement.Data;

public class SchoolDbContext : DbContext
{
    public SchoolDbContext(
        DbContextOptions<SchoolDbContext> options)
    : base(options)
    {
    }

    public DbSet<Student> Students => Set<Student>();
}