using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using serviceCar.Models.DbModels;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace serviceCar.Controllers
{
    public class VehicleController : Controller
    {
        private readonly servicecarContext _context;
        private readonly IWebHostEnvironment _hostEnvironment;

        public VehicleController(servicecarContext context, IWebHostEnvironment hostEnvironment)
        {
            _context = context;
            this._hostEnvironment = hostEnvironment;
        }

        // GET: Vehicle
        public async Task<IActionResult> Index()
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {
                var vehicle = await _context.Vehicle
                .Include(v => v.VehicleConductorNavigation)
                .FirstOrDefaultAsync(m => m.VehicleConductor == HttpContext.Session.GetInt32("iduser"));
                return RedirectToAction("Details", "Conductor" , new { id = vehicle.IdVehicle });
            
            }
            
            var servicecarContext = _context.Vehicle.Include(v => v.VehicleConductorNavigation);
            return View(await servicecarContext.ToListAsync());
        }

        // GET: Vehicle/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            var id0 = id;
            if(HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {
                var vehicle0 = await _context.Vehicle
                .Include(v => v.VehicleConductorNavigation)
                .FirstOrDefaultAsync(m => m.VehicleConductor == HttpContext.Session.GetInt32("iduser"));
                id0 = vehicle0.IdVehicle;
            }

            if (id0 == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .Include(v => v.VehicleConductorNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicle == id0);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // GET: Vehicle/Create
        public IActionResult Create()
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }
            ViewData["VehicleConductor"] = new SelectList(_context.Conductor, "User", "Adress");
            return View();
        }

        // POST: Vehicle/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VehicleConductor,Description,InUse")] Vehicle vehicle, IFormFile img)
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }
            if (ModelState.IsValid)
            {
                string path = Path.Combine(_hostEnvironment.WebRootPath, "img");
                string ext = Path.GetExtension(img.FileName);
                var result = _context.Vehicle;
                string new_name;
                if (result.Any()) { new_name = _context.Vehicle.Max(u => u.IdVehicle) + 1 + ext; }
                else new_name = img.FileName;

                if (img.Length > 0)
                {
                    string filePath = Path.Combine(path, new_name);
                    using (Stream fileStream = new FileStream(filePath, FileMode.Create))
                    {
                        await img.CopyToAsync(fileStream);
                    }

                    vehicle.Img = new_name;
                    _context.Add(vehicle);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));

                }
            }
            ViewData["VehicleConductor"] = new SelectList(_context.Conductor, "User", "User", vehicle.VehicleConductor);
            return View(vehicle);
        }

        // GET: Vehicle/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle.FindAsync(id);
            if (vehicle == null)
            {
                return NotFound();
            }
            ViewData["VehicleConductor"] = new SelectList(_context.Conductor, "User", "Adress", vehicle.VehicleConductor);
            return View(vehicle);
        }

        // POST: Vehicle/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdVehicle,VehicleConductor,Img,Description,InUse")] Vehicle vehicle)
        {
            if (id != vehicle.IdVehicle)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(vehicle);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VehicleExists(vehicle.IdVehicle))
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
            ViewData["VehicleConductor"] = new SelectList(_context.Conductor, "User", "Adress", vehicle.VehicleConductor);
            return View(vehicle);
        }

        // GET: Vehicle/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (HttpContext.Session.GetInt32("iduser") == 0)
            {
                return RedirectToAction("Login", "Home");
            }
            else if (HttpContext.Session.GetString("isadmin") != "True")
            {

                return RedirectToAction("Profil", "Conductor", new { Id = HttpContext.Session.GetInt32("iduser") });
            }

            if (id == null)
            {
                return NotFound();
            }

            var vehicle = await _context.Vehicle
                .Include(v => v.VehicleConductorNavigation)
                .FirstOrDefaultAsync(m => m.IdVehicle == id);
            if (vehicle == null)
            {
                return NotFound();
            }

            return View(vehicle);
        }

        // POST: Vehicle/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var vehicle = await _context.Vehicle.FindAsync(id);
            _context.Vehicle.Remove(vehicle);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VehicleExists(int id)
        {
            return _context.Vehicle.Any(e => e.IdVehicle == id);
        }
    }
}
