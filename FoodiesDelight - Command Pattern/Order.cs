using System;

namespace FoodiesDelight
{
    public class Order
    {
        public int id;
        public string dishName;
        public string time;

        public Order(int id, string dishName, string time)
        {
            this.id = id;
            this.dishName = dishName;
            this.time = time;
        }
    }
}
