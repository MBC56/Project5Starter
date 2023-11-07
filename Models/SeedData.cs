using System.Data;

namespace CourseCatalog.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;


public static class SeedData
{
    public static void Seed(DbContext context)
    {
        
        context.Set<Course>().RemoveRange(context.Set<Course>());
        List<Course> courses = new List<Course>
        {
            new Course { Id = 120, CourseName = "Logic", CourseDescription = "You will learn logic and it will help you with your other classes", RoomNumber = 101, StartTime = DateTime.Now.AddHours(1) },
            new Course { Id = 121, CourseName = "Python", CourseDescription = "You will learn the Python language and make a few different Projects using the coding language", RoomNumber = 102, StartTime = DateTime.Now.AddHours(2) },
            new Course { Id = 122, CourseName = "C#", CourseDescription = "You will learn the C# language and make a few different Projects using the coding language", RoomNumber = 103, StartTime = DateTime.Now.AddHours(3) },
            new Course { Id = 123, CourseName = "Java", CourseDescription = "You will learn the Java language and make a few different Projects using the coding language", RoomNumber = 104, StartTime = DateTime.Now.AddHours(4)},
            new Course { Id = 124, CourseName = "Cobol", CourseDescription = "You will learn the Cobol language and make a few different Projects using the coding language ", RoomNumber = 105, StartTime = DateTime.Now.AddHours(5)}
        };

        context.Set<Course>().AddRange(courses);
        context.SaveChanges();
    }
}