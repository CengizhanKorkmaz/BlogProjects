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
    public class CommentManager:ICommentService
    {
        private ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }
        public List<Comment> GetAll()
        {
            var result = _commentDal.GetAll();
            return result;
        }

        public Comment GetById(int id)
        {
            var result = _commentDal.Get(x => x.Id == id);
            return result;
        }

        public void Add(Comment entity)
        {
            _commentDal.Add(entity);
        }

        public void Update(Comment entity)
        {
            _commentDal.Update(entity);
        }

        public void Delete(int id)
        {
            var deleted = _commentDal.Get(x => x.Id == id);
            _commentDal.Delete(deleted);
        }
    }
}
