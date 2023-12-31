﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N31_HT1.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public int Amount { get; set; }
        public int CustomerId { get; set; }
        public DateTime OrderDate { get; set; }

        public Order(int id, int customerId, int amount, DateTime orderDate)
        {
            Id = id;
            Amount = amount;
            CustomerId = customerId;
            OrderDate = orderDate;
        }
    }
}
