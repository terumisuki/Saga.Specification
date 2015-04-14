using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Genres;
using Saga.Specification.Interfaces.Musical;


namespace Saga.Specification.Interfaces.Audio
{
    public interface ITrack : IMedia
    {
        IList<IGenre> Genres { get; set; }

        IList<IPart> Parts { get; set; }
        
        int Volume { get; set; }
        
        int AlbumId { get; set; }       // id of the album the track is on
        
        int TrackNumber { get; set; }   // the track number on the album
        
        bool IsEmpty { get; }           // true - a track is populated
                                        //      false - no track is populated
    }
}
