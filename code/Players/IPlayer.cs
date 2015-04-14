using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.DirectX.AudioVideoPlayback;

namespace Saga.Specification.Interfaces.Players
{
    public interface IPlayer
    {
        void Play(Microsoft.DirectX.AudioVideoPlayback.Audio audioFile);
        
        void Stop(Microsoft.DirectX.AudioVideoPlayback.Audio audioFile);
        
        void Pause(Microsoft.DirectX.AudioVideoPlayback.Audio audioFile);
        
        void FastForward(Microsoft.DirectX.AudioVideoPlayback.Audio audioFile);
        
        void Rewind(Microsoft.DirectX.AudioVideoPlayback.Audio audioFile);
    }
}
