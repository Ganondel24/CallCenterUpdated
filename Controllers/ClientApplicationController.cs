using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CallCenter.Data;
using CallCenter.Models;

namespace CallCenter.Controllers
{
    public class ClientApplicationController : Controller
    {
        private readonly ApplicationDBContext _context;

        public ClientApplicationController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: ClientApplications
        public async Task<IActionResult> Index()
        {
              return View(await _context.ClientApplication.ToListAsync());
        }

        // GET: ClientApplications/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ClientApplication == null)
            {
                return NotFound();
            }

            var clientApplication = await _context.ClientApplication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientApplication == null)
            {
                return NotFound();
            }

            return View(clientApplication);
        }

        // GET: ClientApplications/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ClientApplications/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,LastName,Address")] ClientApplication clientApplication)
        {
            if (ModelState.IsValid)
            {
                _context.Add(clientApplication);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(clientApplication);
        }

        // GET: ClientApplications/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ClientApplication == null)
            {
                return NotFound();
            }

            var clientApplication = await _context.ClientApplication.FindAsync(id);
            if (clientApplication == null)
            {
                return NotFound();
            }
            return View(clientApplication);
        }

        // POST: ClientApplications/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,LastName,Address")] ClientApplication clientApplication)
        {
            if (id != clientApplication.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(clientApplication);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ClientApplicationExists(clientApplication.Id))
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
            return View(clientApplication);
        }

        // GET: ClientApplications/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ClientApplication == null)
            {
                return NotFound();
            }

            var clientApplication = await _context.ClientApplication
                .FirstOrDefaultAsync(m => m.Id == id);
            if (clientApplication == null)
            {
                return NotFound();
            }

            return View(clientApplication);
        }

        // POST: ClientApplications/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ClientApplication == null)
            {
                return Problem("Entity set 'ApplicationDBContext.ClientApplication'  is null.");
            }
            var clientApplication = await _context.ClientApplication.FindAsync(id);
            if (clientApplication != null)
            {
                _context.ClientApplication.Remove(clientApplication);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ClientApplicationExists(int id)
        {
          return _context.ClientApplication.Any(e => e.Id == id);
        }
    }
}
