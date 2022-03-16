using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDoInDotNet6.Models.Entities;

namespace ToDoInDotNet6.Models.Data
{
    public class DataContext :DbContext
    {
        public DataContext(DbContextOptions<DataContext> options):base(options) { }
        public DbSet<Todo>? Todos { get; set; }
        public DbSet<Author>? Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(
                new Author { Id=100,Name = "kavindu",Address="no 250",Streat="1 st streat", City="polgasowita"},
                new Author { Id = 101, Name = "mihiranga", Address = "no 253", Streat = "2 nd streat", City = "siyabalagoda" },
                new Author { Id = 102, Name = "wimalasooriya", Address = "no 545", Streat = " 1 st lane", City = "piliyandala" },
                new Author { Id = 103, Name = "yasara", Address = "no 463", Streat = "2 nd lane", City = "polgasowita" }
                );
            modelBuilder.Entity<Todo>().HasData(new Todo
            {
                Id = 100,
                Title = "go to work",
                Description ="this is the descreption",
                CreatedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                Status = TodoStatus.New,
                AuthorId = 100

            }, new Todo
            {
                Id = 101,
                Title = "second task",
                Description = "this is the descreption",
                CreatedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                Status = TodoStatus.Progress,
                AuthorId = 100

            }, new Todo
            {
                Id = 102,
                Title = "new task",
                Description = "this is the descreption",
                CreatedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                Status = TodoStatus.New,
                AuthorId = 103

            }, new Todo
            {
                Id = 103,
                Title = "another task",
                Description = "this is the descreption",
                CreatedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                Status = TodoStatus.New,
                AuthorId = 102

            }, new Todo
            {
                Id = 104,
                Title = "another task 101",
                Description = "this is the descreption",
                CreatedDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                Status = TodoStatus.New,
                AuthorId = 101

            });
        }
    }
}
