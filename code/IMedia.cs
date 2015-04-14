using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces
{
    public interface IMedia : IEqualityComparer<IMedia>
    {
        int MediaId { get; set; }

        Enumerations.MediaTypes MediaType { get; set; }
        
        string MediaFilePath { get; set; }
        
        string Title { get; set; }
        
        IList<ITag> Tags { get; set; }
    }
}
