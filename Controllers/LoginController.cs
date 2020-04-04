using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using ICDE.CompareProducts.Data;
using ICDE.CompareProducts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ICDE.CompareProducts.Controllers
{
    public class LoginController : Controller
    {
        private readonly MvcEmployeeContext _context;

        public LoginController(MvcEmployeeContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    var userist = _context.Login.ToList();
                    var user = userist.FirstOrDefault(x => x.User_email == model.email && x.Password == model.password);
                    LogMaster logMaster = new LogMaster();
                    SessionData sData = new SessionData();
                    if (user != null)
                    {
                        ViewBag.UserName = user.User_firstname + " " + user.User_lastname;
                        sData.UserId = user.User_id;
                        sData.UserFname = user.User_firstname;
                        sData.UserLname = user.User_lastname;
                        sData.CompanyId = user.Company_Fk_Id;
                        sData.UserEmail = user.User_email;
                        Session["Logindata"] = sData;
                        logMaster.Log_Msg = "login by user into system ";
                        logMaster.User_Fk_id = user.User_id;
                        logMaster.Create_date = System.DateTime.Now;
                        db.LogMasters.Add(logMaster);
                        Session["Logindata"] = sData;
                        ViewBag.message = "Successful login";
                        db.SaveChanges();
                        return RedirectToAction("Index", "Admin");
                    }
                    else
                    {
                        ModelState.AddModelError("email", "Invalid login details");
                    }
                }
                catch (Exception e)
                {
                    ModelState.AddModelError("email", e.Message);
                }
            }
            return View();
        }
        //Get: Logout
        [Route("logout")]
        public ActionResult Logout()
        {
            Session.Clear();
            return RedirectToAction("Index", "Login");
        }

    }
}