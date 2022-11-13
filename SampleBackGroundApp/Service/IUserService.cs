using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackGroundApp.Service
{
    public interface IUserService
    {
        Task<string> GetUserName();
    }
}
