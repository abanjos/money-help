﻿using Microsoft.EntityFrameworkCore;
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

        public virtual DbSet<SubCategory> SubCategories { get; set; }

        public virtual DbSet<User> Users { get; set; }

        public virtual DbSet<Account> Accounts { get; set; }
    
    }
}
