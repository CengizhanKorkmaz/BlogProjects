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
    public class SocialMediaManager:ISocialMediaService
    {
        private ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public List<SocialMedia> GetAll()
        {
            var result = _socialMediaDal.GetAll();
            return result;
        }

        public SocialMedia GetById(int id)
        {
            var result = _socialMediaDal.Get(x=>x.Id==id);
            return result;
        }

        public void Add(SocialMedia entity)
        {
            _socialMediaDal.Add(entity);
        }

        public void Update(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }

        public void Delete(int id)
        {
            var deleted = _socialMediaDal.Get(x => x.Id == id);
            _socialMediaDal.Delete(deleted);
        }
    }
}
