using Business.Abstract;
using Core.Entities.Concrete;
using Core.Helper.Results.Abstract;
using Core.Helper.Results.Concrete.SuccessResults;
using DataAccess.Abstract;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : IUserManager
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void AddUser(User user)
        {
            _userDal.AddBlog(user);
        }

        public IDataResult<List<UserListDTO>> GetAllUsers()
        {
            var users = _userDal.GetAllUsers(); 
            return new SuccessDataResult<List<UserListDTO>>(users);
        }

        public User GetUser(string email)
        {
           return  _userDal.Get(x => x.Email == email);
        }

        public void RemoveUser(User user)
        {
             _userDal.Delete(user);
        }

        public void UpdateUser(User user)
        {
             _userDal.Update(user);
        }
    }
}
