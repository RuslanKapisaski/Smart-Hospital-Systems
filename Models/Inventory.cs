using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital_System.Models
{
    public class Inventory
    {
        public int inventoryId { get; set; }

        public List<string> items { get; set; }

        public short quantity { get; set; }

        public DateTime expirationDate { get; set; }    
    }
}
