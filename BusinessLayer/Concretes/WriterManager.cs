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
    public class WriterManager:IWriterService
    {
        private IWriterDal _writerDal;

        public WriterManager(IWriterDal writerDal)
        {
            _writerDal = writerDal;
        }
        public List<Writer> GetAll()
        {
            var result = _writerDal.GetAll();
            return result;
        }

        public Writer GetById(int id)
        {
            var result = _writerDal.Get(x => x.Id == id);
            return result;
        }

        public void Add(Writer entity)
        {
            _writerDal.Add(entity);
        }

        public void Update(Writer entity)
        {
            _writerDal.Update(entity);
        }

        public void Delete(int id)
        {
            var deleted = _writerDal.Get(x => x.Id == id);
            _writerDal.Delete(deleted);
        }
    }
}
