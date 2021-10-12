using AMS_Models.Models;
using AMS_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMS_BAL
{
    public class BAL_Bill
    {
        private Igeneric<Bill> db;
        public BAL_Bill(Igeneric<Bill> dbb)
        {
            db = dbb;
        }
        public IEnumerable<Bill> GetAllUserBill()
        {
            return db.getall();
        }
        public Bill ShowBillById(int UID)
        {
            return db.getbyid(UID);
        }
        public Bill AddUserBillDetails(Bill data)
        {
            return db.insertrecord(data);
        }
        public Bill UpdateCustomer(Bill updateuser)
        {
            return db.updaterecord(updateuser);
        }
    }
}
