using Xunit;
using TechReturners.Exercises;

namespace TechReturners.Tests
{
    public class CatTest
    {
        [Fact]
        public void CheckCatIsAwake()
        {
            ICat c = new DomesticCat();
            Assert.False(c.IsAsleep);
        }

        [Fact]
        public void CheckCatCanGoToSleep()
        {
            ICat c = new DomesticCat();
            c.GoToSleep();
            Assert.True(c.IsAsleep);
        }

        [Fact]
        public void CheckCatCanWakeUp()
        {
            ICat c = new DomesticCat();
            c.GoToSleep();
            c.WakeUp();
            Assert.False(c.IsAsleep);
        }

        [Fact]
        public void CheckCatSetting()
        {
            ICat c = new DomesticCat();
            Assert.Equal("domestic", c.Setting);
        }

        [Fact]
        public void CheckCatHeight()
        {
            ICat c = new DomesticCat();
            Assert.Equal(23, c.AverageHeight);
        }

        [Fact]
        public void CheckLionHeight()
        {
            ICat c = new LionCat();
            Assert.Equal(1100, c.AverageHeight);
        }

        [Fact]
        public void CheckFeedLion()
        {
            ICat c = new LionCat();
            Assert.Equal("Roar!!!!", c.Eat);
        }

        [Fact]
        public void CheckFeedCheetah()
        {
            ICat c = new CheetahCat();
            Assert.Equal("Zzzzzzz", c.Eat);
        }
        /*
                [Fact]
                public void CheckFeedCat()
                {
                    ICat c = new DomesticCat();
                    Assert.Equal("Purrrrrrr", c.Eat);
                }
        */
        // test Random Outburst
        [Fact]
        public void CheckFeedRandomCat()
        {
            ICat c = new DomesticCat();
            bool hasPurred = false;
            bool hasSpoken = false;

            for (int i = 0; i < 20; i++)
            {
                string outburst = c.Eat;
                hasPurred = hasPurred | (outburst == "Purrrrrrr");
                hasSpoken = hasSpoken | (outburst == "It will do I suppose");
                if (hasPurred & hasSpoken)
                {
                    break;
                }
            }
            Assert.True(hasPurred & hasSpoken);
        }

    }
}

