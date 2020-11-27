﻿using System;

namespace NemzetiVirusbolt.Core.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}
