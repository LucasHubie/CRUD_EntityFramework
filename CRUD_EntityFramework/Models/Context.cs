using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CRUD_EntityFramework.Models
{
    public class Context : DbContext
    {
        public DbSet<Pessoa> Pessoa { get; set; }
    }
}