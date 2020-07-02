using IEIMobile.Models;

namespace IEIMobile.Repository.Interfaces
{
    public interface IEmployeeRepo
    {
        Employee GetEmployee(string pin);
        Contribution GetContributionBalance(string pin);
    }
}