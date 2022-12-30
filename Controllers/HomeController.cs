using IndexDBApp.Models;
using IndexDBApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;

namespace IndexDBApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(string data)
        {
            var list= JsonConvert.DeserializeObject<List<EmployeeModel>>(data);
            EmployeeModel Emp = new EmployeeModel();
            try
            {
                EmployeeRepository EmpRepo = new EmployeeRepository();
                var isSuccess=EmpRepo.AddUpdateEmployee(list);
                if (isSuccess)
                {
                    return Json("ok");
                }

                return Json("failed");
            }
            catch
            {
                return View();
            }
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}