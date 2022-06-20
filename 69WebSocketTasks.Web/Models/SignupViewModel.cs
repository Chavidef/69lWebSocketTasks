using _69WebSocketTasks.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _69WebSocketTasks.Web.Models
{
    public class SignupViewModel: User
    {
        public string Password { get; set; }
    }
}
