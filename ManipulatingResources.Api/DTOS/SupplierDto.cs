using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using ManipulatingResources.Api.Helpers.Validations;

namespace ManipulatingResources.Api.DTOS
{
    public class SupplierDto
    {
        [Key]
        public int IdSupplier { get; set; }
        [Required]
        [FirstCapitalLetter]
        public string Name { get; set; }
        [Required]
        [NonNegative]
        public short CreditDays { get; set; }
        [Required]
        public byte IdStatus { get; set; }

        public IEnumerable<AccountPayableDto> AccountPayables { get; }
    }
}
