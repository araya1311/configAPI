using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace configAPI.Models
{
    public class Config
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public bool FinalCustomer { get; set; }
        public bool InvoicingConcept { get; set; }
        public bool InvoicingPeriod { get; set; }
        public bool InvoicingStart { get; set; }
        public bool TaxBase { get; set; }
        public bool Iva { get; set; }
        public bool TotalAmount { get; set; }
        public string Language { get; set; }
        public string SenderMail { get; set; }
        public byte[] LogoUfinet { get; set; }

    }
}
