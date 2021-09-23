using OdeToFood.Core;
using System;
using System.Collections;
using System.Collections.Generic;

namespace OdeToFood.Data
{
    public interface IRestaurantData
    {
        public IEnumerable<Restaurant> GetAll();
    }
}
