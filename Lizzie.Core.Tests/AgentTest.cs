using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;
using Lizzie.Core;

namespace Lizzie.Core.Tests
{
    public class AgentTest
    {
        [Fact]
        public void ConstructionTestPositive()
        {
            string firstName = "Lizzie";
            string lastName = "Hearts";
            DateTime birthday = DateTime.Today;
            Gender gender = Gender.Female;
            string title = "Miss";
            string moodName = "NormalTestMood";
            Mood mood = new NormalMood(moodName);
            var actual = new Agent(firstName, lastName, birthday, gender, title, mood);
            Assert.NotNull(actual);
            Assert.Equal(actual.FirstName, firstName);
            Assert.Equal(actual.LastName, lastName);
            Assert.Equal(actual.Birthday, birthday);
            Assert.Equal(actual.Gender, gender);
            Assert.Equal(actual.Title, title);
            Assert.Equal(actual.AgentMood.MoodName, moodName);
            Assert.Equal(actual.AgentMood.MoodQuality, MoodQuality.Nuetral);
        }
    }
}
