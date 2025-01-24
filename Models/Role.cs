using System.ComponentModel.DataAnnotations.Schema;


namespace Blog.Models
{
       [Dapper.Contrib.Extensions.Table("[Role]")]
    public class Role
    {
     
                public int Id{get;set;}
            public string Name{get;set;}
            public string Slug{get;set;}
                    }
    }