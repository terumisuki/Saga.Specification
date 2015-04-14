using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Images;

namespace Saga.Specification.Interfaces.PhotoAlbums
{
    public interface IPhoto : IImage
    {
        string EnglishCaption { get; set; }
        
        string JapaneseCaption { get; set; }
    }
}
