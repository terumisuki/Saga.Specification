using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Musical;
using Saga.Specification.Interfaces.Users;

namespace Saga.Specification.Interfaces.Artists
{
    public interface IArtistBusiness
    {
        IList<IArtist> GetAll();

        IList<IArtist> Search(string keyword);
        
        IList<IOpus> GetKnownOpuses(int artistId);
        
        IList<IPiece> GetPieces(int opusId);

        IList<IMovement> GetMovements(int pieceId);

        IList<IPart> GetParts(int movementId);
    }
}
