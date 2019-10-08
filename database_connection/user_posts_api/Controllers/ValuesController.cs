using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using database_connection;
using Newtonsoft.Json;

namespace user_posts_api.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<USERS_POSTS> Get()
        {
            var user_posts = DataAccess.getPosts();

            user_posts.Reverse();

            return user_posts.Take(5);
        }


        // POST api/values
        public void Post([FromBody]string value)
        {
            var result = JsonConvert.DeserializeObject<USERS_POSTS>(value);
            DataAccess.addPost(result.First_Name, result.Last_Name, result.Email, result.Text);
        }

    }
}
