using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Images;

namespace Saga.Specification.Interfaces.PhotoAlbums
{
    public interface IPhotoAlbumRepository
    {
        int Save(IPhotoAlbum album);
        
        List<IPhotoAlbum> GetAll();
        
        void Delete(int albumId);
        
        void ShowPhotoOnAlbum(int albumId, int photoId, string english, string japanese);
        
        void RemovePhoto(int albumId, int photoId);
        
        List<IPhoto> GetPhotos(int albumId);
        
        IPhoto GetNextPhoto(string albumCode, int userId);
    }
}
