using AutoMapper;
using Blog.Dto;
using Blog.Models;
using Blog.Repository;
using Blog.Repository.Interface;
using Blog.Service.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Service
{
    public class BlogPostService : IBlogPostService
    {

        
        private IBlogPostRepository _blogPostRepository;
        public BlogPostService(IBlogPostRepository blogPostRepository)
        {
            _blogPostRepository = blogPostRepository;
        }

        public List<BlogPost> GetLatestPosts()
        {

            return _blogPostRepository.GetLatestPosts();


        }

        public List<BlogPost> GetOlderPosts(int id)
        {
            return _blogPostRepository.GetOlderPosts(id);
        }

        public BlogPost GetPostText(string link)
        {
            return _blogPostRepository.GetPostText(link);
        }


    }
}
