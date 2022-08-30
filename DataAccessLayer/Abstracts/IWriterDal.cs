using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntityLayer.Concretes;

namespace DataAccessLayer.Abstracts
{
    public interface IWriterDal:IRepositoryDal<Writer>
    {
    }
}
