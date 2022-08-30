using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Repositories
{
    public class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public bool Status { get; set; }

    }
}
