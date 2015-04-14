using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Artists
{
    public interface IArtist
    {
        int ArtistId { get; set; }

        string Name { get; set; }
    }
}
