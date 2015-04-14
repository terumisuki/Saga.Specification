using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Tags
{
    public interface ITagBusiness
    {
        IList<ITag> GetAll();

        IEqualityComparer<ITag> GetComparer();

        IList<ITag> Search(string keywords);

        IList<ITag> GetActiveTags();
    }
}
