using System;
using System.Collections.Generic;
using System.Text;

namespace Day4OOPDemo
{
    internal class Ticket
    {
        public string TravelType { get; set; }
        public string ClassName { get; set; }
        public double BaseFare { get; set; }
        public double FinalFare { get; set; }
        public string Discount { get; set; }
        public string BookingStatus { get; set; }
    }
}
