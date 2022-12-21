
using Entitiy;
using T_Repository;
using Zxcvbn;

namespace Service
{
    public class UserService : IUserService
    {

        private readonly IUserRepository _IUserRepository;
        public UserService(IUserRepository IUserRepository)
        {
            _IUserRepository = IUserRepository;
        }


        async public  Task<  UserTable> Get(string nameuser, int password)
        {
            {
                return await _IUserRepository.Get(nameuser, password);


            }

        }

       async public Task<UserTable> Post(UserTable user)
        {

            UserTable resUser =  await _IUserRepository.Post(user);
            if (resUser != null)
                return resUser;
            return null;

        }

        public void Put(int id, UserTable updatedUser)
        {
            _IUserRepository.Put(id, updatedUser);
        }
        public int ChckPassword(int password)
        {
            Result result = Zxcvbn.Core.EvaluatePassword("password");
            return result.Score;

        }
    }
}