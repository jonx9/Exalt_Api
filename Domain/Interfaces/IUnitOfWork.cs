using Domain.Models.Store;
using Domain.Models.Role;
using Domain.Models.User;
using Domain.Models.Sales;

namespace Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<Role> RoleRepository { get; }
        IRepository<User> UserRepository { get; }
        IRepository<Store> StoreRepository { get; }
        IRepository<Sales> SalesRepository { get; }
        void SaveChanges();
        Task SaveChangesAsync();
        //string GetDbConnection();
    }
}
