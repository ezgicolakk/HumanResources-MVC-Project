using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanResources.CORE.Entities
{
    public class AdvancePayment:BaseEntity
    {
        [Display(Name ="Toplam Ödeme")]
        public decimal TotalPaymentRequest { get; set; }

        [Display(Name ="Açıklama")]
        public string Description { get; set; }

        public DateTime CreateTime { get; set; } = DateTime.Now;
        public string FileName { get; set; }
        [NotMapped]
        public IFormFile File{ get; set; }

    }
}
