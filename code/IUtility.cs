using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces
{
    public interface IUtility
    {
        object GetRandom<T>(IList<T> pool);

        int GetUserIdFromCode(string auth);

        string GetUserCodeFromId(int userId);
    }
}
