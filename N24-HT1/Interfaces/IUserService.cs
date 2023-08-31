using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using N24_HT1.Models;

namespace N24_HT1.Interfaces
{
    public interface IUserService
    {
        public List<User> Get(int pagesize, int pagetoken);
        public List<User> Search(string searchKeywoard, int pagesize, int pagetoken);
        public List<User> Filter(UserFilterModel userfiltermodel);
        public User Add(string firstname, string lastname, string emailadress);
        public List<User> Update(User user);
        public void Delete(Guid id);

    }
}
