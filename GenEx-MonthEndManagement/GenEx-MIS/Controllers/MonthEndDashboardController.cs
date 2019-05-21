using GenEx_MIS.util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GenEx.Controllers
{
    public class MonthEndDashboardController : Controller
    {
        // GET: MonthEndDashboard
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult MonthEndDashboardHomePage()
        {//return grid view of MonthEndDashBoard
           // Log.Info("logging-started");
            return View();
        }
        public ActionResult MonthEndDashboardBegin()
        {
            return View();
        }
        public ActionResult MonthEndDashboardManage()
        {
            return View();
        }
        public ActionResult MonthEndDashboardApprove()
        {
            return View();
        }
        public ActionResult MonthEndDashboardClose()
        {
            return View();
        }
        public ActionResult GridBack()
        {
            return View();
        }
        public ActionResult Download()
        {
            return View();
        }
    }
}