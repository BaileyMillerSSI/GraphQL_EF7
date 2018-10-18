using GraphQL.Net;
using GraphQLApi.Database.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQLApi.Database
{
    public interface IGraphQL
    {
        GraphQL<HeroContext> Current { get; }

    }
    public class GraphQLApi: IGraphQL
    {
        private readonly HeroContext _DB;

        public GraphQL<HeroContext> Current { get; private set; }

        public GraphQLApi(HeroContext DB)
        {
            _DB = DB;

            var schema = GraphQL<HeroContext>.CreateDefaultSchema(()=> _DB);
            
            schema.AddType<Hero>().AddAllFields();
            schema.AddListField("heros", db => db.Heroes);
            schema.AddField("user", new { id = 0 }, (db, args) => db.Heroes.Where(u => u.HeroId == args.id).FirstOrDefault());
            
            schema.Complete();
            
            this.Current = new GraphQL<HeroContext>();


        }
    }
}
