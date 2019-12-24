using RentalHouseManagementSys.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalHouseManagementSys.repository
{
    public class AgreementRepository : Repository
    {
        private List<AgreementEntity> agreementList;
        public AgreementRepository(string credentialsId) : base(credentialsId)
        {
            this.agreementList = new List<AgreementEntity>();
        }
        protected override void ConvertToEntityList(string sql)
        {
            base.ConvertToEntityList(sql);
            for (int i = 0; i < base.Ds.Tables[0].Rows.Count; i++)
            {
                this.agreementList.Add(new AgreementEntity());
                this.agreementList.ElementAt(i).adid = this.Ds.Tables[0].Rows[i]["adid"].ToString();
                this.agreementList.ElementAt(i).landlordid = this.Ds.Tables[0].Rows[i]["landlordid"].ToString();
                this.agreementList.ElementAt(i).tenantid = this.Ds.Tables[0].Rows[i]["tenantid"].ToString();
                this.agreementList.ElementAt(i).rent = this.Ds.Tables[0].Rows[i]["rent"].ToString();
                this.agreementList.ElementAt(i).paymentdate = this.Ds.Tables[0].Rows[i]["paymentdate"].ToString();
            }
        }
        public List<AgreementEntity> GenerateAgreementQuery(string sql)
        {
            Console.WriteLine(sql);
            this.ConvertToEntityList(sql);
            return this.agreementList;
        }

    }
}
