using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MicroRabbit.MVC.Models.DTO
{
    public class TransferDTO
    {
        public int FromAccount { get; set; }
        public int ToAccount { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal TransferAmount { get; set; }
    }
}
