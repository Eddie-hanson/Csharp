using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class2
{
    public class Customer
    {
        public string Name;
        public int Id;
        public List <Order> Orders;

        public Customer()
        {
            Orders = new List<Order>();
        }
        public Customer( int id)
        {
            this.Id = id;

        }
        public Customer(string name, int id)
        {
            this.Name = name;
            this.Id = id;
        }
    }
}
