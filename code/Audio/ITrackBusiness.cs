using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Artists;
using Saga.Specification.Interfaces.Genres;

namespace Saga.Specification.Interfaces.Audio
{
    public interface ITrackBusiness
    {
        ITrack Get(string trackFilePath);

        ITrack Get(int trackId);

        void Genre_Remove(ITrack track, IGenre genre);

        void Genre_Add(ITrack track, IGenre genre);

        void PerformanceAdd(ITrack track, IArtist artist, IPartBase part);
    }
}
