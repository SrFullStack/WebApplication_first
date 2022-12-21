using Entitiy;
using T_Repository;

namespace Service
{
    public interface IUserService
    {
   Task<UserTable>Get(string nameuser, int password);
      Task<  UserTable> Post(UserTable user);
        void Put(int id, UserTable updatedUser);
        public int ChckPassword(int password);
    }
}