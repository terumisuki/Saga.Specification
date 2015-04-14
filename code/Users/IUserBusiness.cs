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
    public interface IUserBusiness
    {
        IUser Get(int userId);

        IUser Get(string username, string password);


        #region darwin
        double      DarwinScore_Get         (IUser user, ITrack audio);
        double[]    DarwinRange_Get         (IUser user);
        void DarwinPercentage_Set(ISettings settings, int percentage);
        #endregion


        IEnumerable<IMedia> RemoveRepeats(IUser user, IList<IMedia> mediaList);

        IEnumerable<ITrack> AvailableTracksFromSettings_Get(IUser user);

        void RecentlyPlayedMedia_Clear(IUser user);

        IEnumerable<IMedia> RecentlyPlayedMedia(IUser user);

        ITrack HandleUnknownNextAudioToPlay(IUser user);

        IList<ITrack> ApplyWeighting(IList<ITrack> allPossibleAudio, ISettings audioPreferences);

        // returns the new darwin score
        double? AudioSkipped(ITrack audioToSkip, bool blessed, double secondsPlayedBeforeSkipping, IUser currentUser);

        void AudioCompleted(IUser user, int totalMinutes, ITrack audio);

        IList<IUser> GetAll();

        ITrack RandomAudioTrack_Get(IUser user, ITrack track);
        ITrack RandomAudioTrack_Get(int userId);

        void Played(IUser user, IMedia media);

        
        #region include / exclude settings
        void IncludedPartSetting_Add(ISettings settings, IPartBase partToAttach);

        void IncludedPartSetting_Remove(ISettings settings, IPartBase partToUnattach);

        void ExcludedPartSetting_Remove(ISettings settings, IPartBase partToRemove);

        void ExcludedPartSetting_Add(ISettings settings, IPartBase partToExclude);

        void IncludedArtistSetting_Add(ISettings settings, IArtist artistToAttach);

        void IncludedArtistSetting_Remove(ISettings settings, IArtist artistToUnattach);

        void ExcludedArtistSetting_Remove(ISettings settings, IArtist artistToRemove);

        void ExcludedArtistSetting_Add(ISettings settings, IArtist atristToExclude);
        
        void IncludedGenresSetting_Add(ISettings settings, IGenre genreToAttach);

        void IncludedGenresSetting_Remove(ISettings settings, IGenre genreToUnattach);

        void ExcludedGenresSetting_Remove(ISettings settings, IGenre genreToRemove);

        void ExcludedGenresSetting_Add(ISettings settings, IGenre genreToExclude);
        
        void ExcludedSlideShowTagSetting_Remove(ISettings settings, ITag tag);

        void IncludedSlideShowTagSetting_Remove(ISettings settings, ITag tag);

        void IncludedSlideShowTagSetting_Add(ISettings settings, ITag tag);

        void ExcludedSlideShowTagSetting_Add(ISettings settings, ITag tag);
        #endregion


        void NoRepeat_Save(ISettings settings);
        

        #region teach saga
        void PromptForMissingGenres_Save(ISettings settings, bool teachMeGenres);

        void PromptForMissingDarwin_Save(ISettings settings, bool teachDarwin);

        void PromptForMissingParts_Save(ISettings settings, bool p);
        #endregion


        void Played(int userId, int id);

        void LogError(Exception e);
    }
}
