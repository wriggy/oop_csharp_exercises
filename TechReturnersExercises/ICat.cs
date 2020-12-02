using System;

namespace TechReturners.Exercises
{
    public interface ICat
    {
        // properties
        bool IsAsleep { get; }
        string Setting { get; }
        int AverageHeight { get; }
        string Eat { get; }

        // methods
        void GoToSleep();
        void WakeUp();

    }

}
