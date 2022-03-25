using SF_25.DAL.Entitys;
using System.Collections.Generic;

namespace SF_25.DAL.Interfaces.Repository
{
    public interface IUserRepository
    {
        void AddNewUser(UserEntity user);
        void DeleteUser(UserEntity user);
        void GetAllUser();
        List<UserEntity> GetAllUsers();
        void UpdatUser();
    }
}