using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Specification
{
    public class Enumerations
    {
        public enum SearchItemTypes
        {
            Genre = 1,
            Artist = 2,
            Part = 3,
            Tag = 4
        };

        public enum MediaTypes
        {
            Audio = 1,
            Image = 2
        };

        public enum SettingVariables
        {
            GradeThreshold = 2,
            NoRepeat = 5,
            TeachGenres = 6,
            TeachGrades = 7,
            TeachPerformers = 8,
            TeachDarwin = 9,
            IncludeGenre = 10,
            ExcludeGenre = 11,
            IncludePart = 12,
            ExcludePart = 13,
            IncludeArtist = 14,
            ExcludeArtist = 15,
            DarwinThreshold = 16
        };
    }
}
