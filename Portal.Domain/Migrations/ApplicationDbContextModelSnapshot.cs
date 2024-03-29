﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Portal.Domain;

namespace Portal.Domain.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("Relational:Sequence:.DBSequenceStartFrom10", "'DBSequenceStartFrom10', '', '10', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.DBSequenceStartFrom100", "'DBSequenceStartFrom100', '', '100', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("Relational:Sequence:.DBSequenceStartFrom10000000", "'DBSequenceStartFrom10000000', '', '10000000000', '1', '', '', 'Int64', 'False'")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Portal.Domain.Models.Contacts", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired();

                    b.Property<string>("HouseAddress")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long>("PeronsId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.HasKey("Id");

                    b.HasIndex("PeronsId");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("Portal.Domain.Models.Departments", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEXT VALUE FOR DBSequenceStartFrom100");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("Portal.Domain.Models.Person", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEXT VALUE FOR DBSequenceStartFrom10000000");

                    b.Property<long>("DepartmentId");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasMaxLength(7);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("OtherName");

                    b.HasKey("Id");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Portal.Domain.Models.Contacts", b =>
                {
                    b.HasOne("Portal.Domain.Models.Person", "Person")
                        .WithMany("Contacts")
                        .HasForeignKey("PeronsId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Portal.Domain.Models.Person", b =>
                {
                    b.HasOne("Portal.Domain.Models.Departments", "Departments")
                        .WithMany("People")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
