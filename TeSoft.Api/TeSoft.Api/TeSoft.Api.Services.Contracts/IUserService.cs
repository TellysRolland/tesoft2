using System.Threading.Tasks;
using TeSoft.Api.Services.Model;

namespace TeSoft.Api.Services.Contracts
{
    public interface IUserService
    {
        Task<User> CreateAsync(User user);

        Task<bool> UpdateAsync(User user);

        Task<bool> DeleteAsync(string id);

        Task<User> GetAsync(string id);
    }
}
