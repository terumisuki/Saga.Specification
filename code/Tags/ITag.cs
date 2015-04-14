using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces
{
    public interface ITag: IComparable
    {
        int TagId { get; set; }

        string Label { get; set; }
    }
}
