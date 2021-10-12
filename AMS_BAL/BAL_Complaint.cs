using AMS_Models.Models;
using AMS_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMS_BAL
{
    public class BAL_Complaint
    {
        private Igeneric<Complaint> db;
        public BAL_Complaint(Igeneric<Complaint> dbb)
        {
            db = dbb;
        }
        public IEnumerable<Complaint> GetComplaintDetails()
        {
            return db.getall();
        }
        public Complaint GetComplaintByID(int UID)
        {
            return db.getbyid(UID);
        }
        public Complaint AddComplaint(Complaint data)
        {
            return db.insertrecord(data);
        }
        public Complaint UpdateComplaint(Complaint updateuser)
        {
            return db.updaterecord(updateuser);
        }
    }
}
