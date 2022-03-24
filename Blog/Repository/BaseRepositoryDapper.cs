using Blog.Repository.Interface;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Repository
{
    public  class BaseRepositoryDapper
    {


        protected string _stringConnection;

        public BaseRepositoryDapper()
        {
            _stringConnection = Environment.GetEnvironmentVariable("connectionstring");
        }

        protected string ObterConexao()
        {
            return _stringConnection;
        }        
    }
   
}
