using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Repositories;
using EntityLayer.Concretes;

namespace BusinessLayer.Abstracts
{
    public interface IBlogService:IRepositoryService<Blog>
    {
        List<Blog> GetListWithCategoryAndWriter();
        Blog GetListWithCategoryAndWriterById(int id);
    }
}
