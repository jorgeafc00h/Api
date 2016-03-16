using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Product :BaseModel
    {
        [Required]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [Required]

        public string ProductName { get; set; }

        public string Description { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}
