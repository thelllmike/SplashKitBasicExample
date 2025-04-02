using System;
using SplashKitSDK;

public class Program
{
    public static void Main()
    {
        // Print a message to the console
        Console.WriteLine("Hello World");

        // Create a small window
        Window w = new Window("My First Program", 200, 100);

        // Draw text onto the window
        w.DrawText("Hello World", Color.Black, 10, 45);

        // Refresh the window at 60 FPS
        w.Refresh(60);

        // Delay for 5 seconds before closing
        SplashKit.Delay(5000);
    }
}
