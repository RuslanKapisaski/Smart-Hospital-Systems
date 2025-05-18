
namespace Hospital_System.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        public List<string> Items { get; set; }

        public short Quantity { get; set; }

        public DateTime ExpirationDate { get; set; }
    }
}
