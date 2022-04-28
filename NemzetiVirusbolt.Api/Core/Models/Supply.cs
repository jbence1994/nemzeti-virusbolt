using System;

namespace NemzetiVirusbolt.Api.Core.Models
{
    public class Supply
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}
