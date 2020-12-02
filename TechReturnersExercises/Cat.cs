using System;

namespace TechReturners.Exercises
{
    // implements ICat interface
    public abstract class Cat : ICat
    {
        //properties
        public bool IsAsleep { get; private set; }
        public string Setting { get; private set; }
        public int AverageHeight { get; private set; }
        public virtual string Eat { get; private set; }


        // constructor
        public Cat(string setting, int averageHeight, string eat)
        {
            this.IsAsleep = false;
            this.Setting = setting;
            this.AverageHeight = averageHeight;
            this.Eat = eat;
        }

        // methods
        public void GoToSleep()
        {
            this.IsAsleep = true;
        }

        public void WakeUp()
        {
            this.IsAsleep = false;
        }
    }

    // derived classes
    public class DomesticCat : Cat
    {

        Random random = new Random();

        // use base class constructor
        public DomesticCat() : base("domestic", 23, "Purrrrrrr")
        {
        }

        private string randomResponse()
        {
            int num = random.Next(10);
            if (num < 5)
            {
                return "It will do I suppose";
            }
            else
            {
                return "Purrrrrrr";
            }
        }
        // polymorphism.. overriding the getter
        public override string Eat
        {
            get => randomResponse();
        }
    }

    public class LionCat : Cat
    {
        public LionCat() : base("lion", 1100, "Roar!!!!")
        {
        }
    }

    public class CheetahCat : Cat
    {
        public CheetahCat() : base("cheetah", 900, "Zzzzzzz")
        {
        }
    }
}