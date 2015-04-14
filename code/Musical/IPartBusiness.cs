using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Musical
{
    public interface IPartBusiness
    {
        IList<IPartBase> GetAll();

        IList<IPartBase> Search(string keyword);
    }
}
