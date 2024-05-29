using ExpenseTrackerNew.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace ExpenseTrackerNew.Controllers
{
    public class TransactionController : Controller
    {
        private readonly AppDBContext _context;

        public TransactionController(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var transactions = await _context.Transactions.Include(t => t.Category).ToListAsync();
            return View(transactions);
        }

        public IActionResult AddOrEdit(int id = 0)
        {
            ViewBag.Categories = _context.Categories.ToList();
            if (id == 0)
                return View(new Transaction());
            else
                return View(_context.Transactions.Find(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddOrEdit([Bind("TransactionId,CategoryId,Amount,Note,Date")] Transaction transaction)
        {
            //if (ModelState.IsValid)
            //{
            if (transaction.TransactionId == 0)
            {
                _context.Add(transaction);
            }
            else
            {
                _context.Update(transaction);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
            //}
            //ViewBag.Categories = _context.Categories.ToList();
            //return View(transaction);
        }

    }
}