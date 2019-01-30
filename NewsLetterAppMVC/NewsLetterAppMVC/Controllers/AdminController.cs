using NewsLetterAppMVC.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsLetterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            using (NewsLetterEntities db = new NewsLetterEntities())
            {
                //var signups = db.SignUpsses.Where( x=> x.Removed == null).ToList();
                var signups = (from c in db.SignUpsses
                               where c.Removed == null
                               select c).ToList();
                List<SignUpVm> signupVMS = new List<SignUpVm>();
                foreach (var signup in signups)
                {
                    var signupVm = new SignUpVm();
                    signupVm.Id = signup.Id;
                    signupVm.FirstName = signup.FirstName;
                    signupVm.LastName = signup.LastName;
                    signupVm.EmailAddress = signup.EmailAddress;
                    signupVMS.Add(signupVm);

                }
                return View(signupVMS);
            }

        }

        public ActionResult Unsubscribe(int id)
        {
            using(NewsLetterEntities db = new NewsLetterEntities)
            {
                var signup = db.SignUpsses.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}
