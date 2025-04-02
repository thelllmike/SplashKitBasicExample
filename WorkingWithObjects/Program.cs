using System;
using SplashKitSDK;

public static class Program
{
    public static void Main(string[] args)
    {
        // Create the window and assign it to the shapesWindow variable
        Window shapesWindow = new Window("Shapes by ...", 800, 600);

        // Clear the window background with white
        shapesWindow.Clear(Color.White);

        // Draw a green ellipse at the bottom (like a hill or ground)
        shapesWindow.FillEllipse(Color.BrightGreen, 0, 400, 800, 400);

        // Draw the house's gray base
        shapesWindow.FillRectangle(Color.Gray, 300, 300, 200, 200);

        // Draw the red triangular roof
        shapesWindow.FillTriangle(Color.Red, 250, 300, 400, 150, 550, 300);

        // Refresh the window to show all drawings
        shapesWindow.Refresh();

        // Keep the window open for 5 seconds
        SplashKit.Delay(5000);
    }
}
