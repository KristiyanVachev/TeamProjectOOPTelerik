namespace OOPGame.Core.Infrastructure
{
    using System.Collections.Generic;
    using System;
    using System.IO;

    using Interfaces;
    using Models;

    public class Seed
    {
        //TODO: Impement seed with random monsters
        public static IList<Monster> SeedMonsters()
        {
            List<Monster> monsters = new List<Monster>();
            monsters.AddRange(GetWeakMonsters());
            monsters.AddRange(GetPowerfulMonster());
            monsters.AddRange(GetBossMonster());

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

        /// <summary>
        /// Reads data from database about weak monsters.
        /// </summary>
        /// <returns>List of all weak monsters in DB.</returns>
        private static ICollection<WeakMonster> GetWeakMonsters()
        {
            List<WeakMonster> monsters = new List<WeakMonster>();
            string[] weakMonsters = File.ReadAllLines(Path.GetFullPath(@"..\..\..\OOPGame.Core\Infrastructure\Database\WeakMonstersDB.txt"));


            foreach (var weakMonster in weakMonsters)
            {
                string[] parameters = weakMonster.Split(',');
                monsters.Add(new WeakMonster(parameters[0], Int32.Parse(parameters[1]), Int32.Parse(parameters[2]),
                    Int32.Parse(parameters[3]), Int32.Parse(parameters[4]), parameters[5], parameters[6], parameters[7]
                    ));
            }

            return monsters;
        }
        /// <summary>
        /// Reads data from database about powerful monsters.
        /// </summary>
        /// <returns>List of all the powerful monsters in DB.</returns>
        private static ICollection<PowerfulMonster> GetPowerfulMonster()
        {
            List<PowerfulMonster> monsters = new List<PowerfulMonster>();

            string[] powerfulMonsters = File.ReadAllLines(Path.GetFullPath(@"..\..\..\OOPGame.Core\Infrastructure\Database\PowerfulMonstersDB.txt"));

            foreach (var powerfulMonster in powerfulMonsters)
            {
                string[] parameters = powerfulMonster.Split(',');
                monsters.Add(new PowerfulMonster(parameters[0], Int32.Parse(parameters[1]), Int32.Parse(parameters[2]),
                    Int32.Parse(parameters[3]), Int32.Parse(parameters[4]), parameters[5], parameters[6], parameters[7]
                    ));
            }
            return monsters;
        }
        /// <summary>
        /// Reads data from database about bosses.
        /// </summary>
        /// <returns>List of all bosses in the DB.</returns>
        private static ICollection<BossMonster> GetBossMonster()
        {
            List<BossMonster> monsters = new List<BossMonster>();
            string[] bossMonsters = File.ReadAllLines(Path.GetFullPath(@"..\..\..\OOPGame.Core\Infrastructure\Database\BossDB.txt"));

            foreach (var bossMonster in bossMonsters)
            {
                string[] parameters = bossMonster.Split(',');
                monsters.Add(new BossMonster(parameters[0], Int32.Parse(parameters[1]), Int32.Parse(parameters[2]),
                    Int32.Parse(parameters[3]), Int32.Parse(parameters[4]), parameters[5], parameters[6], parameters[7]
                    ));
            }
            return monsters;
        }
    }
}
