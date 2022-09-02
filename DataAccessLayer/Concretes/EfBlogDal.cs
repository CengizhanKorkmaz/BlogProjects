using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Abstracts;
using DataAccessLayer.Contexts;
using DataAccessLayer.Repositories;
using EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Concretes
{
    public class EfBlogDal:EfRepositoryBase<Blog,Context>,IBlogDal
    {
        public List<Blog> GetListWithCategoryAndWriter()
        {
            using (var context=new Context())
            {
                var result = context.Blogs.Include(x => x.Category).Include(x => x.Writer);
                return result.ToList();
            }
        }

        public Blog GetListWithCategoryAndWriterById(int id)
        {
            using (var context = new Context())
            {
                var result = context.Blogs.Include(x => x.Category).Include(x => x.Writer).Where(x=>x.Id==id).FirstOrDefault();
                return result;
            }
        }

        public List<Blog> GetListByCategoryId(int id)
        {
            using (var context=new Context())
            {
                var result = context.Blogs.Include(x => x.Category).Include(x => x.Writer).Where(x => x.CategoryId == id).ToList();
                return result;
            }
        }
    }
}
