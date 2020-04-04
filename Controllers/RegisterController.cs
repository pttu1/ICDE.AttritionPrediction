using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ICDE.CompareProducts.Data;
using ICDE.CompareProducts.Models;

namespace ICDE.CompareProducts.Controllers
{
    public class RegisterController : Controller
    {
        private readonly MvcEmployeeContext _context;
        public RegisterController(MvcEmployeeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        // GET: Registration/Create
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(RegModel model)
        {
            OrgUserMaster userMaster = new OrgUserMaster();
            userMaster.User_id = model.User_id;
            userMaster.User_firstname = model.User_firstname;
            userMaster.User_lastname = model.User_lastname;
            userMaster.User_email = model.User_email;
            userMaster.Company_Fk_Name = model.Company_Fk_Name;
            userMaster.Role_Fk_id = model.Role_Fk_id;
            if (model.Password == model.ConfirmPassword)
            {
                userMaster.Password = model.Password;
            }
            //userMaster.Create_date = System.DateTime.Now;
            try
            {
                // TODO: Add insert logic here
                if (ModelState.IsValid)
                {
                    _context.Add(userMaster);
                    _context.SaveChanges();
                    return RedirectToAction("Home");
                }
                return RedirectToAction("Home");
            }
            catch (Exception ex)
            {
                return View();
            }
        }

    }
}