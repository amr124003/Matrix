using DAL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.INTERFACES
{
    public interface IAccount
    {
        public ApplicationUser Profile(string UserId);
        public void SaveChanges(ApplicationUser User);
        public string GetUserName(string? UserId);
    }
}
