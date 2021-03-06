using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProject;

namespace MoodAnalyseTest
{
    [TestClass]
    public class UnitTest1
    {

        /// <summary>
        /// This Test case call AnalyseMood() method will return SAD message contains Sad
        /// </summary>
        [TestMethod]
        public void GivenSadMessage_WhenSad_ShouldReturnSAD()
        {
            //Arrange
            string Expected = "SAD";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Sad Mood");
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }

        /// <summary>
        /// This Test case call AnalyseMood() method will return HAPPY when message contains Happy
        /// </summary>
        [TestMethod]
        public void GivenHappyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            string Expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Happy Mood");
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }

        /// <summary>
        /// This Test case call AnalyseMood() method will return HAPPY when Any mood message is given
        /// </summary>
        [TestMethod]
        public void GivenAnyMessage_WhenAnyMood_ShouldReturnHAPPY()
        {
            //Arrange
            string Expected = "HAPPY";
            MoodAnalyser moodAnalyser = new MoodAnalyser("I am in Any Mood");
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }

        /// <summary>
        /// This Test call ensure AnalyseMood() method will return HAPPY when Any mood message is given
        /// </summary>
        [TestMethod]
        [DataRow("null")]
        public void GivenNULLMessage_WhenANULL_ShouldReturnHAPPY(string message)
        {
            //Arrange
            string Expected = "Happy";
            MoodAnalyser moodAnalyser = new MoodAnalyser(message);
            //Act
            string result = moodAnalyser.AnalyseMood();
            //Assert
            Assert.AreEqual(Expected, result);
        }

        /// <summary>
        /// This Test call ensure when given empty message will throw an exception
        /// </summary>
        [TestMethod]
        [DataRow("")]
        public void GivenEmptyMessage_WhenEmpty_ShouldThrowException(string message)
        {
            try
            {
                //Arrange
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string result = moodAnalyser.AnalyseMood();
                //Assert
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual("Mood should not be empty", e.Message);
            }
        }

        /// <summary>
        /// UC4 Expected to return the MoodAnalyser Object by creating object using MoodAnalyser Factory with default Constructor
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject()
        {
            object expected = new MoodAnalyser();
            object obj = MoodAnalyserFactory.CreateMoodAnalyse("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        /// <summary>
        /// UC5 Expected to return the MoodAnalyser Object by creating object using Parameterized Constructor
        /// </summary>
        [TestMethod]
        public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject_UsingParameterizdConstructor()
        {
            object expected = new MoodAnalyser("HAPPY");
            object obj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor("MoodAnalyserProject.MoodAnalyser", "MoodAnalyser", "HAPPY");
            expected.Equals(obj);
        }

        /// <summary>
        /// UC6 Given Happy Should Return Happy.
        /// </summary>
        [TestMethod]
        public void GiveHappyMoodShouldReturnHappy()
        {
            string expected = "HAPPY";
            string mood = MoodAnalyserFactory.InvokeAnalyseMood("Happy", "AnalyseMood");
            Assert.AreEqual(expected, mood);
        }

        /// <summary>
        /// UC7 Given Happy Should Return Happy By Using dynamic Field
        /// </summary>
        [TestMethod]
        public void Given_HAPPYMessag_WithReflector_should_ReturnHAPPY()
        {
            string result = MoodAnalyserFactory.SetField("HAPPY", "message");
            Assert.AreEqual("HAPPY", result);
        }
    }
}

