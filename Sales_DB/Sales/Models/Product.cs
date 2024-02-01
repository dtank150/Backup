using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Product name should not empty")]
        [MaxLength(100,ErrorMessage ="Product name should not more than 100")]
        public string Name { get; set; }
        [Range(1,Int32.MaxValue,ErrorMessage ="Qty should be more than 0")]
        public int Qty { get; set; }
        [Range(1,Int32.MaxValue,ErrorMessage ="Rate should be more than 0")]
        public int Rate { get; set; }
        public string Profile { get; set; }
        // [Required(AllowEmptyStrings =true)]

        public bool ISActive { get; set; } = true;
        public int CatId { get; set; }
    }
}
