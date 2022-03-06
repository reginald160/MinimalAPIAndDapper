using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserDataAccess.DbAccess;
using UserDataAccess.Models;

namespace UserDataAccess.Data
{
    public class UserData : IUserData
    {
        private ISqlDataAccess _db;

        public UserData(ISqlDataAccess db)
        {
            this._db = db;
        }
        public Task<IEnumerable<UserModel>> GetUsers() => _db.LoadData<UserModel, dynamic>(storeName: "dbo.sp_User_GetAll", new { });
        public async Task<UserModel?> GetUser(int id)
        {

            var users = await _db.LoadData<UserModel, dynamic>(storeName: "dbo.sp_User_GetById", new { Id = id });

            return users.FirstOrDefault();
        }

        public Task Insert(UserModel userModel) => _db.SaveData(storeName: "dbo.sp_User_Insert", new { userModel.FirstName, userModel.LastName });

        public Task Update(UserModel userModel) => _db.SaveData(storeName: "dbo.sp_User_Update", userModel);

        public Task DeleteUser(int id) => _db.SaveData(storeName: "dbo.sp_User_Delete", new { Id = id });
    }
}
