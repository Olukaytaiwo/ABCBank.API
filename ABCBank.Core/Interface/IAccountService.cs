using ABCBank.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Core
{
    public interface IAccountService
    {
        Task<Response<ApplicationUser>> RegisterUser(RegistrationRequest request);
        Task<Response<List<ApplicationUser>>> FetchAllUsers();
    }
}
