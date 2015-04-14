using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Errors
{
    public interface IErrorRepository
    {
        void LogError(Exception e);

        void LogError(string error);
    }
}
