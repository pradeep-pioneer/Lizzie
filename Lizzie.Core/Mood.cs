using Lizzie.Core.Interfaces;
using System;

namespace Lizzie.Core
{
    public abstract class Mood : IMood
    {

        #region [ Key Constants ]

        public const string KEY_NAME_BYE = "BYE";
        public const string KEY_NAME_GREETING = "GREETING";
        public const string KEY_NAME_INTRO = "INTRO";
        public const string KEY_NAME_MEET = "MEET";

        #endregion

        #region [ Properties ]
        private string moodName;
        public virtual string MoodName
        {
            get { return moodName; }
            protected set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentNullException("MoodName cannot be null, empty or whitespaces!");
                else
                    moodName = value;
            }
        }

        protected MoodQuality moodQuality;
        public virtual MoodQuality MoodQuality
        {
            get { return moodQuality; }
            protected set { moodQuality = value; }
        }

        #endregion

        #region [ VirtualMethods ]

        public abstract string GetGreeting();
        public abstract string GetBye();
        public abstract string GetIntroduction();
        public abstract string GetMeetingSalutation();

        #endregion

        #region [ Construction ]

        protected Mood(string name, MoodQuality quality = MoodQuality.Nuetral)
        {
            moodName = name;moodQuality = quality;
        }

        #endregion
    }
}
