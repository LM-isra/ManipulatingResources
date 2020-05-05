using System.Collections.Generic;
using ManipulatingResources.Api.Entities.Data;

namespace ManipulatingResources.Api.Entities.Nomenclatures
{
    public class MovementType
    {
        public byte IdMovementType { get; set; }
        public string Description { get; set; }

        public IEnumerable<AccountPayable> AccountPayables { get; }
        public IEnumerable<AccountReceivable> AccountReceivables { get; }
    }
}
