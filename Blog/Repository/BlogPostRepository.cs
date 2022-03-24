using Blog.Models;
using Blog.Repository.Interface;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public class BlogPostRepository : BaseRepositoryDapper,  IBlogPostRepository
    {


        public List<BlogPost> GetLatestPosts()
        {

            string query = @"Select Id, Title,ShortDescription,Link from Blog order by id desc";

            using (SqlConnection connection = new SqlConnection(ObterConexao()))
            {
                connection.Open();
                return connection.Query<BlogPost>(query).AsList();
            }
        }

        public List<BlogPost> GetOlderPosts(int id)
        {
            string sql = @"Select Id, Title,ShortDescription,Link from BlogPost where id=@id";

            using (SqlConnection connection = new SqlConnection(ObterConexao()))
            {
                connection.Open();
                return connection.Query<BlogPost>(sql, new
                {
                    id = id
                }).ToList();
            }
           
        }

        public BlogPost GetPostText(string link)
        {
            
            string sql = @"Select Id, Title,ShortDescription,Link from BlogPost where Link=@link";

            using (SqlConnection connection = new SqlConnection(ObterConexao()))
            {
                connection.Open();
                return connection.Query<BlogPost>(sql, new
                {
                    link = link.Trim()
                }).FirstOrDefault();
            }

        }
                     
    }
}
