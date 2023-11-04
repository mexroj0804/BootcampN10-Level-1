﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N38_HT2.Models
{
    internal class Order
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public DateOnly OrderDate { get; set; }
        public decimal Price { get; set; }
        public Order(int id, int orderId, DateOnly orderDate, decimal price)
        {
            Id = id;
            OrderId = orderId;
            OrderDate = orderDate;
            Price = price;
        }


    }
}
