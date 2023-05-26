using Ceiberapp.Backend.Api.Db;
using Ceiberapp.Backend.Api.Models;
using System.Collections;

namespace Ceiberapp.Backend.Api.Core.Customer
{
    public class CustomerCore
    {
        private readonly DbContextCeiberApp _dbContextCeiberApp;

        public CustomerCore(DbContextCeiberApp dbContextCeiberApp) => _dbContextCeiberApp = dbContextCeiberApp;

        

    }
}
