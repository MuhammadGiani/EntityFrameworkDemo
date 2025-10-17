using EntityFrameWork.Infrastructure.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameWork.Infrastructure
{
                                 //base class to call its contructor use base keyword
    public class DatabaseContext : DbContext
    {
        //make constructror
        public DatabaseContext(DbContextOptions<DatabaseContext>options) : base(options)
        {
        }

        DbSet<Customer> customers { get; set; }
    }
}
