using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Genres
{
    public interface IGenreBusiness
    {
        IList<IGenre> GetAll();

        IList<IGenre> Search(string keyword);
    }
}
