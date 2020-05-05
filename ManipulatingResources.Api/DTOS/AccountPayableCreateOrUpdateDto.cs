using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManipulatingResources.Api.DTOS
{
    public class AccountPayableCreateOrUpdateDto
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public string Invoice { get; set; }
        public DateTime? DatePayment { get; set; }
        public string Description { get; set; }
        public string Reference { get; set; }
        public int IdSupplier { get; set; }
        public short IdCoin { get; set; }
        public int IdAccountDocumentType { get; set; }
        public byte IdStatus { get; set; }

    }
}
