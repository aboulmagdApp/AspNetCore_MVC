using aspnetcoreNewWeb.Models;
using Microsoft.AspNetCore.Mvc;

namespace aspnetcoreNewWeb.Controllers
{
    public class HomeController : Controller
    {
        private IEmployeeRepository _employeeRepository;
        public HomeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }
        public string Index()
        {
            return _employeeRepository.GetEmployee(1).Name;
        }
        public ViewResult Details()
        {
            Employee model = _employeeRepository.GetEmployee(1);
            ViewBag.Employee = model;
            ViewBag.pageTitle = "Employee Details";
            return View();
        }
    }
}