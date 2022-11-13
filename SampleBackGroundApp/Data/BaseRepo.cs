using SampleBackGroundApp.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackGroundApp.Data
{
    public abstract class BaseRepo
    {
        protected readonly IUserContext _userContext;
        private readonly string _connString;

        public BaseRepo(IUserContext userContext)
        {
            
            _userContext = userContext;
            _connString = userContext.UserId == 0 ? "" : "test conn";
        }

        protected T? GetData<T>(T input)
        {
            if(_connString == "")
            {
                return default;
            }
            else
            {
                return input;
            }
        }
    }
}
