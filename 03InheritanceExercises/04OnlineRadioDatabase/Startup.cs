namespace _04OnlineRadioDatabase
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var playlist = new List<Song>();

            var numberOfSongs = int.Parse(Console.ReadLine());
          
            for (int s = 0; s < numberOfSongs; s++)
            {
                try
                {
                    var songInfo = Console.ReadLine().Split(';');
                    if (songInfo.Length != 3)
                    {
                        throw new ArgumentException("Invalid song.");
                    }
                    var artistName = songInfo[0];
                    var songName = songInfo[1];
                    var songLenght = songInfo[2];

                    var song = new Song(artistName, songName);

                    var minutesAndSeconds = songLenght.Split(':');
                    if (minutesAndSeconds.Length != 2)
                    {
                        throw new ArgumentException("Invalid song length.");
                    }
                    else
                    {
                        int min, sec;
                        if (int.TryParse(minutesAndSeconds[0], out min) && int.TryParse(minutesAndSeconds[1], out sec))
                        {
                            song.Minutes = min;
                            song.Seconds = sec;
                        }
                        else
                        {
                            throw new ArgumentException("Invalid song length.");
                        }
                    }
                    playlist.Add(song);
                    Console.WriteLine("Song added.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine($"Songs added: {playlist.Count}");
            var sumOfSeconds = playlist.Sum(s => s.GetSumOfSeconds());

            var time = TimeSpan.FromSeconds(sumOfSeconds);
            var str = time.ToString(@"h\:m\:s").Split(':');

            Console.WriteLine($"Playlist length: {str[0]}h {str[1]}m {str[2]}s");
        }
    }
}
