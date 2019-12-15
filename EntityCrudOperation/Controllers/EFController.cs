using EntityCrudOperation.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EntityCrudOperation.Controllers
{
    public class EFController : Controller
    {
        EmployeeDBContext db = new EmployeeDBContext();
        // GET: EF
        public ActionResult Index()
        {
            


            return View(db.Employees.ToList());
        }
    }
}