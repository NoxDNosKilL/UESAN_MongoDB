using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UESAN_MongoDB.API.Models
{
    public class CustomerDatabaseSetting : ICustomerDatabaseSetting
    {
        public string CustomerCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }

    }
}
