using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Audio
{
    public interface IAlbum
    {
        int AlbumId { get; set; }

        string Title { get; set; }
        
        IList<ITrack> Tracks { get; set; }
    }
}
