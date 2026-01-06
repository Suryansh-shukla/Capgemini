using System;
using System.Collections.Generic;
using System.Text;

namespace CustomePropertyDemo
{
    class Customer
    {
        List<Orders> orderList = new List<Orders>();
        //Orders[] myOrders = null;
        //public Customer()
        //{
        //    myOrders = new Orders[5];
        //}
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public Address BillingAdd { get; set; }
        public Address ShipAddress { get; set; }
        public List<Orders> MyOrders
        {
            get
            {
                return orderList;
            }
            set
            {
                orderList = value;
            }
        }
    }
}
