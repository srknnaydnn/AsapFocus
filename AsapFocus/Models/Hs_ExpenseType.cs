using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsapFocus.Models
{
    public class Hs_ExpenseType
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string ExpenseType { get; set; }

    }
}
