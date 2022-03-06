using UserDataAccess.Models;

namespace UserDataAccess.Data
{
    public interface IUserData
    {
        Task DeleteUser(int id);
        Task<UserModel?> GetUser(int id);
        Task<IEnumerable<UserModel>> GetUsers();
        Task Insert(UserModel userModel);
        Task Update(UserModel userModel);
    }
}