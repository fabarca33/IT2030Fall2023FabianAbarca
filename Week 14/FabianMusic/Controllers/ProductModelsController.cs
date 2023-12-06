using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FabianMusic.Data;
using FabianMusic.Models;

namespace FabianMusic.Controllers
{
    public class ProductModelsController : Controller
    {
        private readonly FabianMusicContext _context;

        public ProductModelsController(FabianMusicContext context)
        {
            _context = context;
        }

        // GET: ProductModels
        public async Task<IActionResult> Index()
        {
              return _context.ProductDb != null ? 
                          View(await _context.ProductDb.ToListAsync()) :
                          Problem("Entity set 'FabianMusicContext.ProductDb'  is null.");
        }

        // GET: ProductModels/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.ProductDb == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductDb
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productModel == null)
            {
                return NotFound();
            }

            return View(productModel);
        }

        // GET: ProductModels/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: ProductModels/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ProductId,ProductName,ProductDescription,ProductImage,ProductPrice")] ProductModel productModel)
        {
            if (ModelState.IsValid)
            {
                _context.Add(productModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(productModel);
        }

        // GET: ProductModels/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.ProductDb == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductDb.FindAsync(id);
            if (productModel == null)
            {
                return NotFound();
            }
            return View(productModel);
        }

        // POST: ProductModels/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ProductId,ProductName,ProductDescription,ProductImage,ProductPrice")] ProductModel productModel)
        {
            if (id != productModel.ProductId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(productModel);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductModelExists(productModel.ProductId))
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
            return View(productModel);
        }

        // GET: ProductModels/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.ProductDb == null)
            {
                return NotFound();
            }

            var productModel = await _context.ProductDb
                .FirstOrDefaultAsync(m => m.ProductId == id);
            if (productModel == null)
            {
                return NotFound();
            }

            return View(productModel);
        }

        // POST: ProductModels/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.ProductDb == null)
            {
                return Problem("Entity set 'FabianMusicContext.ProductDb'  is null.");
            }
            var productModel = await _context.ProductDb.FindAsync(id);
            if (productModel != null)
            {
                _context.ProductDb.Remove(productModel);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProductModelExists(int id)
        {
          return (_context.ProductDb?.Any(e => e.ProductId == id)).GetValueOrDefault();
        }
    }
}
