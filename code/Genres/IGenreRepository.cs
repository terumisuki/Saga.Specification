using System.Collections.Generic;
using Saga.Specification.Interfaces.Audio;

namespace Saga.Specification.Interfaces.Genres
{
    public interface IGenreRepository
    {
        IList<IGenre> GetAll();
        
        IGenre GetById(int genreId);

        IList<IGenre> Get(ITrack track);

        IList<IGenre> GetByName(string keyword);
    }
}
