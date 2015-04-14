using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Musical;

namespace Saga.Specification.Interfaces.Artists
{
    public interface IArtistRepository
    {
        IList<IArtist> GetAll();

        IArtist GetById(int artistId);

        int Save(IArtist artist);

        IList<IArtist> Search(string artistName);

        IList<IArtist> GetByName(string keyword);

        IList<IOpus> GetKnownOpuses(int artistId);

        IList<IPiece> GetPieces(int opusId);

        IList<IMovement> GetMovements(int pieceId);

        IList<IPart> GetParts(int movementId);
    }
}
