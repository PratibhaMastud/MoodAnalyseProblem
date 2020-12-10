using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;

namespace MoodAnalyseTest
{
    [TestClass]
    public class UnitTest1
    {
        private readonly MoodAnalyser moodAnalyser;
        public UnitTest1()
        {
            moodAnalyser = new MoodAnalyser();
        }

        [TestMethod]
        public void givenMood_IsHappy_ShouldReturnHappyMood()
        {
            var result = moodAnalyser.analyseMood("Happy");
            Assert.AreEqual("HAPPY", result);
        }
        [TestMethod]
        public void givenMood_IsSad_ShouldReturnSadMood()
        {
            var result = moodAnalyser.analyseMood("Sad");
            Assert.AreEqual("SAD", result);
        }
    }
}
