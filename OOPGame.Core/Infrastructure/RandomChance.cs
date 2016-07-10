namespace OOPGame.Core.Infrastructure
{
    using System;

    public static class RandomChance
    {
        public static bool Success(int chance)
        {
            //lets say chance = 70, we have a random number between 1 and 100. 
            //Then we have 70% chance to have a number lower than the random
            Random random = new Random();
            int rnd = random.Next(1, 101);

            return rnd < chance;
        }
    }
}
