using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyHelper.Data
{
    public class DataContext : DbContext
    {
        //inicialização por DI
        public DataContext()
        {

        }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        //set model classes  to dbcontext

        public virtual DbSet<Transaction> Transactions { get; set; }

        public virtual DbSet<Bill> Bills { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public DbSet<LowCategory> LowCategories { get; set; }

    
    }
}
