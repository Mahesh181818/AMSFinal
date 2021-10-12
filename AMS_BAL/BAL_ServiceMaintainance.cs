using AMS_Models.Models;
using AMS_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMS_BAL
{
    public class BAL_ServiceMaintainance
    {
        private Igeneric<ServiceMaintanence> db;
        public BAL_ServiceMaintainance(Igeneric<ServiceMaintanence> dbb)
        {
            db = dbb;
        }
        public IEnumerable<ServiceMaintanence> GetAllServices()
        {
            return db.getall();
        }
        public ServiceMaintanence GetServiceById(int UID)
        {
            return db.getbyid(UID);
        }
        public ServiceMaintanence AddServiceMaintenance(ServiceMaintanence data)
        {
            return db.insertrecord(data);
        }
        public ServiceMaintanence UpdateService(ServiceMaintanence updateuser)
        {
            return db.updaterecord(updateuser);
        }

        public void DeleteCustomer(int UID)
        {
            db.deletecustomer(UID);
        }
    }
}
