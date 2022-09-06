using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstracts;
using DataAccessLayer.Abstracts;
using DataAccessLayer.Contexts;
using EntityLayer.Concretes;


namespace BusinessLayer.Concretes
{
    public class LoginManager:ILoginService
    {
        Context context=new Context();
        public Writer Login(string email, string password)
        {
            var result = context.Writers.FirstOrDefault(x=>x.Mail==email && x.Password==password);
            return result;

        }
    }
}
