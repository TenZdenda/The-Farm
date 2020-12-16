using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


using farm.Models;

namespace farm
{
    public class OrderCatalog
    {

        private Dictionary<int, Order> orders { get; }

        private static OrderCatalog _instance;

        public List<Product> products { get; set; }

        private OrderCatalog()
        {
            orders = new Dictionary<int, Order>();
            products = new List<Product>();

            Product p1 = new Product() { Id = 2, Name = "Test", Description = "Test", Photo = "https://test.com/test.jpg", Price = 200 };
            Product p2 = new Product() { Id = 3, Name = "Test 2", Description = "Test 2", Photo = "https://test.com/test.jpg", Price = 200 };

            products.Add(p1);
            products.Add(p2);

            Customer c1 = new Customer() { ID = 1, Address = "Random 100", Name = "John Doe", Phone = 123456789 };

            orders.Add(1, new Order() {
                ID = 1,
                Customer = c1,
                DateTime = new DateTime(),
                List = products}
            );
        }

        public static OrderCatalog Instance
        {
            get
            {
                if(_instance == null)
                {
                    _instance = new OrderCatalog();
                }

                return _instance;
            }
        }

        public Dictionary<int, Order> AllOrders()
        {
            return orders;
        }

        public void AddOrder(Order order)
        {
            if( !(orders.Keys.Contains(order.ID)) )
            {
                orders.Add(order.ID, order);
            }
        }

        public Order GetOrder(int id)
        {
            return orders[id];
        }

        public void UpdateOrder(Order order)
        {
            if (order != null)
            {
                orders[order.ID] = order;
            }
        }

        public void DeleteOrder(Order order)
        {
            if (order != null)
            {
                orders.Remove(order.ID);
            }

        }

        public int OrderCount()
        {
            return orders.Count();
        }

        public int Money()
        {
            int cash = 0;

            foreach (var item in orders)
            {
                foreach (var i in item.Value.List)
                {
                    cash += (int)i.Price;
                }
            }

            return cash;
        }
    }
}
