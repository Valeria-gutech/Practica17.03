using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace practica1.Models
{
    public class DataContext : DbContext
    {
        public DataContext() : base("DefaultConnection")
        {

        }
        public System.Data.Entity.DbSet<practica1.Models.gutierrez> gutierrez { get; set; }
    }
}