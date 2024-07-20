using System.Threading.Tasks.Dataflow;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WorkingWithMultipleTable_Prod.Data;
using WorkingWithMultipleTable_Prod.Models.ViewModel;

namespace WorkingWithMultipleTable_Prod.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly ApplicationContext context;

        public EmployeeController(ApplicationContext context)
        {
            this.context = context;
        }
        public IActionResult Index()
        {
            //using merge model
            // EmployeeDepartmentListViewModel emp=new EmployeeDepartmentListViewModel();
            // var empData=context.Employees.ToList();
            // var depData =context.Departments.ToList();
            // emp.employees = empData;
            // emp.departments = depData;
            

            // EmployeeDepartmentListViewModel emp=new EmployeeDepartmentListViewModel(); 
            // var empData=context.Employees.FromSqlRaw("Select * from Employees").ToList();
            // var depData=context.Departments.FromSqlRaw("Select * from Departments").ToList();
            // emp.employees = empData;
            // emp.departments=depData;



            //using Join Model
            // var data = (from e in context.Employees
            //            join d in context.Departments
            //            on e.DepartmentId equals d.DepartmentId
            //            select new EmployeeDepartmentSummaryViewModel
            //            {
            //                 EmployeeId=e.EmployeeId,
            //                 FirstName=e.FirstName,
            //                 MiddleName=e.LastName,
            //                 Gender=e.Gender,
            //                 DepartmentCode=d.DepartmentCode,
            //                 DepartmentName=d.DepartmentName
            //            }).ToList();

            

            // var data = context.employeeDepartmentSummaryViewModels.FromSqlRaw
            // ("select e.EmployeeId,e.FirstName,e.MiddleName,e.LastName,e.Gender,d.DepartmentId,d.DepartmentCode,d.DepartmentName from Employees e join Departments d on e.DepartmentId =d.DepartmentId");
           
            
            //Using procedure get the data
            // var empData = context.Employees.FromSqlRaw("exec GetEmployee");
            // var depData = context.Departments.FromSqlRaw("exec GetDepartments");


            var result = context.employeeDepartmentSummaryViewModels.FromSqlRaw("exec GetEmployeeDepartments").ToList();

            return View(result);
        }
    }
}