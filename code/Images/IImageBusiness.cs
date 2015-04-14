using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification.Interfaces.Images
{
    public interface IImageBusiness
    {
        IImage Get(IImage image);

        void Tag(IImage image, ITag tag);

        void UnTag(IImage image, ITag tag);

        IList<IImage> GetImagesForSlideShow(int userId, IList<ITag> includedTags, IList<ITag> excludedTags);

        IList<IImage> GetImagesForSlideShow(int userid);

        void ClearNoRepeatList(int userid);

        IImage Get(int id);

        IList<IImage> GetRandomPhotoFromPhotoAlbum(int userid, string albumCode);

        void LogError(string error);

        void LogError(Exception ex);
    }
}
