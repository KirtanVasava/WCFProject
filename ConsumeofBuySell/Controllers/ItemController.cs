using ConsumeofBuySell.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ConsumeofBuySell.Controllers
{
    public class ItemController : Controller
    {
        // GET: Item
        public ActionResult getItems()
        {
            Service1Client o = new Service1Client();
            List<Item> li = o.GetItem().ToList();
            ViewBag.List = li;
            return View();
        }

        public ActionResult addItems()
        {
            return View();
        }
        [HttpPost]
        public ActionResult addItems(Item obj)
        {
            Service1Client o = new Service1Client();
            o.Add(obj);
            return View();
        }

        public ActionResult deleteItems()
        {
            return View();

        }
        [HttpPost]
        public ActionResult deleteItems(int id)
        {
            Service1Client o = new Service1Client();
            o.Delete(id);
           
            return View();
            
        }

        public ActionResult updateItems()
        {
            return View();
        }
        [HttpPost]
        public ActionResult updateItems(Item obj)
        {
            Service1Client o = new Service1Client();
            o.Update(obj);
            return View();
        }

    }
}