using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PagingAndSorting.Entities;
using PagingAndSorting.Models;
using X.PagedList.Extensions;

namespace PagingAndSorting.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EmployeeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index(int? page)
        {
            int pageNumber = page ?? 1;  // Default to the first page if not specified
            int pageSize = 10;          // Number of items per page

            // Fetch data and paginate
            var products = _context.Employees.OrderBy(p => p.Name).ToPagedList(pageNumber, pageSize);

            return View(products);
        }
    }
}