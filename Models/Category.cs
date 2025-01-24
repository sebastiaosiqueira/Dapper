using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Models
{
    [Dapper.Contrib.Extensions.Table("[Category]")]
    public class Category
    {
        public int Id{get;set;}
        public string Name{get;set;}
        public string Slug{get;set;}
       public List<Post> Posts{get;set;}
    }
}