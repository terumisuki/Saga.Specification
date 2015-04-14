using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Images
{
    public interface IImageRepository
    {
        IImage Get(IImage image);
        
        IImage Save(IImage image);
        
        void TagRemove(IImage image, ITag tag);
        
        void TagAdd(IImage image, ITag tag);
        
        IList<IImage> GetImagesForSlideShow(int userId, IList<ITag> includedTags, IList<ITag> excludedTags);
        
        IList<IImage> GetImagesForSlideShow(int userid);
        
        void ClearNoRepeatList(int userid);
        
        IImage Get(int id);
        
        IList<IImage> GetRandomPhotoFromPhotoAlbum(int userid, string albumCode);
    }
}
