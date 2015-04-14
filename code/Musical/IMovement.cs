using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Musical
{
    public interface IMovement
    {
        int MovementId { get; set; }
        
        int Number { get; set; }
        
        string Title { get; set; }
        
        IPiece ParentPiece { get; set; }
        
        IList<IPart> Parts { get; set; }
    }
}
