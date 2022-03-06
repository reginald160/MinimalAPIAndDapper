
namespace UserDataAccess.DbAccess
{
    public interface ISqlDataAccess
    {
        Task<IEnumerable<T>> LoadData<T, U>(string storeName, U parameters, string connectionId = "Default");
        Task SaveData<T>(string storeName, T parameters, string connectionId = "Default");
    }
}