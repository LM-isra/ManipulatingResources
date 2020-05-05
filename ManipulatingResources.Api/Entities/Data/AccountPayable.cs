using System;
using System.ComponentModel.DataAnnotations;
using ManipulatingResources.Api.Entities.Nomenclatures;
using ManipulatingResources.Api.Helpers.Validations;

namespace ManipulatingResources.Api.Entities.Data
{
    public class AccountPayable
    {
        [Key]
        public Guid IdAccountPayable { get; set; }
        [Required]
        [NonNegativeAttribute]
        public decimal Amount { get; set; }
        [Required]
        [DateLessThanCurrent]
        public DateTime Date { get; set; }
        [DateLessThanCurrent]
        public DateTime? DatePayment { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string Invoice { get; set; }
        [Required]
        public byte IdAccountType { get; set; }
        [Required]
        public byte IdCoin { get; set; }
        [Required]
        public byte IdMovementType { get; set; }
        [Required]
        public Guid IdSupplier { get; set; }
        [Required]
        public byte IdStatus { get; set; }

        public AccountType AccountType { get; }
        public Coin Coin { get; }
        public MovementType MovementType { get; }
        public Supplier Supplier { get; }
        public Status Status { get; }
    }
}
