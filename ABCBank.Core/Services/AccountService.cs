using ABCBank.Data;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABCBank.Core
{
    public class AccountService : IAccountService
    {
        private UserManager<ApplicationUser> _userManager = null;
        private readonly DataContext _db;

        public AccountService(
            UserManager<ApplicationUser> userManager,
             DataContext db
            )
        {
            _userManager = userManager;
            _db = db;
        }
        public async Task<Response<ApplicationUser>> RegisterUser(RegistrationRequest request)
        {
            try
            {
                Random rd = new Random();

                var user = new ApplicationUser()
                {
                    UserName = request.UserName,
                    CreatedOn = DateTime.Now,
                    EmailConfirmed = true,
                    CustomerNumber = rd.Next(100, 200).ToString()
                };

                //add user
                var addUserResult = await _userManager.CreateAsync(user);
                await _userManager.AddPasswordAsync(user, request.Password);

                if (!addUserResult.Succeeded)
                    return await Task.FromResult(new Response<ApplicationUser>
                    {
                        Message = "User Creation Failed"
                    });

                if (addUserResult.Succeeded)
                {
                    return await Task.FromResult(new Response<ApplicationUser>
                    {
                        Success = true,
                        Data = user,
                        Message = "User Creation Successfull"
                    });
                }



                return await Task.FromResult(new Response<ApplicationUser>
                {
                    Message = "User Creation Failed"
                });
            }
            catch (Exception ex)
            {

                // LOG EXCEPTION

                return await Task.FromResult(new Response<ApplicationUser>
                {
                    Message = "User Creation Failed"
                });
            }
        }

        public async Task<Response<List<ApplicationUser>>> FetchAllUsers()
        {
            try
            {
                var list = _db.Users.ToList();

                if (list.Count!=0)
                    return await Task.FromResult(new Response<List<ApplicationUser>>
                    {
                        Success = true,
                        Data = list,
                        Message = "Successfull"
                    });


                return await Task.FromResult(new Response<List<ApplicationUser>>
                {
                        Message = "No User Found"
                    });
            }
            catch (Exception ex)
            {

                // LOG EXCEPTION

                return await Task.FromResult(new Response<List<ApplicationUser>>
                {
                    Message = "An Error Occured"
                });
            }
        }

    }
}
