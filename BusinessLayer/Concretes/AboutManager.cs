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
    public class AboutManager:IAboutService
    {
        private IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }
        public List<About> GetAll()
        {
           var result =_aboutDal.GetAll();
           return result;
        }

        public About GetById(int id)
        {
            var result = _aboutDal.Get(x => x.Id == id);
            return result;

        }

        public void Add(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void Update(About entity)
        {
            _aboutDal.Update(entity);
        }

        public void Delete(int id)
        {
            var deleted = _aboutDal.Get(x => x.Id == id);
            _aboutDal.Delete(deleted);
        }
    }
}
