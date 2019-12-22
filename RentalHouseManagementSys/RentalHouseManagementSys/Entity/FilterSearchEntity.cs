using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalHouseManagementSys.Entity
{
    class FilterSearchEntity
    {
        public string SelectArea { get; set; }
        public string RentLowerLimit { get; set; }
        public string RentUpperLimit { get; set; }
        public string SquareFeetLowerLimit { get; set; }
        public string SquareFeetUpperLimit { get; set; }
        public string FlatType { get; set; }
    }
}
