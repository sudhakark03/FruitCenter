using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo.Controllers
{
    public class UserController : Controller
    {
        //
        // GET: /User/

        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Register(USER U)
        { 
            if(ModelState.IsValid)
            {
                using (Entities e1 = new Entities())
                {
                    e1.USERs.Add(U);
                    e1.SaveChanges();
                    ModelState.Clear();
                    U = null;
                    ViewBag.Message = "Successfully Registration Done";
                }
            }
            return View(U);
        }
    }
}
