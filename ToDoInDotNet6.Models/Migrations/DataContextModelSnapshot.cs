// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ToDoInDotNet6.Models.Data;

#nullable disable

namespace ToDoInDotNet6.Models.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ToDoInDotNet6.Models.Entities.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Streat")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            Address = "no 250",
                            City = "polgasowita",
                            Name = "kavindu",
                            Streat = "1 st streat"
                        },
                        new
                        {
                            Id = 101,
                            Address = "no 253",
                            City = "siyabalagoda",
                            Name = "mihiranga",
                            Streat = "2 nd streat"
                        },
                        new
                        {
                            Id = 102,
                            Address = "no 545",
                            City = "piliyandala",
                            Name = "wimalasooriya",
                            Streat = " 1 st lane"
                        },
                        new
                        {
                            Id = 103,
                            Address = "no 463",
                            City = "polgasowita",
                            Name = "yasara",
                            Streat = "2 nd lane"
                        });
                });

            modelBuilder.Entity("ToDoInDotNet6.Models.Entities.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatedDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 100,
                            AuthorId = 100,
                            CreatedDate = new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5224),
                            Description = "this is the descreption",
                            DueDate = new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5225),
                            Status = 0,
                            Title = "go to work"
                        },
                        new
                        {
                            Id = 101,
                            AuthorId = 100,
                            CreatedDate = new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5230),
                            Description = "this is the descreption",
                            DueDate = new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5231),
                            Status = 1,
                            Title = "second task"
                        },
                        new
                        {
                            Id = 102,
                            AuthorId = 103,
                            CreatedDate = new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5232),
                            Description = "this is the descreption",
                            DueDate = new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5233),
                            Status = 0,
                            Title = "new task"
                        },
                        new
                        {
                            Id = 103,
                            AuthorId = 102,
                            CreatedDate = new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5234),
                            Description = "this is the descreption",
                            DueDate = new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5235),
                            Status = 0,
                            Title = "another task"
                        },
                        new
                        {
                            Id = 104,
                            AuthorId = 101,
                            CreatedDate = new DateTime(2022, 3, 16, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5243),
                            Description = "this is the descreption",
                            DueDate = new DateTime(2022, 3, 23, 11, 57, 27, 999, DateTimeKind.Local).AddTicks(5244),
                            Status = 0,
                            Title = "another task 101"
                        });
                });

            modelBuilder.Entity("ToDoInDotNet6.Models.Entities.Todo", b =>
                {
                    b.HasOne("ToDoInDotNet6.Models.Entities.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("ToDoInDotNet6.Models.Entities.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}
