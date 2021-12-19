namespace LeaveManagementSystem.Data
{
    // make it a partial class because you dont want anyone to instantiate the base entity by itself
    // it cannot stand on it own
    // standard thing that everyone can inherit from 
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }
    }
}
