# Audio Player Console Application

This is a simple console application that plays an audio file (e.g., `.mp3`) using the **NAudio** library in C#. The application will play the audio in a loop until the user presses a key to stop it.

## Features:
- Plays `.mp3` files.
- Loops the audio until the user stops it.
- Supports basic console interaction (press any key to stop music).

## Requirements:
- .NET Core or .NET 5/6/7+ (Windows, Linux, macOS).
- The **NAudio** library.

## Setup Instructions:

1. **Create a new .NET console application**:
    ```bash
    dotnet new console -n AudioPlayerApp
    cd AudioPlayerApp
    ```

2. **Install NAudio via NuGet**:
    ```bash
    dotnet add package NAudio
    ```

3. **Add the following code to your `Program.cs`**:

    ```csharp
    using System;
    using NAudio.Wave;

    class Program
    {
        static void Main()
        {
            // Initialize the Audio File Reader for MP3
            using (var audioFile = new AudioFileReader("C:\\Path\\To\\Your\\Music.mp3"))
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
    ```

    - Replace `"C:\\Path\\To\\Your\\Music.mp3"` with the actual path to your `.mp3` file.

4. **Run the application**:
    ```bash
    dotnet run
    ```

5. **Stopping the Music**:
    - Press any key to stop the music and exit the application.

## Notes:
- This example uses the `NAudio` library, which supports `.mp3`, `.wav`, and other audio formats.
- The audio will play asynchronously in the background and will stop once a key is pressed.
