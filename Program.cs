using System;
using NAudio.Wave;

class Program
{
    static void Main()
    {
        // Initialize the Audio File Reader for MP3
        using (var audioFile = new AudioFileReader("C:\\Users\\emman\\Downloads\\Music\\Chris-Brown-Tempo-Audio-(NaijaRemix.Com).mp3"))
        using (var outputDevice = new WaveOutEvent())
        {
            // Set the output device and play the file
            outputDevice.Init(audioFile);
            outputDevice.Play();

            Console.WriteLine("Playing music. Press any key to stop...");
            Console.ReadKey();

            // Stop the music
            outputDevice.Stop();
        }
    }
}
