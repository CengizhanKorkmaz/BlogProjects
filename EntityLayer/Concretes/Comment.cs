using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Abstracts;
using EntityLayer.Repositories;

namespace EntityLayer.Concretes
{
    public class Comment:BaseEntity,IEntity
    {
        public string UserName { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
