using SampleBackGroundApp.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleBackGroundApp.Security
{
    public class UserContext : IUserContext 
    {
        private readonly int _userId;

        public int UserId { get; private set; }

        public UserContext() 
        {
           
        }

        public void SetUserId(int userId)
        {
           this.UserId = userId;
        }
    }
}
