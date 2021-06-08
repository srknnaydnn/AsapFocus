using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AsapFocus.Models
{
    public class HS_CostOfFuture
    {

        [Key]
        public int DocNum { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string ExpenseType { get; set; }
        [Required]
        public int PolcyNum { get; set; }
        [Required]
        public DateTime BegDate { get; set; }
        [Required]
        public DateTime EndTime { get; set; }

        [Required]
        public int PolcyAmount { get; set; }
        [Required]
        public int InstallmentNo { get; set; }
        [Required]
        public string Comments { get; set; }
        
    }
}
