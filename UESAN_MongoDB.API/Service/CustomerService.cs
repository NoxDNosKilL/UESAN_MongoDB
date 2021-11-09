using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UESAN_MongoDB.API.Models;

namespace UESAN_MongoDB.API.Service
{
    public class CustomerService
    {
        private readonly IMongoCollection<Customer> _mongoDBContext;
        public CustomerService(ICustomerDatabaseSetting setting)
        {
            var client = new MongoClient(setting.ConnectionString);
            var database = client.GetDatabase(setting.DatabaseName);

            _mongoDBContext = database.GetCollection<Customer>
                (setting.CustomerCollectionName);
        }

        public async Task <IEnumerable<Customer>> GetCustomers()
        {
            return await _mongoDBContext.Find(c=>true).ToListAsync();
                
        }
        public async Task<Customer> GetCustomerById(string id)
        {
            return await _mongoDBContext.Find(c => c.id == id).FirstOrDefaultAsync();
        }
    }
}
