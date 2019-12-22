using RentalHouseManagementSys.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalHouseManagementSys.repository
{
    class FilterSearchRepository
    {
        public DataAccess Da { get; set; }
        public DataSet Ds { get; set; }

     
        
        public FilterSearchEntity ConvertToEntity(ComboBox cmbSelectArea , TextBox txtRentLowerLimit, TextBox txtRentUpperLimit, TextBox txtSquareFeetLowerLimit,TextBox txtSquareFeetUpperLimit,ComboBox cmbFlatType)
        {
            FilterSearchEntity filterSearchEntity=new FilterSearchEntity();
            filterSearchEntity.SelectArea = cmbSelectArea.Text;
            filterSearchEntity.RentLowerLimit = txtRentLowerLimit.Text;
            filterSearchEntity.RentUpperLimit = txtRentUpperLimit.Text;
            filterSearchEntity.SquareFeetLowerLimit = txtSquareFeetLowerLimit.Text;
            filterSearchEntity.SquareFeetUpperLimit = txtSquareFeetUpperLimit.Text;
            filterSearchEntity.FlatType = cmbFlatType.Text;
            return filterSearchEntity;
        }

        public int ValidateEntity(FilterSearchEntity filterSearchEn)
        {
            if (!filterSearchEn.FlatType.Equals("") && !filterSearchEn.RentLowerLimit.Equals("") && !filterSearchEn.RentUpperLimit.Equals("") && !filterSearchEn.SquareFeetLowerLimit.Equals("") && !filterSearchEn.SquareFeetUpperLimit.Equals("") && !filterSearchEn.FlatType.Equals(""))
            {
                if(Convert.ToInt32(filterSearchEn.RentLowerLimit)<= Convert.ToInt32(filterSearchEn.RentUpperLimit)  && Convert.ToInt32(filterSearchEn.SquareFeetLowerLimit)<= Convert.ToInt32(filterSearchEn.SquareFeetUpperLimit))
                {
                    return 1;
                }
                else
                {
                    return -1;
                }
                
            }
            return 0;
        }

        public string GenerateQuery(FilterSearchEntity filterSearchEn)
        {
            string sql ="select * from ad where  location = '" + filterSearchEn.SelectArea + "' and rent >= " +filterSearchEn.RentLowerLimit+ " and rent <= " +filterSearchEn.RentUpperLimit+ "  and squarefeet >= " + filterSearchEn.SquareFeetLowerLimit+ " and squarefeet <= " + filterSearchEn.SquareFeetUpperLimit +" and  flattype = "+filterSearchEn.FlatType+" ";
            return sql;
        }

        
        


    }
}
