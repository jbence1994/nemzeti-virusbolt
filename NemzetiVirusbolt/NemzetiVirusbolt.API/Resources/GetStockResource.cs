using System;

namespace NemzetiVirusbolt.API.Resources
{
    public class GetStockResource
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public DateTime DateRecorded { get; set; }
    }
}
