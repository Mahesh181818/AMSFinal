using AMS_Models.Models;
using AMS_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMS_BAL
{
    public class BAL_Announcement
    {
        private Igeneric<Announcement> db;
        public BAL_Announcement(Igeneric<Announcement> dbb)
        {
            db = dbb;
        }
        public IEnumerable<Announcement> GetAnnouncements()
        {
            return db.getall();
        }
        public Announcement GetUserdetailbyID(int UID)
        {
            return db.getbyid(UID);
        }
        public Announcement AddAnnouncement(Announcement data)
        {
            return db.insertrecord(data);
        }
        public Announcement UpdateCustomer(Announcement updateuser)
        {
            return db.updaterecord(updateuser);
        }
    }
}
