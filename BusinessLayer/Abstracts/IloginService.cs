using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer.Concretes;

namespace BusinessLayer.Abstracts
{
    public interface ILoginService
    {
        Writer Login(string email, string password);
    }
}
