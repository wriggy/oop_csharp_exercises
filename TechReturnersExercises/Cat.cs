using System;

namespace TechReturners.Exercises
{
    public class Cat : ICat
    {
        public string Setting { get; set; }
        public int AverageHeight { get; set; }
        public string Eat { get; set; }
        public bool IsAsleep { get; set;}

        public void GoToSleep()
        {
            this.IsAsleep = true;
        }

        public void WakeUp()
        {
            this.IsAsleep = false;
        }
    }


    public class DomesticCat : Cat
    {
        public DomesticCat()
        {
        this.Setting = "domestic";
        this.AverageHeight = 23;
        this.IsAsleep = false;
        }
    }

    public class LionCat : Cat
    {

    }

    public class CheetahCat : Cat
    {

    }
}