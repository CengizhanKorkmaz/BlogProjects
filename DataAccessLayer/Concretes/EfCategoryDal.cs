using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstracts;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Concretes;

namespace DataAccessLayer.Concretes
{
    internal class EfCategoryDal:EfRepositoryBase<Category,Context>,ICategoryDal
    {
    }
}
