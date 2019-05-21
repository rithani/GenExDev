using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenEx.Controllers
{
    public class MonthEndHistoryController : Controller
    {
        // GET: MonthEndHistory
        public ActionResult MonthEndHistoryEarned()
        {
            //return MEH homepage
            return View();
        }
        public ActionResult MonthEndHistoryEarnedDelete()
        {
            return View();
        }
        
        public ActionResult MonthEndHistoryDeductible()
        {
            return View();
        }
        public ActionResult MonthEndHistoryDeductibleDelete()
        {
            return View();
        }
       
        public ActionResult MonthEndHistoryCommission()
        {
            return View();
        }
        public ActionResult MonthEndHistoryCommissionDelete()
        {
            return View();
        }
        public ActionResult MonthEndHistoryCommissionDownload()
        {
            return View();
        }
        
    }
}