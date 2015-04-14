using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Musical
{
    public interface IOpus
    {
        int OpusId { get; set; }
        
        string Title { get; set; }
        
        int Number { get; set; }
        
        int YearReleased { get; set; }
        
        IList<IPiece> Pieces { get; set; }
    }
}
