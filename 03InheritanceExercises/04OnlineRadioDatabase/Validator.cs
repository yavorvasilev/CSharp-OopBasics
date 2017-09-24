namespace _04OnlineRadioDatabase
{
    using System;

    public static class Validator
    {
        public static string ValidateArtistName(string name)
        {
            if (name.Length < 3 || name.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            else
            {
                return name;
            }
        }
        public static string ValidateSongName(string name)
        {
            if (name.Length < 3 || name.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            else
            {
                return name;
            }
        }
        public static int ValidateMinutes(int minutes)
        {
            if (minutes < 0 || minutes > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            else
            {
                return minutes;
            }
        }
        public static int ValidateSeconds(int seconds)
        {
            if (seconds < 0 || seconds > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            else
            {
                return seconds;
            }
        }
    }
}
