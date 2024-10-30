using DAL.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UrlDbContextIntilalizer(UrlDbContext dbContext) : IDbContextIntializer
    {
        public void Initilize()
        {
            var pendingMigrations =dbContext.Database.GetPendingMigrations();
            if (pendingMigrations.Any())
            {
                dbContext.Database.Migrate();
            }
           
        }
    }
}
