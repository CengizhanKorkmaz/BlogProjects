using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Abstracts;
using EntityLayer.Repositories;

namespace EntityLayer.Concretes
{
    public class Category:BaseEntity,IEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        List<Blog> Blogs { get; set; }


    }
}
