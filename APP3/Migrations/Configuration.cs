namespace APP3.Migrations
{
    using APP3.Model;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<APP3.Model.AppG3DBCN>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(APP3.Model.AppG3DBCN context)
        {

            var student = new Student
            {
                Id = "102T106",
                FirstName = "Nguyễn Đại ",
                LastName = "Hoài Vũ",
                DateOfBirth = new DateTime(1998, 06, 24),
                Gender = GENDER.Male,
                PlaceOfBirth = "Thừa Thiên Huế"
            };
            
            context.Students.AddOrUpdate(student);
            student = new Student
            {
                Id = "102T107",
                FirstName = "Nguyễn Đại ",
                LastName = "Hoài Khanh",
                DateOfBirth = new DateTime(2002, 06, 24),
                Gender = GENDER.Male,
                PlaceOfBirth = "Thừa Thiên Huế"
            };

            context.Students.AddOrUpdate(student);
            context.SaveChanges();
        }
    }
}
