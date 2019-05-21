using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenEx.Controllers
{
    public class MonthEndManagementController : Controller
    {// to add Finalize 
        // GET: MonthEndManagement
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MonthEndManagementEarned()
        {
            return View();
        }
       
        public ActionResult MonthEndManagementDownload()
        {
            return View();
        }
        public ActionResult MonthEndManagementDeductible()
        {
            return View();
        }
        public ActionResult MonthEndManagementCommission()
        {
            return View();
        }

        public ActionResult EarnedReload()
        {
            return View();
        }
        public ActionResult DeductibleReload()
        {
            return View();
        }

        public ActionResult CommissionReload()
        {
            return View();
        }
        public ActionResult EarnedDelete()
        {
            return View();
        }
        public ActionResult DeductibleDelete()
        {
            return View();
        }

        public ActionResult CommissionDelete()
        {
            return View();
        }

    }
}
