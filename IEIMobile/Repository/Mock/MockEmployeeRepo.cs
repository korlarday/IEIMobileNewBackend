using IEIMobile.Models;
using IEIMobile.Repository.Interfaces;

namespace IEIMobile.Repository.Mock
{
    public class MockEmployeeRepo : IEmployeeRepo
    {
        public Contribution GetContributionBalance(string pin)
        {
            if(pin == "PEN110007768292"){
                Contribution contribution = new Contribution{
                    Id = 1,
                    EmployeeId = 1,
                    CompCurrentValue = 350000.00M,
                    CompTotalContribution = 350000.00M,
                    CompNetContribution = 200000,
                    CompGrowth = 4000,
                    CompUnitPrice = 190,
                    CompTotalUnits = 2220,
                    VolCurrentValue = 0,
                    VolTotalContribution = 0,
                    VolNetContribution = 0,
                    VolGrowth = 0,
                    VolUnitPrice = 0,
                    VolTotalUnits = 0
                };
                return contribution;
            }
            return null;
        }

        public Employee GetEmployee(string pin)
        {
            if(pin == "PEN110007768292"){
                Employee employee = new Employee{
                    Id = 1,
                    Pin = "PEN110007768292",
                    Title = "Mr",
                    FirstName = "Rilwan",
                    LastName = "Busari",
                    Gender = "Male",
                    Email = "reedwan47@gmail.com",
                    Birthdate = "Jan 26, 1995",
                    Phone = "08148366295",
                    StateOfPosting = "FCT",
                    NkName = "Mumini Alao Busari",
                    NkPhone = "08148366295",
                    NkAddress = "14 Akolade Avenue, Madalla",
                    NkState = "Niger State",
                    NkRelationship = "Father",
                    Employer = "IEI-Anchor Pensions Ltd",
                    EmpAddress = "Area 11, Garki Abuja",
                    EmpState = "FCT"
                };
                return employee;
            }
            return null;
        }
    }
}