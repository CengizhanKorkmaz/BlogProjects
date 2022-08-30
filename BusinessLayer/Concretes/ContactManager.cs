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
    public class ContactManager:IContactService
    {
        private IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }
        public List<Contact> GetAll()
        {
            var result = _contactDal.GetAll();
            return result;
        }

        public Contact GetById(int id)
        {
            var result = _contactDal.Get(x => x.Id == id);
            return result;
        }

        public void Add(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void Update(Contact entity)
        {
            _contactDal.Update(entity);
        }

        public void Delete(int id)
        {
            var deleted = _contactDal.Get(x => x.Id == id);
            _contactDal.Delete(deleted);
        }
    }
}
