using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Saga.Specification.Interfaces.Artists;
using Saga.Specification.Interfaces.Audio;
using Saga.Specification.Interfaces.Genres;
using Saga.Specification.Interfaces.Musical;


namespace Saga.Specification.Interfaces.Users
{
    public interface IUserRepository
    {
        IUser Get(int userId);
        IUser Get(string username, string password);
        

        #region darwin
        void        DarwinScore_Set         (IUser currentUser, ITrack audioToSkip, double newDarwinScore);
        double      DarwinScore_Get         (IUser user, ITrack track);
        double[]    DarwinRange_Get         (IUser user);
        void        DarwinThreshold_Save    (ISettings settings);
        #endregion


        ITrack RandomAudioTrack_Get(int userId);
        IList<ITrack> RecentlyPlayedTracks_Get(IUser user);

        int? Grade_Get(IUser user, ITrack t);

        void RecentlyPlayedMedia_Clear(IUser user);

        IEnumerable<IMedia> RecentlyPlayedMedia_Get(IUser user);
        
        IList<IUser> GetAll();

        void Played(IUser user, IMedia media);
        void Played(int userId, int mediaId);

        void NoRepeat_Save(ISettings settings);
        
        void DarwinPercentage_Set(ISettings settings, int percentage);


        #region included / excluded settings
        void IncludedArtistSetting_Add(ISettings settings, IArtist artistToAttach);

        void IncludedArtistSetting_Remove(ISettings settings, IArtist artistToUnattach);

        void ExcludedArtistSetting_Remove(ISettings settings, IArtist artistToRemove);

        void ExcludedArtistSetting_Add(ISettings settings, IArtist artistToExclude);

        void IncludedGenresSetting_Add(ISettings settings, IGenre genreToAttach);

        void IncludedGenresSetting_Remove(ISettings settings, IGenre genreToUnattach);

        void ExcludedGenresSetting_Remove(ISettings settings, IGenre genreToRemove);

        void ExcludedGenresSetting_Add(ISettings settings, IGenre genreToExclude);

        void IncludedPartsSetting_Remove(ISettings settings, IPartBase partToUnattach);

        void IncludedPartsSetting_Add(ISettings settings, IPartBase partToAttach);

        void ExcludedPartsSetting_Remove(ISettings settings, IPartBase partToRemove);

        void ExcludedPartsSetting_Add(ISettings settings, IPartBase partToExclude);
        
        void IncludedSlideShowTagSetting_Remove(ISettings settings, ITag tag);

        void IncludedSlideShowTagSetting_Add(ISettings settings, ITag tag);

        void ExcludedSlideShowTagSetting_Remove(ISettings settings, ITag tag);

        void ExcludedSlideShowTagSetting_Add(ISettings settings, ITag tag);
        #endregion


        #region teach saga
        void Settings_PromptForMissingGenres_Save(ISettings settings, bool teachMeGenres);

        void Settings_PromptForMissingDarwin_Save(ISettings settings, bool teachMeDarwin);

        void Settings_PromptForMissingParts_Save(ISettings settings, bool teachMeParts);
        #endregion
    }
}
