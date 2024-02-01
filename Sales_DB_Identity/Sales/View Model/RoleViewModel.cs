using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sales.View_Model
{
    public class RoleViewModel
    {
        public int RoleId { get; set; }
        [Required]
        [Display(Name ="Role Name")]
        public String RoleName { get; set; }

    }
}
