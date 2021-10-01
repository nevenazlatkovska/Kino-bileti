using Kino.Domain.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kino.Repository.Interface
{
    public interface IUserRepository
    {
        IEnumerable<KinoApplicationUser> GetAll();
        KinoApplicationUser Get(string id);
        void Insert(KinoApplicationUser entity);
        void Update(KinoApplicationUser entity);
        void Delete(KinoApplicationUser entity);
    }
}
