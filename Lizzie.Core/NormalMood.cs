using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lizzie.Core
{
    public class NormalMood : Mood
    {
        private Dictionary<string, string[]> moodStrings;
        public NormalMood(string name, MoodQuality quality = MoodQuality.Nuetral) : base(name, quality)
        {
            MoodName = name;
            MoodQuality = quality;
            moodStrings = new Dictionary<string, string[]>();
            string[] byeStrings = new string[] { "bye now", "see you", "bye bye", "until next time" };
            string[] greetingStrings = new string[] { "hello", "hey", "hi" };
            string[] introductionStrings = new string[] { "my name is {0} and I would be helping you today.", "I am {0}, I here to help" };
            string[] meetingSalutationStrings = new string[] { "nice to meet you", "hello", "good to know you" };
            moodStrings.Add(KEY_NAME_BYE, byeStrings);
            moodStrings.Add(KEY_NAME_GREETING, greetingStrings);
            moodStrings.Add(KEY_NAME_INTRO, introductionStrings);
            moodStrings.Add(KEY_NAME_MEET, meetingSalutationStrings);
        }

        public override string GetBye()
        {
            Random random = new Random(DateTime.Now.Second);
            var maxValue = moodStrings[KEY_NAME_BYE].Length;
            return moodStrings[KEY_NAME_BYE][random.Next(maxValue)];
        }

        public override string GetGreeting()
        {
            Random random = new Random(DateTime.Now.Second);
            var maxValue = moodStrings[KEY_NAME_GREETING].Length;
            return moodStrings[KEY_NAME_GREETING][random.Next(maxValue)];
        }

        public override string GetIntroduction()
        {
            Random random = new Random(DateTime.Now.Second);
            var maxValue = moodStrings[KEY_NAME_INTRO].Length;
            return moodStrings[KEY_NAME_INTRO][random.Next(maxValue)];
        }

        public string GetIntroduction(string agentName)
        {
            Random random = new Random(DateTime.Now.Second);
            var maxValue = moodStrings[KEY_NAME_INTRO].Length;
            return string.Format(moodStrings[KEY_NAME_INTRO][random.Next(maxValue)],agentName);
        }

        public override string GetMeetingSalutation()
        {
            Random random = new Random(DateTime.Now.Second);
            var maxValue = moodStrings[KEY_NAME_MEET].Length;
            return moodStrings[KEY_NAME_MEET][random.Next(maxValue)];
        }
    }
}
