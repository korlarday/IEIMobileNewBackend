using System.Threading.Tasks;
using IEIMobile.Models;
using IEIMobile.Models.Dtos;
using Microsoft.Identity.Client;

namespace IEIMobile.Repository.Interfaces
{
    public interface IUserRepo
    {
         Task<string> GetToken(User user);
         bool Authenticate(User user);
         Task<AuthDataDto> SignUserIn(User user);
    }
}