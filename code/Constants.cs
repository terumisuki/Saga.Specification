using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification
{
    public partial class Constants : Private
    {
        #region Constants that use Private values
        public static int USER_ID_OF_DEFAULT_USER = Constants.USER___2;

        // Todo: Replace with DB driven users.
        public static class User1
        {
            public const int Id = Constants.USER___1;
            public const string Code = Constants.AUTH_STRING___1;
            public static string Email = Constants.EMAIL___1;
            public static string Name = Constants.DISPLAY_NAME___1;
        }
        public static class User2
        {
            public const int Id = Constants.USER___2;
            public const string Code = Constants.AUTH_STRING___2;
            public static string Email = Constants.EMAIL___2;
            public static string Name = Constants.DISPLAY_NAME___2;
        }
        public static class User3
        {
            public const int Id = Constants.USER___3;
            public const string Code = Constants.AUTH_STRING___3;
            public static string Email = Constants.EMAIL___3;
            public static string Name = Constants.DISPLAY_NAME___3;
        }
        public static class User4
        {
            public const int Id = Constants.USER___4;
            public const string Code = Constants.AUTH_STRING___4;
            public static string Email = Constants.EMAIL___4;
            public static string Name = Constants.DISPLAY_NAME___4;
        }
        public static class User5
        {
            public const int Id = Constants.USER___5;
            public const string Code = Constants.AUTH_STRING___5;
            public static string Email = Constants.EMAIL___5;
            public static string Name = Constants.DISPLAY_NAME___5;
        }

        public static string ImagesDirectoryPath = Constants.IMAGES_DIRECTORY_PATH___INTERNAL;
        public static string ImagesDirectoryPath__InternetFacing = Constants.IMAGES_DIRECTORY_PATH___INTERNET_FACING;
        public static string AudioDirectoryPath = Constants.AUDIO_DIRECTORY_PATH;
        public static string ImagesWebSiteUrl = Constants.IMAGES_WEB_SITE_URL;
        public static string SagaEmailAddress = Constants.SAGA_EMAIL_ADDRESS;
        public static string SagaSmtpUsername = Constants.SAGA_SMTP_USERNAME;
        public static string SagaSmtpPassword = Constants.SAGA_SMTP_PASSWORD;
        public static string SagaSmtpUrl = Constants.SAGA_SMTP_URL;
        public static string SagaPhotoAlbumEmailSubject = Constants.SAGA_PHOTO_ALBUM_EMAIL_SUBJECT;
        #endregion


        #region darwin
        public static int DARWIN__INITIAL_SCORE = 0;
        public static int DARWIN__PENALTY_SCORE = -360;     // 6 minute penalty
        public static int DARWIN__SURVIVAL_SCORE = 180;     // 3 minute bonus
        #endregion


        static public class UserVariableKeys
        {
            static public string DarwinPercentage = "DARWIN_PERCENT";
            static public string DarwinThreshold = "DARWIN_THRESHOLD";
            static public string GradeThreshold = "FILTER_GRADE";
            static public string NoRepeat = "NO_REPEAT_TRACK";
            static public string ExcludeGenre = "EXCLUDE_GENRE";
            static public string IncludeGenre = "INCLUDE_GENRE";
            public static string PromptForMissingGrades = "TEACH_GRADES";
            public static string PromptForMissingGenres = "TEACH_GENRES";
            public static string PromptForMissingDarwin = "TEACH_DARWIN";
            public static string IncludeArtist = "INCLUDE_ARTIST";
            public static string ExcludeArtist = "EXCLUDE_ARTIST";
            public static string ExcludePart = "EXCLUDE_PART";
            public static string IncludePart = "INCLUDE_PART";
            public static string ExcludeSlideShowTag = "EXCLUDE_SLIDE_SHOW_TAG";
            public static string IncludeSlideShowTag = "INCLUDE_SLIDE_SHOW_TAG";
            public static string PromptForMissingParts = "TEACH_PARTS";
        }

        static public class Parts
        {
            static public int AllParts__PartId = 13;
        }

        static public class MediaTypeIds
        {
            static public int Track = 1;
            static public int Image = 2;
        }
    }
}
