using System;

namespace MyDemoLib
{
    public class Customer
    {
        public int CustomerID { get; set; }
        protected string Name { get; set; }
        private int Age { get; set; }
        internal string Address { get; set; }
        protected internal string Skills { get; set; }

    }
}
