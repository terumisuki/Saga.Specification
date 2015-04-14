using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces;
using Saga.Specification.Interfaces.Audio;
using Saga.Specification.Interfaces.Genres;
using Saga.Specification.Interfaces.Musical;

namespace Interfaces.Audio
{
    public class TrackModel
    {
        public int MediaId { get; set; }
        public string MediaFilePath { get; set; }
    }
}
