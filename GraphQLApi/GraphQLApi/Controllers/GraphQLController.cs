using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQLApi.Database;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GraphQLApi.Controllers
{
    [Produces("application/json")]
    [Route("api/GraphQL")]
    public class GraphQLController : Controller
    {
        private readonly IGraphQL gql;
        
        public GraphQLController(IGraphQL gql)
        {
            this.gql = gql;
        }


        [HttpGet]
        public IActionResult Get(string query)
        {
            var data = gql.Current.ExecuteQuery(query);
            
            return Ok(data);
        }
    }
}