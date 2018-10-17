using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Database.Tables
{
    public class Hero
    {
        public int HeroId { get; set; }
        public String Name { get; set; }

        public List<Hero> Friends { get; set; } = new List<Hero>();
    }
}
