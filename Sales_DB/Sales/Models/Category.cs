using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Category
    {
        public int Id { get; set; } //Auto Increment /Primary Key
        [Required]
        [MaxLength(50,ErrorMessage ="Category name should not more than 50")]
        public string Name { get; set; }
    }
}
