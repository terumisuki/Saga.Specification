using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using Saga.Specification.Interfaces.Musical;
using Saga.Specification.Interfaces.Genres;
using Saga.Specification.Interfaces.Artists;


namespace Saga.Specification.Interfaces.Users
{
    public interface ISettings
    {
        int SettingId { get; set; }
        
        int UserId { get; set; }
        
        int? GradeThreshold { get; set; }
        IDictionary<int, int> TrackGrades { get; set; }
                
        bool NoRepeat { get; set; }

        #region parts
        bool FilterParts { get; set; }
        IList<IPartBase> IncludedParts { get; set; }
        IList<IPartBase> ExcludedParts { get; set; }
        #endregion

        #region genres
        bool FilterGenres { get; set; }
        IList<IGenre> AttachedGenres { get; set; }
        IList<IGenre> UnattachedGenres { get; set; }
        #endregion

        #region artists
        bool FilterArtists { get; set; }
        IList<IArtist> AttachedArtists { get; set; }
        IList<IArtist> UnattachedArtists { get; set; }
        #endregion

        #region slide show tags
        IList<ITag> IncludedSlideShowTags { get; set; }
        IList<ITag> ExcludedSlideShowTags { get; set; }
        #endregion

        #region darwin
        double? DarwinThreshold { get; set; }
        IDictionary<int, double> DarwinScores { get; set; }
        #endregion

        #region teach saga
        bool PromptForMissingGenres { get; set; }
        bool PromptForMissingPerformers { get; set; }
        bool PromptForMissingGrades { get; set; }
        bool PromptForMissingDarwin { get; set; }
        bool PromptForMissingParts { get; set; }
        #endregion

        bool FilterPerformers { get; set; }
    }
}
