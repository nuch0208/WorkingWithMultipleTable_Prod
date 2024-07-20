using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;

namespace WorkingWithMultipleTable_Prod.Models.ViewModel
{
    public class EmployeeDepartmentSummaryViewModel
    {
        [Key]
        public int EmployeeId { get; set; }
        public int DepartmentID {get; set;}
        public string FirstName { get; set; } = default!;
        public string? MiddleName { get; set; }
        public string? LastName { get; set; }
        public string? Gender { get; set; }
        public string DepartmentName {get ; set ;} = default!;
        public string DepartmentCode {get ;set ;} = default!;
        
    }
    
}