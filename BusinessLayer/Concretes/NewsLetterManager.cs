using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using EntityLayer.Concretes;

namespace BusinessLayer.Concretes
{
    public class NewsLetterManager:INewsLetterService
    {
        private INewsLetterDal _newsLetterDal;

        public NewsLetterManager(INewsLetterDal newsLetterDal)
        {
            _newsLetterDal = newsLetterDal;
        }
        public List<NewsLetter> GetAll()
        {
            var result = _newsLetterDal.GetAll();
            return result;
        }

        public NewsLetter GetById(int id)
        {
            var result = _newsLetterDal.Get(x => x.Id == id);
            return result;
        }

        public void Add(NewsLetter entity)
        {
            _newsLetterDal.Add(entity);
        }

        public void Update(NewsLetter entity)
        {
            _newsLetterDal.Update(entity);
        }

        public void Delete(int id)
        {
            var deleted = _newsLetterDal.Get(x => x.Id == id);
            _newsLetterDal.Delete(deleted);
        }
    }
}
