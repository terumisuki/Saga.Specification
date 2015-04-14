using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Musical
{
    public interface IPiece
    {
        int PieceId { get; set; }
        
        int Number { get; set; }
        
        string Title { get; set; }
        
        string KeySignature { get; set; }
        
        IList<IMovement> Movements { get; set; }
    }
}
