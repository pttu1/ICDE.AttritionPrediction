using System;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using ICDE.CompareProducts.Data;
using ICDE.CompareProducts.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace ICDE.CompareProducts.Controllers
{
    public class RegModelsController : Controller
    {
        private readonly MvcEmployeeContext _context;

        public RegModelsController(MvcEmployeeContext context)
        {
            _context = context;
        }

        // GET: RegModels
        public async Task<IActionResult> Index()
        {
            return View(await _context.RegModel.ToListAsync());
        }

        // GET: RegModels/Create
        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        // POST: RegModels/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("User_id,User_firstname,User_lastname,User_email,Company_Fk_Name,Role_Fk_id,Years_At_Company,Password,ConfirmPassword")] RegModel regModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(regModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(regModel);
        }

        // GET: RegModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var regModel = await _context.RegModel.FindAsync(id);
            if (regModel == null)
            {
                return NotFound();
            }
            return View(regModel);
        }

        // POST: RegModels/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("User_id,User_firstname,User_lastname,User_email,Company_Fk_Name,Role_Fk_id,Years_At_Company,Password,ConfirmPassword")] RegModel regModel)
        {
            if (id != regModel.User_id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(regModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RegModelExists(regModel.User_id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(regModel);
        }
        private bool RegModelExists(int id)
        {
            return _context.RegModel.Any(e => e.User_id == id);
        }

    }
}
