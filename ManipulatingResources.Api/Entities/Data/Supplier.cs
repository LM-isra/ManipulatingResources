using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ManipulatingResources.Api.Helpers.Validations;
using ManipulatingResources.Api.Entities.Nomenclatures;

namespace ManipulatingResources.Api.Entities.Data
{
    public class Supplier
    {
        [Key]
        public Guid IdSupplier { get; set; }
        [Required]
        [FirstCapitalLetter]
        public string Name { get; set; }
        [Required]
        [NonNegative]
        public short CreditDays { get; set; }
        [Required]
        public byte IdStatus { get; set; }

        public Status Status { get; }
        public IEnumerable<AccountPayable> AccountPayables { get; }
    }
}
