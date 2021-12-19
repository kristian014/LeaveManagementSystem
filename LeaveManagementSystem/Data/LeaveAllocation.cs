using System.ComponentModel.DataAnnotations.Schema;

namespace LeaveManagementSystem.Data
{
    public class LeaveAllocation : BaseEntity
    {
       
        public int NumberOfDays { get; set; }

        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }

        // remember we need to allocate this leavetype to give it the number of days 
        public string EmployeeId { get; set; }
       
    }
}
