using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.PhotoAlbums
{
    public interface IPhotoAlbumBusiness
    {
        int Save(IPhotoAlbum album);
        
        List<IPhotoAlbum> GetAllAndFullyInflate();
        
        void Delete(int albumId);
        
        void ShowPhotoOnAlbum(IPhotoAlbum _PhotoAlbum, IPhoto photo);
        
        void RemovePhoto(IPhotoAlbum _PhotoAlbum, Images.IImage photo);
        
        IPhoto GetNextPhoto(string albumCode, int userId);
    }
}
