using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalHouseManagementSys.repository
{
    public abstract class Repository
    {
        private string CredentailsId { get; set; }
        protected DataAccess Da { get; set; }
        protected DataSet Ds { get; set; }
        public Repository(string credentialsId)
        {
            this.Da = new DataAccess();
            this.CredentailsId = credentialsId;
        }

        public void Update(string sql)
        {
            Console.WriteLine("this is the query ==== " + sql);
            try
            {
                this.Da.ExecuteUpdateQuery(sql);
                Console.WriteLine("query executed successfully");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                
            }
            
        }
        protected virtual void ConvertToEntityList(string sql)
        {
            try
            {
                this.Ds = this.Da.ExecuteQuery(sql);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
        
    }
}
