using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.PhotoAlbums;

namespace Interfaces.Models
{
    public class PhotoModel
    {
        public string EnglishCaption { get; set; }

        public string JapaneseCaption { get; set; }
        
        public int MediaId { get; set; }
    }
}
