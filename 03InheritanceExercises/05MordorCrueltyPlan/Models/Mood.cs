﻿namespace _05MordorCrueltyPlan.Models
{
    public abstract class Mood
    {
        public Mood(string moodName)
        {
            this.MoodName = moodName;
        }

        public string MoodName { get; set; }

        public override string ToString()
        {
            return this.MoodName;
        }
    }
}
