using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Artists;

namespace Saga.Specification.Interfaces.Musical
{
    public interface IMovementDataManager
    {
        void PartComposer_Add(IMovement movement, IPartBase part, IArtist composer);
    }
}
