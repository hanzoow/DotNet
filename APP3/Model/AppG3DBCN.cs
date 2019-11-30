using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APP3.Model
{
    public class AppG3DBCN : DbContext
    {
        public AppG3DBCN() : 
            base("Data Source=.;Initial Catalog=Csharp;Persist Security Info=True;User ID=sa;Password=123")
        {

        }
        public DbSet<Student> Students { get; set; }
        public DbSet<LearningHistory> LearningHistories { get; set; }
    }
}   
