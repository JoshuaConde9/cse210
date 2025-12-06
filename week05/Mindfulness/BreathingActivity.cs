using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
        : base("Breathing",
        "This activity helps you relax by guiding you through slow breathing.")
    { }

    public void Run()
    {
        DisplayStartingMessage();

        int duration = GetDuration();
        int elapsed = 0;

        while (elapsed < duration)
        {
            Console.Write("Breathe in... ");
            ShowCountDown(4);
            elapsed += 4;

            if (elapsed >= duration) break;

            Console.Write("Breathe out... ");
            ShowCountDown(4);
            elapsed += 4;
        }

        DisplayEndingMessage();
    }
}
