using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Challenge1.Entities
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
 
        //relación con posts
        public ICollection<Post> Posts { get; set; }

        //relación con comments
        public ICollection<Comment> Comments { get; set; }

    }
}
