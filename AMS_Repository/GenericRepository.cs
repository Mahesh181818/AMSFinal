using AMS_Models.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace AMS_Repository
{
    public class GenericRepository<T> : Igeneric<T> where T : class
    {
        private ApartmentManagementContext db;
        private DbSet<T> entities = null;


        public GenericRepository(ApartmentManagementContext dbb)
        {
            db = dbb;
            entities = db.Set<T>();
        }
        public  IEnumerable<T> getall()
        {
            return entities.ToList();
        }
        public T getbyid(object UID)
        {
            T data = db.Find<T>(UID);
            return data;
        }
        public T insertrecord(T data)
        {
            db.Entry(data).State = EntityState.Added;
            db.SaveChanges();
            return data;
        }

        public T updaterecord(T data)
        {
            db.Entry(data).State = EntityState.Modified;
            db.SaveChanges();
            return data;
        }

        public void deletecustomer(int UID)
        {
            /*T data = db.Find<T>(UID);
            db.SaveChanges();*/
            SqlParameter p0 = new SqlParameter("@id", UID);
            db.Database.ExecuteSqlRaw($"exec pro_DeleteUserProfileById @id", p0);
            // Entities.FromSqlInterpolated("exec DeleteDeptDetailsByID @Dept_ID", p0);
        }
    }

}
