namespace _04OnlineRadioDatabase
{
    public class Song
    {
        private string artist;
        private string nameOfSong;
        private int minutes;
        private int seconds;

        public Song(string artist, string nameOfSong)
        {
            this.Artist = artist;
            this.NameOfSong = nameOfSong;
        }

        public string Artist
        {
            get { return this.artist; }
            set
            {
                Validator.ValidateArtistName(value);
                this.artist = value;
            }
        }
        public string NameOfSong
        {
            get { return this.nameOfSong; }
            set
            {
                Validator.ValidateSongName(value);
                this.nameOfSong = value;
            }
        }
        public int Minutes
        {
            get { return this.minutes; }
            set
            {
                Validator.ValidateMinutes(value);
                this.minutes = value;
            }
        }
        public int Seconds
        {
            get { return this.seconds; }
            set
            {
                Validator.ValidateSeconds(value);
                this.seconds = value;
            }
        }

        public int GetSumOfSeconds()
        {
            return this.Minutes * 60 + this.Seconds;
        }
    }
}
