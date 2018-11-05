using singleOrMultipleDropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace singleOrMultipleDropdown.Controllers
{
    public class EmpController : Controller
    {
        // GET: Emp
        public ActionResult AddorEdit(int Id=0)
        {
            SelectedEmployees selectedEmployees = new SelectedEmployees();
            using (DemoContext db = new DemoContext())
            {
                if(Id!=0)
                {
                    selectedEmployees = db.SelectedEmployees.Where(x => x.Id == Id).FirstOrDefault();

                    //This code is for the show the multiple values
                    selectedEmployees.SelectedEmployeeArray = selectedEmployees.SelectedEmployeeID.Split(',').ToArray();
                }
                selectedEmployees.EmployeeCollection = db.Employees.ToList();
            }
                return View(selectedEmployees);
        }

        [HttpPost]
        public ActionResult AddorEdit(SelectedEmployees selected)
        {
            using (DemoContext _context = new DemoContext())
            {
                //Add Multi Selected Value into One string
                selected.SelectedEmployeeID = string.Join(",", selected.SelectedEmployeeArray);

                if(selected.Id==0)
                {

                    _context.SelectedEmployees.Add(selected);
             
                }
                else
                {
                    _context.Entry(selected).State = System.Data.Entity.EntityState.Modified;
                }
                _context.SaveChanges();
            }
                return RedirectToAction("AddorEdit",new { id=0});
        }
    }
}