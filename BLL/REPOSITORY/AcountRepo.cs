using BLL.INTERFACES;
using DAL.CONTEXT;
using DAL.ENTITIES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.REPOSITORY
{
    public  class AccountRepo : IAccount
    {
        ApplicationDBcontext _context;
        public AccountRepo(ApplicationDBcontext context)
        {
            _context = context;
        }

        public string GetUserName(string? UserId)
        {
            ApplicationUser? User = _context.Users.FirstOrDefault(x => x.Id == UserId);
            string res = User.UserName;
            return res;
        }

        public ApplicationUser Profile(string UserId)
        {
            ApplicationUser? User = _context.Users.FirstOrDefault(x => x.Id == UserId);
            return User;
        }

        public void SaveChanges(ApplicationUser User)
        {
            var user = _context.Users.FirstOrDefault(x => x.Email == User.Email);
            user.UserName = User.UserName;
            user.NormalizedUserName = User.UserName.ToUpper();
            user.PhoneNumber = User.PhoneNumber;
            user.Email = User.Email;
            user.Address = User.Address;
            user.Country = User.Country;
            _context.SaveChanges();

        }
    }
}
