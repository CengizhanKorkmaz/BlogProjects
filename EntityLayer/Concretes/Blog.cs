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
    public class Blog:BaseEntity,IEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public string ThumbnailImage { get; set; }
        public string Image { get; set;}
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int WriterId { get; set; }
        public Writer Writer { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
