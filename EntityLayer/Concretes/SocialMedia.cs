using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Abstracts;
using EntityLayer.Repositories;

namespace EntityLayer.Concretes
{
    public class SocialMedia:BaseEntity,IEntity
    {
        public string  Icon { get; set; }
        public string Count { get; set; }
        public string Name { get; set; }
        public string ClassName { get; set; }
    }
}
