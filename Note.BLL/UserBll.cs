using Note.IDAL;
using Note.Model;
using System;

namespace Note.BLL
{
    public class UserBll
    {
        // 강한 방식 
        // private UserDAL _userDal = new UserDal();
        // public User GetUser(int userNo)
        // {
        //     return _userDal.GetUser(userNo);
        // }
        // 
        // public List<User> GetUserList()
        // {
        //     throw new NotImplementedException();
        // }

        private IUserDAL _userDal;

        public UserBll(IUserDAL userDal)
        {
            _userDal = userDal;
        }

        public User GetUser(int userNo)
        {
            return _userDal.GetUser(userNo);
        }
    }
}
