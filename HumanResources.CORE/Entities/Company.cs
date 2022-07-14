using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HumanResources.CORE.Entities
{
    public class Company:BaseEntity
    {
        public Company()
        {

        }
        
        [Required(ErrorMessage="Lütfen şirket ismi giriniz.")]
        [Display(Name="Şirket Adı")]
        [RegularExpression(@"^[a-zA-ZğüşöçıİĞÜŞÖÇ]+$", ErrorMessage = "Lütfen sayı ve özel karakter kullanmayınız.")]
        public string Name { get; set; }

        [Display(Name="Adres")]
        public string Address { get; set; }

        [Display(Name="Telefon Numarası")]
        [DataType(DataType.PhoneNumber)]
        [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$",ErrorMessage ="Geçerli bir telefon numarası giriniz.")]
        public string PhoneNumber { get; set; }

        [RegularExpression(@"^(\d{10})$",ErrorMessage ="Vergi numarası 10 haneli olmalıdır.")]
        [Display(Name="Vergi numarası")]
        public string TaxNumber { get; set; }

        [Display(Name="Personel Sayısı")]
        public int PersonelSayisi { get; set; }

        [RegularExpression(@"^[a-zA-ZğüşöçıİĞÜŞÖÇ]+$",ErrorMessage ="Lütfen sayı ve özel karakter kullanmayınız.")]
        [Display(Name="Vergi Dairesi")]
        public string TaxAdministration { get; set; }

        [RegularExpression(@"^(\d{16})$",ErrorMessage ="Mersis numarası 16 haneli olmalıdır.")]
        [Display(Name="Mersis Numarası")]
        public string MersisNo { get; set; }

        public string PhotoPath { get; set; }
        [NotMapped]
        [Display(Name="Şirket Logosu")]
        public IFormFile Photo { get; set; } 
    }
}
