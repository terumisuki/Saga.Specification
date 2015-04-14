using System.Collections.Generic;
using Saga.Specification.Interfaces;
using Saga.Specification.Interfaces.Audio;
using Saga.Specification.Interfaces.Musical;

namespace Saga.Specifications.Interfaces.Parts
{
    public interface IPartRepository
    {
        IList<IPartBase> GetAll();

        IList<IPartBase> GetByName(string keyword);

        IPartBase GetById(int partId);

        IList<IPart> GetKnownPartsForTheTrack(ITrack track);
    }
}
