using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Audio
{
    public interface IAlbumRepository
    {
        IAlbum Get();

        IAlbum Get(int albumId);

        void Save(IAlbum album);
    }
}
