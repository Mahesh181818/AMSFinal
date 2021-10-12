using AMS_Models.Models;
using AMS_Repository;
using System;
using System.Collections.Generic;

namespace AMS_BAL
{
    public class BAL_UserRegistration
    {
        private Igeneric<UserRegistration> db;
        public BAL_UserRegistration(Igeneric<UserRegistration> dbb)
        {
            db = dbb;
        }
        public IEnumerable<UserRegistration> GetUserdetails()
        {
            return db.getall();
        }
        public UserRegistration GetUserdetailbyID(int UID)
        {
            return db.getbyid(UID);
        }
        public UserRegistration AddCustomer(UserRegistration data)
        {
            return db.insertrecord(data);
        }
        public UserRegistration UpdateCustomer(UserRegistration updateuser)
        {
            return db.updaterecord(updateuser);
        }

        public void DeleteCustomer(int UID)
        {
            db.deletecustomer(UID);
        }
    }
}
