using System.Collections.Generic;
using ManipulatingResources.Api.Entities.Data;

namespace ManipulatingResources.Api.Entities.Nomenclatures
{
    public class Status
    {
        public byte IdStatus { get; set; }
        public string Description { get; set; }

        public IEnumerable<AccountPayable> AccountPayables { get; }
        public IEnumerable<AccountReceivable> AccountReceivables { get; }
        public IEnumerable<Client> Clients { get; }
        public IEnumerable<Supplier> Suppliers { get; }
    }
}
