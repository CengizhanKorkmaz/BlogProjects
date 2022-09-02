using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Abstracts;
using EntityLayer.Repositories;

namespace EntityLayer.Concretes
{
    public class Contact:BaseEntity,IEntity
    {
        public string UserName { get; set; }
        public string Mail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
       
    }
}
