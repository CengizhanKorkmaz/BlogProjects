using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Repositories;
using EntityLayer.Concretes;

namespace DataAccessLayer.Abstracts
{
    public interface IBlogDal:IRepositoryDal<Blog>
    {
        List<Blog> GetListWithCategoryAndWriter();
        Blog GetListWithCategoryAndWriterById(int id);
        List<Blog> GetListByCategoryId(int id);
    }
}
