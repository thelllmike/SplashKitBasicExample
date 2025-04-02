using System;
using SplashKitSDK;

public class PCAndMonitor
{
    public static void Main()
    {
        // Create a window to draw in
        Window window = new Window("PC and Monitor", 800, 600);

        // Main loop: run until the user closes the window
        while (!SplashKit.WindowCloseRequested(window))
        {
            // Process events (e.g., closing the window)
            SplashKit.ProcessEvents();

            // Clear the screen to white
            SplashKit.ClearScreen(Color.White);

            //------------------------------------------------
            // Draw the monitor
            //------------------------------------------------
            // 1) Outer monitor frame (black border)
            window.FillRectangle(Color.Black, 100, 100, 300, 200);

            // 2) Screen area (dark gray)
            window.FillRectangle(Color.DarkGray, 110, 110, 280, 180);

            // 3) Monitor stand (black rectangle under screen)
            window.FillRectangle(Color.Black, 220, 300, 60, 50);

            // 4) Base for the stand (thin rectangle)
            window.FillRectangle(Color.Black, 200, 350, 100, 10);

            //------------------------------------------------
            // Draw the PC tower
            //------------------------------------------------
            // 1) Tower body (gray)
            window.FillRectangle(Color.Gray, 450, 150, 80, 150);

            // 2) A DVD drive slot (black rectangle)
            window.FillRectangle(Color.Black, 455, 160, 70, 20);

            // 3) Another front panel (black rectangle)
            window.FillRectangle(Color.Black, 455, 190, 70, 30);

            // Update (refresh) the screen to show everything
            SplashKit.RefreshScreen();
        }

        // Close the window when done
        window.Close();
    }
}
