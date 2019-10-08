using database_connection;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Cors;

namespace SelfHostApi
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    public class ValuesController : ApiController
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<USERS_POSTS> Get()
        {
            var user_posts = DataAccess.getPosts();

            user_posts.Reverse();

            return user_posts.Take(5);
        }

        [HttpGet]
        [ActionName("GetAll")]
        public IEnumerable<USERS_POSTS> GetAll()
        {
            var user_posts = DataAccess.getPosts();

            return user_posts;
        }


        // POST api/values
        public void Post([FromBody]string value)
        {
            var result = JsonConvert.DeserializeObject<USERS_POSTS>(value);
            DataAccess.addPost(result.First_Name, result.Last_Name, result.Email, result.Text);
        }

    }
}
