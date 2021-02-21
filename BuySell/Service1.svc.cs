using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace BuySell
{
        public class Service1 : IService1
        {
            public void Add(Item obj)
            {
                AppDBContext a1 = new AppDBContext();
                a1.Items.Add(obj);
                a1.SaveChanges();

            }

       

        public void Delete(int id)
            {
            AppDBContext a4 = new AppDBContext();
            var c = (from per in a4.Items where per.id == id select per).First();
            a4.Items.Remove(c);
            a4.SaveChanges();
        }

        public IEnumerable<Item> GetItem()
            {
                List<Item> li = new List<Item>();
                AppDBContext a2 = new AppDBContext();
                li = a2.Items.ToList();
                return li;
            }
        public void Update()
        {

        }

        public void Update(Item obj)
            {
            AppDBContext a3 = new AppDBContext();
            var c = (from per in a3.Items where per.id == obj.id select per).First();

            c.Iname = obj.Iname;
            c.Prize = obj.Prize;
            a3.SaveChanges();
            }

        }
    }