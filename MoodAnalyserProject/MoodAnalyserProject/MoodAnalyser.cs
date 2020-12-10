using System;

namespace MoodAnalyserProject
{
    public class MoodAnalyser
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser");
        }
        public string analyseMood(string mood)
        {
            if (mood.Equals("Happy"))
            {
                return "HAPPY";
            }
            else
            {
                return "SAD";
            }
        }
    }
}
