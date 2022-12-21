using Entitiy;

namespace T_Repository
{
    public interface IUserRepository
    {
   Task   <UserTable>  Get(string nameuser, int password);
        Task<UserTable> Post(UserTable user);
 
        Task<UserTable>  Put(int userid, UserTable user);
    }
}