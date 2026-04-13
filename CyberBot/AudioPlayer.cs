using System.Media;
using System;

class AudioPlayer
{
    public static void PlayGreeting()
    {
        try
        {
            SoundPlayer player = new SoundPlayer("greeting.wav");
            player.PlaySync();
        }
        catch
        {
            Console.WriteLine(" (Voice greeting not found)");
        }
    }
}
