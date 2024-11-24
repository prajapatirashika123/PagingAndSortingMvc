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

        public IActionResult Index(string sortOrder, int? page)
        {
            // Sorting parameters
            ViewBag.NameSortParam = string.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            ViewBag.SalarySortParam = sortOrder == "Salary" ? "salary_desc" : "Salary";

            // Fetch data
            var employees = from e in _context.Employees select e;

            // Sorting logic
            switch (sortOrder)
            {
                case "name_desc":
                    employees = employees.OrderByDescending(e => e.Name);
                    break;

                case "Salary":
                    employees = employees.OrderBy(e => e.Salary);
                    break;

                case "salary_desc":
                    employees = employees.OrderByDescending(e => e.Salary);
                    break;

                default:
                    employees = employees.OrderBy(e => e.Name);
                    break;
            }

            // Pagination
            int pageNumber = page ?? 1;
            int pageSize = 10;
            var pagedList = employees.ToPagedList(pageNumber, pageSize);

            return View(pagedList);
        }
    }
}