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
    public class CategoryManager:ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            var result = _categoryDal.GetAll();
            return result;
        }

        public Category GetById(int id)
        {
            var result = _categoryDal.Get(x => x.Id == id);
            return result;
            
        }

        public void Add(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public void Update(Category entity)
        {
            _categoryDal.Update(entity);
        }

        public void Delete(int id)
        {
            var deleted = _categoryDal.Get(x => x.Id == id);
            _categoryDal.Delete(deleted);
        }
    }
}
