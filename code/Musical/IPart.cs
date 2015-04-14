using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Artists;

namespace Saga.Specification.Interfaces.Musical
{
    public interface IPart
    {
        IPartBase Part { get; set; }
        
        IArtist Composer { get; set; }
        
        IArtist Performer { get; set; }
        
        int MovementId { get; set; }
    }
}
