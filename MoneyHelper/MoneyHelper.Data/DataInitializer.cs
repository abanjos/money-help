using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;


namespace MoneyHelper.Data
{
    public static class DataInitializer
    {
        public static void Initialize(DataContext context)
        {
            //creating base
            context.Database.EnsureCreated();

            //verifying if any exists via linq
            if (context.Transactions.Any())
            {
                return;
            }


        }
    }
}
