using CoreLayer.Enum.BusinessEnums;
using CoreLayer.Models.ProductTechnology.ProductActions;
using System.ComponentModel.DataAnnotations;

namespace CoreLayer.Models.Business
{
    public class EmployeeShift
    {
        [Key]
        public int EmployeeShiftId { get; set; }
        public DateTime? StartTime { get; set; } 
        public DateTime? EndTime { get; set; }  
        public EmployeeShiftStatus ?Status { get; set; } 
        public int? EmployeeId { get; set; }
        public int? BranchId { get; set; }
        public int ?Flag { get; set; }
    
    }
}
