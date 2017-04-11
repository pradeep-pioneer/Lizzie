namespace Lizzie.Core.Interfaces
{
    public interface IMood
    {
        MoodQuality MoodQuality { get; }
        string MoodName { get; }
        string GetGreeting();
        string GetBye();
        string GetIntroduction();
        string GetMeetingSalutation();
    }
}