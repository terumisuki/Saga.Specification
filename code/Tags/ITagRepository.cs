using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Tags
{
    public interface ITagRepository
    {
        IList<ITag> GetAll();

        IEqualityComparer<ITag> GetComparer();

        IList<ITag> Search(string keyword);

        ITag GetById(int tagId);

        IList<ITag> GetActiveTags();
    }
}
