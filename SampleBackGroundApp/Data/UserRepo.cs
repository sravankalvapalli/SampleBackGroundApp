using SampleBackGroundApp.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackGroundApp.Data
{
    public class UserRepo : BaseRepo, IUserRepo
    {
        private readonly int _userid;

        public UserRepo(IUserContext userContext) : base(userContext)
        {
            
        }

        public string GetUserName()
        {
           return $"{ GetData("test") ?? ""}_{_userContext.UserId.ToString()}"  ;
        }
    }
}
