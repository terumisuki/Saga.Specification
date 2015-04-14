using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Users
{
    public interface IUser
    {
        int UserId { get; set; }
        
        string Username { get; set; }
        
        string Password { get; set; }
        
        ISettings Settings { get; set; }
    }
}
