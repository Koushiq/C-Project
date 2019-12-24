using RentalHouseManagementSys.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalHouseManagementSys.repository
{
    public class PaymentRepository : Repository
    {
        private string CredentialsId { get; set; }
        private List<PaymentEntity> paymentList;
        public PaymentRepository(string credentialsId) : base(credentialsId)
        {
            this.CredentialsId = credentialsId;
            this.paymentList = new List<PaymentEntity>();
        }
       
        protected override void ConvertToEntityList(string sql)
        {
            base.ConvertToEntityList(sql);
            for (int i = 0; i < this.Ds.Tables[0].Rows.Count;i++)
            {
                paymentList.Add(new PaymentEntity());
                paymentList.ElementAt(i).PaymentId = this.Ds.Tables[0].Rows[i]["paymentid"].ToString();
                paymentList.ElementAt(i).AdId = this.Ds.Tables[0].Rows[i]["adid"].ToString();
                paymentList.ElementAt(i).BankAccLandlord = this.Ds.Tables[0].Rows[i]["bankacclandlord"].ToString();
                paymentList.ElementAt(i).BankAccTenant = this.Ds.Tables[0].Rows[i]["bankacctenant"].ToString();
                paymentList.ElementAt(i).LastPaymentDate = this.Ds.Tables[0].Rows[i]["lastpaymentdate"].ToString();
                paymentList.ElementAt(i).NextPaymentDate = this.Ds.Tables[0].Rows[i]["nextpaymentdate"].ToString();
                paymentList.ElementAt(i).AdminApproved = this.Ds.Tables[0].Rows[i]["adminapproved"].ToString();
            }
        }


        public  List<PaymentEntity> GenerateRentQuery(string sql)
        {
            this.ConvertToEntityList(sql);
            return this.paymentList;
        }
        

    }
}
