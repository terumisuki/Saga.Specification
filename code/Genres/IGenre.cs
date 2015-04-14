using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Genres
{
    public interface IGenre //: IEqualityComparer<IGenre>
    {
        int GenreId { get; set; }

        string Name { get; set; }
    }
}
