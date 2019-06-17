using Microsoft.EntityFrameworkCore;
using Portal.Domain.Models;
using System;

namespace Portal.Domain
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) 
            : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
              base.OnConfiguring(optionBuilder);
        }


       
        public virtual DbSet<Departments> Departments { get; set; }
        public virtual DbSet<Person> Person { get; set; }
        public virtual DbSet<Contacts> Contacts { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            #region manage identity sequence
            builder.HasSequence<long>("DBSequenceStartFrom10000000")
                .StartsAt(10000000000)
                .IncrementsBy(1);

            builder.HasSequence<long>("DBSequenceStartFrom10")
                .StartsAt(10)
                .IncrementsBy(1);

            builder.HasSequence<long>("DBSequenceStartFrom100")
                .StartsAt(100)
                .IncrementsBy(1);

            #endregion

            #region db modification

            
         

            builder.Entity<Departments>()
                .Property(s => s.Id)
                .HasDefaultValueSql("NEXT VALUE FOR DBSequenceStartFrom100");

            builder.Entity<Person>()
                .Property(x => x.Id)
                .HasDefaultValueSql("NEXT VALUE FOR DBSequenceStartFrom10000000");
          

            #endregion



        }


    }
}
