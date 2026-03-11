using System;

namespace FoodiesDelight
{
    public class PlaceOrder : ICommand
    {
        private Order order;

        public PlaceOrder(Order order)
        {
            this.order = order;
        }

        public void Execute()
        {
            Console.WriteLine($"Your order id is: {order.id}, Dish: {order.dishName} ordered at {order.time}");
        }
    }
}
