using PagingAndSorting.Entities;
using X.PagedList;

namespace PagingAndSorting.ViewModel
{
    public class EmployeeViewModel
    {
        public int CurrentPage { get; set; }
        public IPagedList<EmployeeMaster> Employees { get; set; }
        public int TotalCount { get; set; }
    }
}