using RentalHouseManagementSys.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalHouseManagementSys.repository
{
    public abstract class NotificationRepository
    {
        private string CredentialsId { get; set; }
        private List <Notification> notificationList;

       
        protected DataAccess Da { get; set; }
        protected DataSet Ds { get; set; }

        public NotificationRepository(string credentailsId)
        {
            this.CredentialsId = credentailsId;
            this.notificationList = new List<Notification>();
            
        }
        private void ConvertToEntityList()
        {
            for(int i =0; i<this.Ds.Tables[0].Rows.Count;i++)
            {
                this.notificationList.Add(new Notification());
                this.notificationList.ElementAt(i).Id = this.Ds.Tables[0].Rows[i]["id"].ToString();
                this.notificationList.ElementAt(i).Sender = this.Ds.Tables[0].Rows[i]["sender"].ToString();
                this.notificationList.ElementAt(i).Receiver = this.Ds.Tables[0].Rows[i]["receiver"].ToString();
                this.notificationList.ElementAt(i).AdId = this.Ds.Tables[0].Rows[i]["adid"].ToString();
                this.notificationList.ElementAt(i).Status = this.Ds.Tables[0].Rows[i]["status"].ToString();
            }
        }

        public virtual List<Notification> GenerateNotificationQuery(string sql)
        {
            Console.WriteLine(sql);
            this.Da = new DataAccess();
            this.Ds = this.Da.ExecuteQuery(sql);
            Console.WriteLine("rows count " +this.Ds.Tables[0].Rows.Count);
            this.ConvertToEntityList();
            return this.notificationList;
        }

        public void UpdateNotification(string sql)
        {
            Console.WriteLine(sql);
            try
            {
                this.Da = new DataAccess();
                this.Da.ExecuteUpdateQuery(sql);

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            


        }
       
        
    }
}
