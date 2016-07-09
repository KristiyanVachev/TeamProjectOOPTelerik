﻿namespace OOPGame.ConsoleClient
{
    using OOPGame.Core.Interfaces;
    using OOPGame.Core.Models;

    public static class Seed
    {
        //To-Do Impement seed with random monsters
        public static IMonster[] SeedMonsters()
        {
            IMonster[] monsters =
            {
                new WeakMonster("Stupid Panda", 100, 20, 10, 1, "Fur blow", "Bamboo strike", "Bamboo spear throw"), 
                new WeakMonster("Killer Whale", 200, 40, 20, 2, "Water shot","Tail punch", "Ripping bite"), 
                new PowerfulMonster("Beever",300,60, 30, 3, "Scrach", "Bite", "Tree crushing"), 
                new BossMonster("Dragon", 500, 100, 50, 5, "Tail spike", "Fireball", "Furnace")
            };

            return monsters;
        }

        public static IItem[] SeedRewards()
        {
            IItem[] items =
            {
                new Sword("Bastard Sword", 30, "Thrust"),
                new Shield("Roman Shield", 40),
                new Sword("Long Sword", 60, "Decapitating"),
                new Potion("Monstera na Koceto",80)
            };

            return items;
        }
    }
}
