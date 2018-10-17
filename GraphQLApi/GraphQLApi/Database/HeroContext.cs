using GraphQLApi.Database.Tables;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Database
{
    public class HeroContext: DbContext
    {
        public HeroContext(DbContextOptions<HeroContext> options) 
            : base(options)
        {

        }


        public DbSet<Hero> Heroes { get; set; }
    }
}
