using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Images;

namespace Saga.Specification.Interfaces.PhotoAlbums
{
    public interface IPhotoAlbum
    {
        int AlbumId { get; set; }
        
        string Name { get; set; }
        
        DateTime DateCreated { get; set; }
        
        List<IPhoto> Photos { get; set; }
        
        string Code { get; set; }
    }
}
