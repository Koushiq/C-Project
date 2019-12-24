using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalHouseManagementSys.Entity
{
    public class AgreementEntity
    {
        public string adid { get; set; }
        public string landlordid { get; set; }
        public string tenantid { get; set; }
        public string rent { get; set; }
        public string paymentdate { get; set; }
    }
}
