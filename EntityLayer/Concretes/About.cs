using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Abstracts;
using EntityLayer.Repositories;

namespace EntityLayer.Concretes
{
    public class About:BaseEntity,IEntity
    {
        public string Title { get; set; }
        public string DetailsOne { get; set; }
        public string DetailsTwo { get; set; }
        public string ImageOne { get; set; }
        public string ImageTwo { get; set; }
        
    }
}
