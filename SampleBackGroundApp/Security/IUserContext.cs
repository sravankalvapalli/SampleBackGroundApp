using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackGroundApp.Security
{
    public interface IUserContext
    {
        public int UserId { get;  }

        public void SetUserId(int userId);
    }
}
