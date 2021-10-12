using AMS_Models.Models;
using AMS_Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace AMS_BAL
{
    public class BAL_Property
    {
        private Igeneric<Property> db;
        public BAL_Property(Igeneric<Property> dbb)
        {
            db = dbb;
        }
        public IEnumerable<Property> GetAllProperty()
        {
            return db.getall();
        }
        public Property GetPropertyById(int UID)
        {
            return db.getbyid(UID);
        }
        public Property AddPropertyDetails(Property data)
        {
            return db.insertrecord(data);
        }
        public Property UpdateProperty(Property updateuser)
        {
            return db.updaterecord(updateuser);
        }
    }
}
