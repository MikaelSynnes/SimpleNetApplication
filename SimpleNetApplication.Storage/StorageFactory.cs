using Microsoft.EntityFrameworkCore;
using SimpleNetApplication.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleNetApplication.Storage
{
    public class StorageFactory : IStorageFactory
    {
        public StorageContext Create()
        {
            var dboptions = new DbContextOptionsBuilder<StorageContext>();
            dboptions.UseSqlite();

            return new StorageContext();
        }
    }
}
