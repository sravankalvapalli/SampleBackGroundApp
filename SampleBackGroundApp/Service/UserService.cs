using SampleBackGroundApp.Data;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackGroundApp.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepo _userRepo;

        public UserService([NotNull] IUserRepo userRepo)
        {
            _userRepo = userRepo;
        }
        public async Task<string> GetUserName()
        {
            return await Task.Run(() => { return _userRepo.GetUserName(); }); ;
        }
    }
}
