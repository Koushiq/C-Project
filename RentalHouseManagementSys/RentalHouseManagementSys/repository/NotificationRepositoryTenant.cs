using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RentalHouseManagementSys.Entity;
namespace RentalHouseManagementSys.repository
{
    public class NotificationRepositoryTenant : NotificationRepository
    {
        private string CredentailsId;
        private List<Notification> notificationList;

        public NotificationRepositoryTenant(string credentialsId) : base(credentialsId)
        {
            this.CredentailsId = credentialsId;
        }

        public override List<Notification> GenerateNotificationQuery(string sql)
        {
            this.notificationList = base.GenerateNotificationQuery(sql);
            return this.notificationList;
        }
         

    }
}
