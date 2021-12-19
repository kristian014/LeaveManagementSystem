using Microsoft.AspNetCore.Identity;

namespace LeaveManagementSystem.Data
{

    // create an empployee class that inherits from Identity User 
    // i.e copy all the classes, properties of identity User 
    // now we will need to inform the application know the Employee should be the user class it should be using
    public class Employee : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TaxId { get; set; }

        public DateTime DateOfBirth { get; set; }

        public DateTime DateJoined { get; set; }
    }
}
