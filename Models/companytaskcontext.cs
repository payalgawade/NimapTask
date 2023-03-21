using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

namespace WebApplication30.Models
{
    public class companytaskcontext : DbContext
    {

        public DbSet<companytask> f1 { get; set; }

        
    }
}