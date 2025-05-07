using Craft.Inventory.Infastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Craft.Inventory.Infastructure
{
    public static class InfrastructureRegistrations
    {
        /// <summary>
        /// this function for adding sql server Db context connection String
        /// </summary>
        public static void AddInventoryDbContext(this IServiceCollection services, string connectionString) =>
            services.AddDbContext<ApplicationDBContext>(options => options.UseSqlServer(connectionString));
        

        //public static void AddInfrastructureRegistrations(this IServiceCollection services)
        //{
        //    services.AddScoped(typeof(IRepository<>), typeof(InventoryRepository<>));
        //    services.AddScoped(typeof(IReadRepository<>), typeof(InventoryRepository<>));
        //}
    }
}
