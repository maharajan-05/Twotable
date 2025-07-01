using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Author.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }
        public DbSet<Assesement> Assesements { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)

        {
            optionsBuilder.UseSqlServer("Data Source=LTIN604549\\MSSQ;Initial Catalog = db; Integrated Security=true;TrustServerCertificate=true");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidate>()
                .HasMany( b => b.Assessments)
                .WithMany( a => a.Candidates)
                .UsingEntity(j => j.ToTable("CandidateAssesements"));

        }




    }
}
