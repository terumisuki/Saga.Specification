using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Saga.Specification.Interfaces.Genres;
using Saga.Specification.Interfaces.Musical;


namespace Saga.Specification.Interfaces.Audio
{
    public interface ITrackRepository
    {
        void Save(ITrack task);
        
        void Delete(ITrack task);
        
        IEnumerable<ITrack> GetAll();
        
        ITrack GetById(int taskId);
        
        ITrack GetByName(string name);
        
        ITrack GetByFilePath(string trackFilePath);
        
        void Genre_Add(ITrack track, IGenre genre);
        
        void Genre_Remove(ITrack track, IGenre genre);

        IList<ITrack> GetFromAlbum(IAlbum album);

        void PerformanceAdd(ITrack track, Artists.IArtist artist, IPartBase part);
    }
}
