using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces
{
    public interface IPartBase
    {
        int PartId { get; set; }
        
        string Name { get; set; }
    }
}
