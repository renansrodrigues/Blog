using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repository.Interface
{
    public interface IBlogPostRepository
    {

        List<BlogPost> GetOlderPosts(int id);
        List<BlogPost> GetLatestPosts();
        BlogPost GetPostText(string link);



    }
}
