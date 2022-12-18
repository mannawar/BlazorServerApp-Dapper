namespace DataAccessLibrary
{
    public interface ISqlDataAccess
    {
        string connectionStringName { get; set; }

        Task<List<T>> LoadData<T, U>(string sql, U paramaters);
        Task SaveData<T>(string sql, T paramaters);
    }
}