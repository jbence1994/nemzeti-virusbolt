using System;

namespace NemzetiVirusbolt.Desktop.Dtos
{
    public class StockDto
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}
