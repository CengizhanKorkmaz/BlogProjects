using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;

namespace BusinessLayer.Concretes
{
    public class BlogManager:IBlogService
    {
        private IBlogDal _blogDal;

        public BlogManager(IBlogDal blogDal)
        {
            _blogDal = blogDal;
        }
        public List<Blog> GetAll()
        {
            var result = _blogDal.GetAll();
            return result;
        }

        public Blog GetById(int id)
        {
            var result = _blogDal.Get(x => x.Id == id);
            return result;
        }

        public void Add(Blog entity)
        {
            _blogDal.Add(entity);
        }

        public void Update(Blog entity)
        {
            _blogDal.Update(entity);
        }

        public void Delete(int id)
        {
            var deleted = _blogDal.Get(x => x.Id == id);
            _blogDal.Delete(deleted);
        }
    }
}
