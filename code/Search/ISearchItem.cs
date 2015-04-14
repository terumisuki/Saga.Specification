using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Interfaces.Search
{
    public interface ISearchItem
    {
        Saga.Specification.Enumerations.SearchItemTypes Type { get; set; }
        
        int Id { get; set; }
        
        string Label { get; set; }
        
        bool? Setting { get; set; }
    }
}
