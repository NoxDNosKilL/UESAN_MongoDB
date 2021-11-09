namespace UESAN_MongoDB.API.Models
{
    public interface ICustomerDatabaseSetting
    {
        string ConnectionString { get; set; }
        string CustomerCollectionName { get; set; }
        string DatabaseName { get; set; }
    }
}