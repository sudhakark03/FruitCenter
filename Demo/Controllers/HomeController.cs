using Demo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Fruit()
        {
            return View();
        }
        public ActionResult Index()
        {
            DtpDbContext context = new DtpDbContext();
            List<Fruit> ff = context.FruitTable.ToList();
            int count =0;
            List<List<Fruit>> flist = new List<List<Fruit>>();
            List<Fruit> frt = new List<Fruit>();
            foreach (var fruit in ff)
            {
                count++;
                
                frt.Add(fruit);
                if (count == 3)
                {
                    flist.Add(frt);
                    frt = new List<Fruit>();
                    count = 0;
                }
            }

            return View(flist);
        }
        public ActionResult Main()
        {
            return View();
        }

        public ActionResult Cart()
        {
            DtpDbContext context = new DtpDbContext();
            List<Fruit> ff = context.FruitTable.ToList();
            return View(ff);
        }
    }
     
}
