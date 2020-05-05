using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using ManipulatingResources.Api.Helpers.Validations;

namespace ManipulatingResources.Api.DTOS
{
    public class ClientDto
    {
        [Key]
        public Guid IdClient { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public bool AllowCredit { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [FirstCapitalLetter]
        public string Name { get; set; }
        [Required]
        [FirstCapitalLetter]
        public string LastName { get; set; }
        [NonNegative]
        public decimal Limit { get; set; }
        [Phone]
        public string Phone { get; set; }
        [Required]
        public byte IdStatus { get; set; }

        public IEnumerable<AccountReceivableDto> AccountReceivables { get; }
    }
}
