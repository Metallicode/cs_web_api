using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace database_connection
{
    public static class DataAccess
    {
        
        public static metaldatabaseEntities post_ctx = new metaldatabaseEntities();
        static int post_id_counter = post_ctx.USERS_POSTS.Count()+1;

        public static void addPost(string fn, 
            string ln, string email, string text)
        {
            var post = new USERS_POSTS()
            {
                First_Name = fn,
                Last_Name = ln,
                Email = email,
                Text = text,
                ID = post_id_counter++
            };


            post_ctx.USERS_POSTS.Add(post);
            post_ctx.SaveChanges();
        }

        public static List<USERS_POSTS> getPosts()
        {
            return post_ctx.USERS_POSTS.ToList<USERS_POSTS>();
        }


    }
}
