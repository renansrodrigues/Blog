using Blog.Dto;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Service.Interface
{
  public  interface IBlogPostService
    {
        List<BlogPost> GetOlderPosts(int id);
        List<BlogPost> GetLatestPosts();
        BlogPost GetPostText(string link);

    }
}
