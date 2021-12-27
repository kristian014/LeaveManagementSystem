namespace LeaveManagementSystem.Contracts
{

    // for more information on implementing repository 
    //
    /*
       https://docs.microsoft.com/en-us/aspnet/mvc/overview/older-versions/getting-started-with-ef-5-using-mvc-4/implementing-the-repository-and-unit-of-work-patterns-in-an-asp-net-mvc-application

    Repository patterns are intended to create an abstration layer between data access layer and 
    the business logic layer of an application.

    implementing these patterns can help insulate your application 
    from changes in the data store and can facilitate automated unit testing or tdd


    NOTE: The IGenericRepository WILL HELP US facilitate more than one file class types e.g leavetype, 
    leaveallocation etc
   */
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        // specify method that needs to be used 

        // because our function in the controller is asyn , we need to make our methods asyn 

        Task<TEntity> GetAsync(int? id);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> AddAsync(TEntity entity);
        Task<bool> Exists(int id);
        Task DeleteAsync(int id);
        Task UpdateAsync(TEntity entity);


    }
}
