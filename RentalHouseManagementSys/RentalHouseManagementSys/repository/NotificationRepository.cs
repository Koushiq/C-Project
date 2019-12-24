using RentalHouseManagementSys.Entity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentalHouseManagementSys.repository
{
    public class NotificationRepository : Repository
    {
        private List <Notification> notificationList;
        public NotificationRepository(string credentailsId):base(credentailsId)
        {
            this.notificationList = new List<Notification>();   
        }
        protected override void ConvertToEntityList(string sql)
        {
            base.ConvertToEntityList(sql);
            for(int i =0; i<base.Ds.Tables[0].Rows.Count;i++)
            {
                this.notificationList.Add(new Notification());
                this.notificationList.ElementAt(i).Id = this.Ds.Tables[0].Rows[i]["id"].ToString();
                this.notificationList.ElementAt(i).Sender = this.Ds.Tables[0].Rows[i]["sender"].ToString();
                this.notificationList.ElementAt(i).Receiver = this.Ds.Tables[0].Rows[i]["receiver"].ToString();
                this.notificationList.ElementAt(i).AdId = this.Ds.Tables[0].Rows[i]["adid"].ToString();
                this.notificationList.ElementAt(i).Status = this.Ds.Tables[0].Rows[i]["status"].ToString();
            }
        }

        public List<Notification> GenerateNotificationQuery(string sql)
        {
            Console.WriteLine(sql);
            this.ConvertToEntityList(sql);
            return this.notificationList;
        }       
        
    }
}
