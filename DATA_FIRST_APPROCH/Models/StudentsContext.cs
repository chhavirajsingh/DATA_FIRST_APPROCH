using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DATA_FIRST_APPROCH.Models
{
    public class StudentsContext:DbContext
    {
        public StudentsContext(): base("Data Source=CHETUIWK1622\\SQLEXPRESS;Initial " +
            "Catalog=mvc11;Integrated Security=True") { }
        public DbSet<Students> Students { get; set; }

        
 
    }
}