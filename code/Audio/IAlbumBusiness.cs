using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Audio;

namespace Saga.Specification.Interfaces.Audio
{
    public interface IAlbumBusiness
    {
        IAlbum Get();

        IAlbum Get(int albumId);

        IAlbum Save(IAlbum album);

        void Track_Attach(ITrack track);

        IList<ITrack> GetTracks(IAlbum _Album);
    }
}
