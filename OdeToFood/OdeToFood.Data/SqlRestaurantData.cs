using OdeToFood.Core;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdeToFood.Data
{
    public class SqlRestaurantData : IRestaurantData
    {
        private ApplicationDbContext _dbContext;
        public SqlRestaurantData(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public IEnumerable<Restaurant> GetAll()
        {
            return _dbContext.Restaurants;
        }
    }
}
