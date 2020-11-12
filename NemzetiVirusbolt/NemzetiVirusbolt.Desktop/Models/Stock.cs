﻿using System;

namespace NemzetiVirusbolt.Desktop.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int Quantity { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}