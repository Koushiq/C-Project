using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalHouseManagementSys.Entity
{
    public class PaymentEntity
    {
        public string PaymentId { get; set; }
        public string AdId { get; set; }
        public string BankAccLandlord { get; set; }
        public string BankAccTenant { get; set; }

        public string LastPaymentDate { get; set; }

        public string NextPaymentDate { get; set; }

        public string AdminApproved { get; set; }

    }
}
